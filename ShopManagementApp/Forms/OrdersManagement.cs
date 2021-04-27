using ShopManagementApp.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagementApp
{
    public partial class OrdersManagement : Form
    {
        public OrdersManagement()
        {
            InitializeComponent();
        }

        private void OrdersManagement_Load(object sender, EventArgs e)
        {
            FormControls.BindData(dgv_Orders, "orders");
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.ShowDialog(this);
            FormControls.BindData(dgv_Orders, "orders");
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text))
                FormControls.BindData(dgv_Orders, "orders");
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from customer where order_id = '" + txt_Search.Text + "'", FormControls.DbConnection);
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txt_Search.Text))
                FormControls.BindData(dgv_Orders, command: command);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            FormControls.ShowFields(true, gb_Status, gb_OrderDetails, btn_Save, btn_Cancel, label2, label3);
        }

        private void dgv_Orders_MouseClick(object sender, MouseEventArgs e)
        {
            BindFields();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel order editing?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                FormControls.ShowFields(false, gb_Status, gb_OrderDetails, btn_Save, btn_Cancel);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("delete orders where order_id = '" + (int)dgv_Orders.CurrentRow.Cells[0].Value + "'", FormControls.DbConnection);
                if (MessageBox.Show("Are you sure you want to delete selected order?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    FormControls.BindData(dgv_Orders, "orders");
                    MessageBox.Show("Order successfully removed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update orders set status = '" + gb_Status.Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault().Text + "' where order_id = '" + (int)dgv_Orders.CurrentRow.Cells[0].Value + "'", FormControls.DbConnection);
                command.ExecuteNonQuery();
                FormControls.BindData(dgv_Orders, "orders");
                FormControls.ShowFields(false, gb_Status, gb_OrderDetails, btn_Save, btn_Cancel);
                MessageBox.Show("Your changes have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindFields()
        {
            if (dgv_Orders.SelectedRows.Count == 1)
            {
                //binding customer who made the order
                SqlCommand getCustomer = new SqlCommand("select * from customer where customer_id = (select cast(customer_id as int) from customer_orders where order_id = '" + dgv_Orders.CurrentRow.Cells[0].Value + "')", FormControls.DbConnection);
                FormControls.BindData(dgv_Customer, command: getCustomer);
                FormControls.HideDGVColumns(dgv_Customer.Columns[0], dgv_Customer.Columns[6], dgv_Customer.Columns[7]);

                //binding products from order
                SqlCommand getProducts = new SqlCommand("select * from product where product_id = (select product_id from order_products where order_id = '" + dgv_Orders.CurrentRow.Cells[0].Value + "')", FormControls.DbConnection);
                FormControls.BindData(dgv_Products, command: getProducts);
                FormControls.HideDGVColumns(dgv_Products.Columns[1], dgv_Products.Columns[11]);
                UpdateProductAmount();

                //binding order status
                gb_Status.Controls.OfType<RadioButton>().Where(r => r.Text == dgv_Orders.CurrentRow.Cells[3].Value.ToString().Trim()).FirstOrDefault().Checked = true;
            }
        }

        private void UpdateProductAmount()
        {
            try
            {
                foreach (DataGridViewRow row in dgv_Products.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        SqlCommand command = new SqlCommand("select product_amount from order_products where product_id = '" + (string)row.Cells[2].Value + "' and order_id = '" + (int)dgv_Orders.CurrentRow.Cells[0].Value + "'", FormControls.DbConnection);
                        row.Cells[0].Value = (int)command.ExecuteScalar();
                        dgv_Products.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

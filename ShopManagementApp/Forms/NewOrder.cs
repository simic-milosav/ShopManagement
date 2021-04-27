using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopManagementApp.Forms
{
    public partial class NewOrder : Form
    {
        private Order order;
        private Customer customer;
        private readonly SqlCommand defaultCustomersCommand = new SqlCommand("select * from customer", FormControls.DbConnection);
        private readonly SqlCommand defaultProductsCommand = new SqlCommand("select * from product", FormControls.DbConnection);
        private bool cstIsSelected;
        private bool productsAdded;

        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            order = new Order(DateTime.Now);
            gb_NewCst.Enabled = false;
            FormControls.HideDGVColumns(dgv_Customers.Columns[0], dgv_Customers.Columns[7], dgv_Products.Columns[2]);
            FormControls.SetComboboxDefaultValue(cBoxType);
            FormControls.BindData(dgv_Customers, command: defaultCustomersCommand);
            FormControls.BindData(dgv_Products, command: defaultProductsCommand);
        }

        private void rb_ExCst_CheckedChanged(object sender, EventArgs e)
        {
            dgv_Customers.Enabled = rb_ExCst.Checked;
            btn_SelectCst.Enabled = rb_ExCst.Checked;
            gb_NewCst.Enabled = rb_NewCst.Checked;
            cstIsSelected = rb_NewCst.Checked;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (dgv_Products.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Products.SelectedRows)
                {
                    if (!string.IsNullOrEmpty((string)row.Cells[0].Value))
                    {
                        Product product = new Product((string)row.Cells[3].Value, float.Parse(row.Cells[10].Value.ToString()), int.Parse(row.Cells[12].Value.ToString()), int.Parse(row.Cells[11].Value.ToString()));
                        if (row.Cells[1].Value != null)
                            product.ProductIsFree(bool.Parse(row.Cells[1].Value.ToString()));
                        if (product.Stock - int.Parse(row.Cells[0].Value.ToString()) < 0)
                            MessageBox.Show("Entered amount exceeds stock amount!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            product.SelectedAmount = int.Parse(row.Cells[0].Value.ToString());
                            product.Stock -= product.SelectedAmount;
                            order.Products.Add(product);
                            productsAdded = true;
                        }
                    }
                    else
                        MessageBox.Show("Please enter amount of products you wish to add!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                order.CalculatePrice();
                lbl_Total.Text = order.Price.ToString();
            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txt_Search.Text))
            {
                SqlCommand command = new SqlCommand("select * from product where product_id = '" + txt_Search.Text + "' OR name LIKE '" + txt_Search.Text + "%' OR brand = '" + txt_Search.Text + "' OR type = '" + txt_Search.Text + "' OR subtype = '" + txt_Search.Text + "'", FormControls.DbConnection);
                FormControls.BindData(dgv_Products, command: command);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text))
                FormControls.BindData(dgv_Products, command: defaultProductsCommand);
        }

        private void txt_SearchCst_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SearchCst.Text))
                FormControls.BindData(dgv_Customers, command: defaultCustomersCommand);
        }

        private void txt_SearchCst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txt_Search.Text))
            {
                SqlCommand command = new SqlCommand("select * from customer where name LIKE '" + txt_SearchCst.Text + "%' OR surname LIKE '" + txt_SearchCst.Text + "%' OR address LIKE '" + txt_SearchCst.Text + "%' OR phone_number = '" + txt_SearchCst.Text + "' OR email = '" + txt_SearchCst.Text + "' OR type = '" + txt_SearchCst.Text + "'", FormControls.DbConnection);
                FormControls.BindData(dgv_Customers, command: command);
            }
        }

        private void btn_PlaceOrd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled) && cstIsSelected && productsAdded)
                {
                    int customerID = ProcessCustomer();
                    ProcessOrder();
                    FillTables(customerID);
                    Close();
                }
                else
                    MessageBox.Show("Please fill all fields!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SelectCst_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Customers.SelectedRows.Count == 1)
                {
                    SqlCommand getCustomer = new SqlCommand("select customer_id, type, orders_number from customer where customer_id = '" + dgv_Customers.CurrentRow.Cells[0].Value + "'", FormControls.DbConnection);
                    customer = new Customer();
                    using (SqlDataReader customerReader = getCustomer.ExecuteReader())
                    {
                        while (customerReader.Read())
                        {
                            customer.CustomerId = (int)customerReader["customer_id"];
                            customer.Type = customerReader["type"].ToString();
                            customer.OrdersNum = (int)customerReader["orders_number"];
                        }
                    }
                    cstIsSelected = true;
                    FormControls.ShowFields(false, btn_SelectCst, gb_SelectCst, dgv_Customers, label9, txt_SearchCst);
                }
                else
                    MessageBox.Show("Please select one customer!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rb_FreeShp_CheckedChanged(object sender, EventArgs e)
        {
            txt_ShpPrice.Visible = rb_ChargeShp.Checked;
        }

        private void gb_ShpPrice_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, gb_ShpPrice, errorProvider);
        }

        private void gb_SelectCst_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, gb_SelectCst, errorProvider);
        }

        private void cBoxType_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, cBoxType, errorProvider);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtName, errorProvider);
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtSurname, errorProvider);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtAddress, errorProvider);
        }

        private void txtPhoneNum_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtPhoneNum, errorProvider);
        }

        private int ProcessCustomer()
        {
            int customerID;
            if (rb_NewCst.Checked)
            {
                SqlCommand newCustomer = new SqlCommand("insert into customer values ('" + txtName.Text + "','" + txtSurname.Text + "','" + txtAddress.Text + "','" + txtPhoneNum.Text + "','" + txtEmail.Text + "','" + cBoxType.Text + "','" + 1 + "')", FormControls.DbConnection);
                newCustomer.ExecuteNonQuery();
                SqlCommand newCustomerId = new SqlCommand("select max(customer_id) from customer", FormControls.DbConnection);
                customerID = (int)newCustomerId.ExecuteScalar();
            }
            else
            {
                SqlCommand updateCustomer = new SqlCommand("update customer set type = '" + customer.Type + "', orders_number = '" + customer.OrdersNum + "' where customer_id = '" + customer.CustomerId + "'", FormControls.DbConnection);
                customer.OrdersNum += 1;
                customer.SetType();
                customerID = customer.CustomerId;
                updateCustomer.ExecuteNonQuery();
            }
            return customerID;
        }

        private void ProcessOrder()
        {
            order.Shipping = rb_ChargeShp.Checked ? float.Parse(txt_ShpPrice.Text) : 0;
            order.CalculatePrice();
            SqlCommand newOrder = new SqlCommand("insert into orders values ('" + order.Price + "','" + order.Created + "', 'Preparing')", FormControls.DbConnection);
            newOrder.ExecuteNonQuery();
            SqlCommand newOrderId = new SqlCommand("select max(order_id) from orders", FormControls.DbConnection);
            order.OrderId = (int)newOrderId.ExecuteScalar();
        }

        private void FillTables(int customerID)
        {
            SqlCommand customerOrders = new SqlCommand("insert into customer_orders values ('" + customerID + "','" + order.OrderId + "')", FormControls.DbConnection);
            customerOrders.ExecuteNonQuery();
            foreach (Product product in order.Products)
            {
                SqlCommand updateProduct = new SqlCommand("update product set stock = '" + product.Stock + "' where product_id = '" + product.ProductId + "'", FormControls.DbConnection);
                updateProduct.ExecuteNonQuery();
                SqlCommand ordersProducts = new SqlCommand("insert into order_products values ('" + order.OrderId + "','" + product.ProductId + "','" + product.SelectedAmount + "')", FormControls.DbConnection);
                ordersProducts.ExecuteNonQuery();
            }
        }
    }
}

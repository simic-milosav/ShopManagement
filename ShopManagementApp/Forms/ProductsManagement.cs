using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagementApp
{
    public partial class ProductsManagement : Form
    {
        private readonly string[] adultsClothingSize = new string[] { "XXXS", "XXS", "XS", "S", "M", "L", "XL", "XXL", "XXXL" };
        private readonly int[] adultsFootwearSize = new int[] { 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };
        private readonly string[] kidsClothingSize = new string[] { "80 cm", "80-86 cm", "86-92 cm", "92-98 cm", "98-104 cm", "104-110 cm", "110-116 cm", "116-122 cm", "122-128 cm", "128-134 cm", "134-140 cm", "140-146 cm", "146-152 cm", "152-158 cm", "158-164 cm" };
        private readonly int[] kidsFootwearSize = new int[] { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37 };
        private bool isNew;

        public ProductsManagement()
        {
            InitializeComponent();
        }

        private void ProductsManagement_Load(object sender, EventArgs e)
        {
            FormControls.ShowFields(false, txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale, gb_Subtype, gb_Type, btnCancel, btnSave, label1, label2, label3, label4, label5, label6, label7, label8, label9, label11);
            FormControls.SetComboboxDefaultValue(cbBrand, cbColor, cbSize);
            BindData(); 
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormControls.ShowFields(true, txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale, gb_Subtype, gb_Type, btnCancel, btnSave, label1, label2, label3, label4, label5, label6, label7, label8, label9, label11);
            FormControls.ResetFields(txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale);
            isNew = true;
            txtProductId.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormControls.ShowFields(false, txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale, gb_Subtype, gb_Type, btnCancel, btnSave, label1, label2, label3, label4, label5, label6, label7, label8, label9, label11);
            FormControls.ResetFields(txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormControls.ShowFields(true, txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale, gb_Subtype, gb_Type, btnCancel, btnSave, label1, label2, label3, label4, label5, label6, label7, label8, label9, label11);
            isNew = false;
            txtProductId.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("delete product where id = '" + (int)dgv_Product.CurrentRow.Cells[0].Value + "'", DatabaseConnection.Connection);
                if (MessageBox.Show("Are you sure you want to delete selected products?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    BindData();
                    MessageBox.Show("Product successfully removed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    FormControls.ShowFields(false, txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale, gb_Subtype, gb_Type, btnCancel, btnSave, label1, label2, label3, label4, label5, label6, label7, label8, label9, label11);
                    SqlCommand command;
                    if (isNew)
                        command = new SqlCommand("insert into product values ('" + txtProductId.Text + "','" + txtName.Text + "','" + cbBrand.SelectedItem + "','" + CheckedRadioButton(gb_Type) + "','" + CheckedRadioButton(gb_Subtype) + "','" + cbColor.SelectedItem + "','" + cbSize.SelectedItem + "','" + txtPrice.Text + "','" + txtDiscount.Text + "','" + txtStock.Text + "')", DatabaseConnection.Connection);
                    else
                        command = new SqlCommand("update product set product_id = '" + txtProductId.Text + "', name = '" + txtName.Text + "', brand = '" + cbBrand.SelectedItem + "', type = '" + CheckedRadioButton(gb_Type) + "', subtype = '" + CheckedRadioButton(gb_Subtype) + "', color = '" + cbColor.SelectedItem + "', size = '" + cbSize.SelectedItem + "', price = '" + txtPrice.Text + "', discount = '" + txtDiscount.Text + "', stock = '" + txtStock.Text + "' where id = '" + (int)dgv_Product.CurrentRow.Cells[0].Value + "'", DatabaseConnection.Connection);
                    command.ExecuteNonQuery();
                    BindData();
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbFootwear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFootwear.Checked && (rbMale.Checked || rbFemale.Checked))
                cbSize.DataSource = adultsFootwearSize;
            else if (rbFootwear.Checked && rbKids.Checked)
                cbSize.DataSource = kidsFootwearSize;
        }

        private void rbClothing_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClothing.Checked && (rbMale.Checked || rbFemale.Checked))
                cbSize.DataSource = adultsClothingSize;
            else if (rbClothing.Checked && rbKids.Checked)
                cbSize.DataSource = kidsClothingSize;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClothing.Checked && rbMale.Checked)
                cbSize.DataSource = adultsClothingSize;
            else if (rbFootwear.Checked && rbMale.Checked)
                cbSize.DataSource = adultsFootwearSize;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClothing.Checked && rbFemale.Checked)
                cbSize.DataSource = adultsClothingSize;
            else if (rbFootwear.Checked && rbFemale.Checked)
                cbSize.DataSource = adultsFootwearSize;
        }

        private void rbKids_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClothing.Checked && rbKids.Checked)
                cbSize.DataSource = kidsClothingSize;
            else if (rbFootwear.Checked && rbKids.Checked)
                cbSize.DataSource = kidsFootwearSize;
        }

        private void dgv_Product_MouseClick(object sender, MouseEventArgs e)
        {
            BindFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                BindData();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from product where product_id LIKE '" + txtSearch.Text + "%' OR name LIKE '" + txtSearch.Text + "%' OR price LIKE '" + txtSearch.Text + "%' OR discount = '" + txtSearch.Text + "'", DatabaseConnection.Connection);
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                    BindData(command);
            }
        }

        private void txtProductId_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtProductId, errorProvider);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtName, errorProvider);
        }

        private void gb_Type_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, gb_Type, errorProvider);
        }

        private void gb_Subtype_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, gb_Subtype, errorProvider);
        }

        private void cbSize_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, cbSize, errorProvider);
        }

        private void cbBrand_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, cbBrand, errorProvider);
        }

        private void cbColor_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, cbColor, errorProvider);
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtPrice, errorProvider);
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, txtStock, errorProvider);
        }

        private void BindData(SqlCommand command = null)
        {
            if (command == null)
                command = new SqlCommand("select * from product", DatabaseConnection.Connection);
            SqlDataAdapter productAdapter = new SqlDataAdapter(command);
            DataTable productTable = new DataTable();
            productAdapter.Fill(productTable);
            dgv_Product.DataSource = productTable;
        }

        private void BindFields()
        {
            if (dgv_Product.CurrentRow.Index < dgv_Product.Rows.Count - 1)
            {
                txtProductId.Text = (string)dgv_Product.CurrentRow.Cells[1].Value;
                txtName.Text = (string)dgv_Product.CurrentRow.Cells[2].Value;
                cbBrand.SelectedItem = (string)dgv_Product.CurrentRow.Cells[3].Value;
                cbColor.SelectedItem = (string)dgv_Product.CurrentRow.Cells[6].Value;
                cbSize.SelectedItem = dgv_Product.CurrentRow.Cells[7].Value.ToString();
                txtPrice.Text = dgv_Product.CurrentRow.Cells[8].Value.ToString();
                txtDiscount.Text = dgv_Product.CurrentRow.Cells[9].Value.ToString();
                gb_Type.Controls.OfType<RadioButton>().Where(r => r.Text == (string)dgv_Product.CurrentRow.Cells[4].Value).FirstOrDefault().Checked = true;
                gb_Subtype.Controls.OfType<RadioButton>().Where(r => r.Text == (string)dgv_Product.CurrentRow.Cells[5].Value).FirstOrDefault().Checked = true;
                txtStock.Text = dgv_Product.CurrentRow.Cells[10].Value.ToString();
            }
            else
                FormControls.ResetFields(txtProductId, txtName, txtPrice, txtStock, txtDiscount, cbBrand, cbColor, cbSize, rbClothing, rbFemale, rbFootwear, rbKids, rbMale);
        }

        private string CheckedRadioButton(GroupBox gb)
        {
            return gb.Controls.OfType<RadioButton>().Where(r => r.Checked == true).FirstOrDefault().Text;
        }
    }
}

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopManagementApp
{
    public partial class CustomersManagement : Form
    {
        private bool isNew;
        public CustomersManagement()
        {
            InitializeComponent();
        }

        private void CustomersManagement_Load(object sender, EventArgs e)
        {
            FormControls.ShowFields(false, txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType, btnSave, btnCancel, label1, label2, label3, label4, label5, label6);
            FormControls.SetComboboxDefaultValue(cBoxType);
            BindData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormControls.ShowFields(true, txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType, btnSave, btnCancel, label1, label2, label3, label4, label5, label6);
            FormControls.ResetFields(txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType);
            isNew = true;
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormControls.ShowFields(true, txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType, btnSave, btnCancel, label1, label2, label3, label4, label5, label6);
            isNew = false;
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormControls.ShowFields(false, txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType, btnSave, btnCancel, label1, label2, label3, label4, label5, label6);
            FormControls.ResetFields(txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    FormControls.ShowFields(false, txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType, btnSave, btnCancel, label1, label2, label3, label4, label5, label6);
                    SqlCommand command;
                    if (isNew)
                        command = new SqlCommand("insert into customer values ('" + txtName.Text + "','" + txtSurname.Text + "','" + txtAddress.Text + "','" + txtPhoneNum.Text + "','" + txtEmail.Text + "','" + cBoxType.Text + "','" + 0 + "')", ShopManagement.Connection);
                    else
                        command = new SqlCommand("update customer set name = '" + txtName.Text + "', surname = '" + txtSurname.Text + "', address = '" + txtAddress.Text + "', phone_number = '" + txtPhoneNum.Text + "', email = '" + txtEmail.Text + "', type = '" + cBoxType.Text + "' where customer_id = '" + (int)dgv_Customer.CurrentRow.Cells[0].Value + "'", ShopManagement.Connection);
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from customer where name LIKE '" + txtSearch.Text + "%' OR surname LIKE '" + txtSearch.Text + "%' OR address LIKE '" + txtSearch.Text + "%' OR phone_number = '" + txtSearch.Text + "' OR email = '" + txtSearch.Text + "' OR type = '" + txtSearch.Text + "'", ShopManagement.Connection);
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSearch.Text))
                BindData(command);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                BindData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("delete customer where customer_id = '" + (int)dgv_Customer.CurrentRow.Cells[0].Value + "'", ShopManagement.Connection);
                if (MessageBox.Show("Are you sure you want to delete selected customer?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    BindData();
                    MessageBox.Show("Customer successfully removed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Customer_MouseClick(object sender, MouseEventArgs e)
        {
            BindFields();
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

        private void cBoxType_Validating(object sender, CancelEventArgs e)
        {
            FormControls.ProvideError(e, cBoxType, errorProvider);
        }

        private void BindData(SqlCommand command = null)
        {
            try
            {
                if (command == null)
                    command = new SqlCommand("select * from customer", ShopManagement.Connection);
                SqlDataAdapter customerAdapter = new SqlDataAdapter(command);
                DataTable customerTable = new DataTable();
                customerAdapter.Fill(customerTable);
                dgv_Customer.DataSource = customerTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindFields()
        {
            try
            {
                if (dgv_Customer.CurrentRow.Index < dgv_Customer.Rows.Count - 1)
                {
                    txtName.Text = (string)dgv_Customer.CurrentRow.Cells[1].Value;
                    txtSurname.Text = (string)dgv_Customer.CurrentRow.Cells[2].Value;
                    txtAddress.Text = (string)dgv_Customer.CurrentRow.Cells[3].Value;
                    txtPhoneNum.Text = (string)dgv_Customer.CurrentRow.Cells[4].Value;
                    txtEmail.Text = (string)dgv_Customer.CurrentRow.Cells[5].Value;
                    cBoxType.SelectedItem = (string)dgv_Customer.CurrentRow.Cells[6].Value;
                }
                else
                    FormControls.ResetFields(txtName, txtSurname, txtAddress, txtPhoneNum, txtEmail, cBoxType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

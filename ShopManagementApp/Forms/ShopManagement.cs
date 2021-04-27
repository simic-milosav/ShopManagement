/*
 
    Main form for selecting which type to manipulate. 
 
*/

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ShopManagementApp
{
    public partial class ShopManagement : Form
    {
        public ShopManagement()
        {
            InitializeComponent();
        }

        ~ShopManagement()
        {
            FormControls.DbConnection.Close();
        }

        private void ShopManagement_Load(object sender, EventArgs e)
        {
            try
            {
                FormControls.DbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
                FormControls.DbConnection.Open();
                MessageBox.Show("Successfully connected to database.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OrdMan_Click(object sender, EventArgs e)
        {
            OrdersManagement ordersManagement = new OrdersManagement();
            ordersManagement.ShowDialog(this);
        }

        private void btn_ProMng_Click(object sender, EventArgs e)
        {
            ProductsManagement productsManagement = new ProductsManagement();
            productsManagement.ShowDialog(this);

        }

        private void btn_CusMng_Click(object sender, EventArgs e)
        {
            CustomersManagement customersManagement = new CustomersManagement();
            customersManagement.ShowDialog(this);
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;


namespace ShopManagementApp
{
    public partial class ShopManagement : Form
    {
        public static SqlConnection Connection { get; set; }

        public ShopManagement()
        {
            InitializeComponent();
        }

        ~ShopManagement()
        {
            Connection.Close();
        }

        private void ShopManagement_Load(object sender, EventArgs e)
        {
            try
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString);
                Connection.Open();
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

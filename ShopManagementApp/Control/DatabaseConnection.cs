using System.Data.SqlClient;

namespace ShopManagementApp
{
    internal sealed class DatabaseConnection
    {
        public static SqlConnection Connection { get; set; }
    }
}

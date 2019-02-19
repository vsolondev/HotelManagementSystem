using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public static class DatabaseConnection
    {
        public static IDbConnection Connect()
        {
            IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString);

            return db;
        }
    }
}

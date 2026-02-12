//using Microsoft.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace SQLTestDB.Data
{
    public class SqlConn
    {
        private static string connString = "Server=server-name;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
        //public static void Main(string[] args)
        //{
        //    try
        //    {
        //        SqlConnection conn = GetConnection();
        //        conn.Open();
        //        Console.WriteLine("Server connected");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
    }
}

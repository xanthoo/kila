using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public static class TransactionsDataAccess
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public static void AddTransaction(Order o, Product p)
        {
            string query = "INSERT INTO transactions(`order_id`, `product_id`, `product_price`, `completed_on`) VALUES('" + o.ID + "','" + p.ID + "', '" + p.SellingPrice + "', '"+o.OrderedOn+"')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

            }
            catch (Exception)
            {
                throw new Exception("Check your connection to the database!");
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    }
}

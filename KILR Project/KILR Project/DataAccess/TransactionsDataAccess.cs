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
        public static List<Transaction> GetAllTranscations()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                List<Transaction> transactions = new List<Transaction>();
                transactions.Clear();
                string sql = " SELECT * FROM transactions;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transactions.Add(new Transaction(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]), Convert.ToDecimal(reader[2]), Convert.ToDecimal(reader[3]), reader[4].ToString()));
                }
                return transactions;
            }
            catch (Exception)
            {
                throw new Exception("Check your connection to the database!");
            }
            finally
            {
                connection.Close();
            }

        }
        public static void AddTransaction(Order o, Product p)
        {
            string query = "INSERT INTO transactions(`order_id`, `product_id`, `product_price`, `product_buyingprice`, `completed_on`) VALUES('" + o.ID + "','" + p.ID + "', '" + p.SellingPrice + "', '"+p.BuyingPrice+"', '"+o.OrderedOn+"')";

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

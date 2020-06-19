using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public static class OrderDataAccess
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public static void AddOrder(Order o)
        {
            string query = "INSERT INTO orders(`id`, `ordered_on`, `made_by`, `total`, `items_quantity`) VALUES(NULL, '"+o.OrderedOn+"','"+o.MadeBy+"', '"+o.Total+"','"+o.AmountOfItems+"')";

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
        public static List<Order> GetAllOrders()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                List<Order> orders = new List<Order>();
                orders.Clear();
                string sql = " SELECT * FROM orders;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Order(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3])));
                }
                return orders.ToList();
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
    }
}

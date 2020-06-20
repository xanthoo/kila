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
            string query = "";
            if(o.IsAborted == true)
            {
                query += "INSERT INTO orders(`id`, `ordered_on`, `made_by`, `total`, `items_quantity`, `is_aborted`) VALUES(NULL, '" + o.OrderedOn + "','" + o.MadeBy + "', '" + o.Total + "','" + o.AmountOfItems + "', 1)";
            }
            else
            {
                query += "INSERT INTO orders(`id`, `ordered_on`, `made_by`, `total`, `items_quantity`, `is_aborted`) VALUES(NULL, '" + o.OrderedOn + "','" + o.MadeBy + "', '" + o.Total + "','" + o.AmountOfItems + "', 0)";
            }
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
                    if (Convert.ToInt32(reader[5]) == 0)
                    {
                        orders.Add(new Order(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3]), false));
                    }
                    else if(Convert.ToInt32(reader[5]) == 1)
                    {
                        orders.Add(new Order(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToDecimal(reader[3]), true));
                    }
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
        public static void AbortOrder(Order o)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                string sql = "UPDATE `orders` SET `is_aborted` = '1' WHERE `orders`.`id` = " + o.ID + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                int effectedRows = cmd.ExecuteNonQuery();
                RemoveAllAssociatedTransactions(o);
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
        public static void RemoveAllAssociatedTransactions(Order o)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                string sql = "DELETE FROM `transactions` WHERE `transactions`.`order_id` = " + o.ID + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                int effectedRows = cmd.ExecuteNonQuery();
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

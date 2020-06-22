
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public static class ProductDataAccess
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public static void AddStock(Product p)
        {
            string query = "INSERT INTO product(`productid`, `productname`, `quantity`,`sellingprice`,`buyingprice`,`stockactivity`,`minquantity`,`datecreated`) VALUES(NULL, '" + p.Name + "', '" + p.Quanitity + "', '" + p.SellingPrice + "', '" + p.BuyingPrice + "', 1, '" + p.MinimumQuantity + "', '" + p.DateCreated + "')";

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
        public static List<Product> GetAllStocks()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                List<Product> products = new List<Product>();
                products.Clear();
                string sql = " SELECT * FROM product;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), Convert.ToDecimal(reader[3]), Convert.ToDecimal(reader[4]), Convert.ToBoolean(reader[5]), Convert.ToInt32(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9])));
                }
                return products;
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
        public static bool UpdateStock(Product p)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                if (p.IsActive == true)
                {
                    string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice +
                    "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '" + 1 + "', `minquantity` = '" + p.MinimumQuantity + "', `dateupdated` = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', `updatedby` = '" + p.UpdatedBy + "' WHERE `product`.`productid` = " + p.ID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    return true;

                }
                else
                {
                    string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice +
                                  "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '" + 0 + "', `minquantity` = '" + p.MinimumQuantity + "', `dateupdated` = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "', `updatedby` = '" + p.UpdatedBy + "' WHERE `product`.`productid` = " + p.ID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    return true;
                }
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
        public static List<Product> SearchForProduct(string name = "")
        {
            List<Product> products = new List<Product>();
            products.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                string sql = "SELECT * FROM product WHERE productname LIKE '%" + name + "%';";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), Convert.ToDecimal(reader[3]), Convert.ToDecimal(reader[4]), Convert.ToBoolean(reader[5]), Convert.ToInt32(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9])));
                }
                return products;
            }
            catch(Exception e)
            {
                throw new InvalidOperationException();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

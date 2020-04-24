using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace KILR_Project
{
    public static class DB
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";

        public static DataRow FindUser(string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT id, username, position FROM users WHERE username = @username AND password = @password",
                    connection
                );
                adapter.SelectCommand.Parameters.AddWithValue("@username", username);
                adapter.SelectCommand.Parameters.AddWithValue("@password", password);
                connection.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    return null;
                }

                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //STOCK DATABASE MANAGER

        public static bool AddStock(Product p)
        {
            string query = "INSERT INTO product(`productid`, `productname`, `quantity`,`sellingprice`,`buyingprice`,`stockactivity`,`minquantity`,`datecreated`) VALUES(NULL, '" + p.Name + "', '" + p.Quanitity + "', '" + p.SellingPrice + "', '" + p.BuyingPrice + "', 1, '" + p.MinimumQuantity + "', '" + p.DateCreated + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                databaseConnection.Close();
            }
        }
        public static List<Product> GetAllStocks()
        {
            List<Product> products = new List<Product>();
            products.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = " SELECT * FROM product;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), Convert.ToDecimal(reader[3]), Convert.ToDecimal(reader[4]), Convert.ToBoolean(reader[5]), Convert.ToInt32(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8])));
            }
            connection.Close();
            return products;
        }
        public static bool UpdateStock(Product p)
        {
                MySqlConnection connection = new MySqlConnection(connectionString);
                if (p.IsActive == true)
                {
                    string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice +
                    "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '" + 1 + "', `minquantity` = '" + p.MinimumQuantity + "', `dateupdated` = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' WHERE `product`.`productid` = " + p.ID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;

                }
                else
                {
                string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice +
                "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '" + 0 + "', `minquantity` = '" + p.MinimumQuantity + "', `dateupdated` = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' WHERE `product`.`productid` = " + p.ID + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            
        }
        //END OF STOCK DATABASE MANAGER
    }
}

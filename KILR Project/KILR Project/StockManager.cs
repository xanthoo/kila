using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KILR_Project
{
    public class StockManager
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        private string name;
        public StockManager(string name)
        {
            this.name = name;
        }
        public bool AddStock(Product p)
        {
            string query = "INSERT INTO product(`productid`, `productname`, `quantity`,`sellingprice`,`buyingprice`,`stockactivity`) VALUES(NULL, '" + p.Name + "', '" + p.Quanitity + "', '" + p.SellingPrice + "', '" + p.BuyingPrice + "', 1)";

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
        public Product FindStock(int id)
        {
            foreach (Product p in GetAllStocks())
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }
        public List<Product> GetAllStocks()
        {
            List<Product> products = new List<Product>();
            products.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = " SELECT * FROM product;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                products.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), Convert.ToDecimal(reader[3]), Convert.ToDecimal(reader[4]), Convert.ToBoolean(reader[5])));
               
            }
            connection.Close();
            return products;
        }
        public bool CheckIfStockExists(int id)
        {
            foreach (Product item in GetAllStocks())
            {
                if (id == item.ID)
                {
                    return true;
                }
            }
            return false;
        }
        public void Increase(Product p, int amount)
        {
            p.Quanitity += amount;
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = " UPDATE `product` SET `quantity` = '"+p.Quanitity+"' WHERE `product`.`productid` = "+p.ID+";";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@quantity", p.Quanitity);
            connection.Open();
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Decrease(Product p, int amount)
        {
            p.Quanitity -= amount;
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = " UPDATE `product` SET `quantity` = '" + p.Quanitity + "' WHERE `product`.`productid` = " + p.ID + ";";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@quantity", p.Quanitity);
            connection.Open();
            int effectedRows = cmd.ExecuteNonQuery();
            connection.Close();
        }
        public bool UpdateStock(Product p)
        {
            if (CheckIfStockExists(p.ID) == true)
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                if (p.IsActive == true)
                {
                    string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice + 
                    "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '"+1+"' WHERE `product`.`productid` = " + p.ID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;

                }
                else
                {
                    string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice +
                        "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '" + 0 + "' WHERE `product`.`productid` = " + p.ID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }


}


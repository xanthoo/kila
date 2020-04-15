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
        private string name;
        public StockManager(string name)
        {
            this.name = name;
        }
        public Product FindStock(int id)
        {
            foreach (Product p in DB.GetAllStocks())
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }
        public bool CheckIfStockExists(int id)
        {
            foreach (Product item in DB.GetAllStocks())
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
            DB.UpdateStock(p);
        }
        public void Decrease(Product p, int amount)
        {
            p.Quanitity -= amount;
            DB.UpdateStock(p);
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //string sql = " UPDATE `product` SET `quantity` = '" + p.Quanitity + "' WHERE `product`.`productid` = " + p.ID + ";";
            //MySqlCommand cmd = new MySqlCommand(sql, connection);
            //cmd.Parameters.AddWithValue("@quantity", p.Quanitity);
            //connection.Open();
            //int effectedRows = cmd.ExecuteNonQuery();
            //connection.Close();
        }
   
    }


}


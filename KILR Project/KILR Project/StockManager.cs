﻿using System;
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
        private List<Product> stocks;
        public StockManager(List<Product>products)
        {
            this.stocks = products;
        }
        public Product FindStock(int id)
        {
            foreach (Product p in stocks)
                if (p.ID == id)
                    return p;

            return null;
        }
        public List<Product> GetAllStocks()
        {
            return this.stocks.ToList();
        }
        public void AddStock(Product p)
        {
            stocks.Add(p);
            DB.AddStock(p);
        }
        public bool CheckIfStockExists(int id)
        {
            foreach (Product item in stocks)
                if (id == item.ID)
                    return true;
  
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
        }
        public int GenerateID()
        {
            List<int>ids = new List<int>();
            foreach (Product p in stocks)
                ids.Add(p.ID);
            return ids.Max() + 1;
        }
   
    }


}


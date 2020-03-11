using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class StockManager
    {
        private string name;
        private List<Product> stocks;

        public StockManager(string name)
        {
            this.name = name;
            stocks = new List<Product>();
        }
        public void AddStock(Product p)
        {
            stocks.Add(p);
        }
        public bool RemoveStock(Product p)
        {
            if (CheckIfStockExists(p.ID) == false)
            {
                return false;
            }
            else
            {
                stocks.Remove(p);
                return true;
            }
        }
        public Product FindProduct(int id)
        {
            foreach (Product p in stocks)
            {
                if (id == p.ID)
                {
                    return p;
                }
            }
            return null;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> getStocks = new List<Product>();
            foreach (Product item in stocks)
            {
                getStocks.Add(item);
            }
            return getStocks;
        }
        public bool CheckIfStockExists(int id)
        {
            foreach (Product item in stocks)
            {
                if (id == item.ID)
                {
                    return true;
                }
            }
            return false;
        }
    }   
}


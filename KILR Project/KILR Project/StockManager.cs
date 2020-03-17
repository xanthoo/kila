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

        private decimal totalRevenue;
        public decimal TotalRevenue { get { return this.totalRevenue; } set { this.totalRevenue = value; } }
        public StockManager(string name)
        {
            this.name = name;
            stocks = new List<Product>();
        }
        public void AddStock(Product p)
        {
            stocks.Add(p);
        }
        public bool DisableStock(Product p)
        {
            if (CheckIfStockExists(p.ID) == false && (p.IsActive == false))
            {
                return false;
            }
            else
            {
                p.IsActive = false;
                return true;
            }
        }
        public bool EnableStock(Product p)
        {
                if (CheckIfStockExists(p.ID) == false && (p.IsActive == true))
                {
                    return false;
                }
                else
                {
                    stocks.Remove(p);
                    p.IsActive = true;
                    return true;
                }
        }
        public Product FindStock(int id)
        {
            foreach (Product p in stocks)
            {
            }
            return null;
        }
        public List<Product> GetAllStocks()
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
        public decimal Sell(Product p)
        {
            return TotalRevenue += p.SellingPrice;
        }
        public decimal Buy(Product p)
        {
            return TotalRevenue -= p.SellingPrice;
        }
    }


}


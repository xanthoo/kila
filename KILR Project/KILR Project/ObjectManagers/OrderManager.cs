using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class OrderManager
    {
        private List<Order> orders;
        public OrderManager(List<Order>allOrders)
        {
            orders = allOrders;
        }
        public void AddOrder(Order o)
        {
            orders.Add(o);
            foreach (Product p in o.GetAllOrderProducts())
            {
                TransactionsDataAccess.AddTransaction(o, p);
            }
            OrderDataAccess.AddOrder(o);
        }
        public Order GetOrder(int id)
        {
            foreach(Order o in orders)
            {
                if(id == o.ID)
                {
                    return o;
                }
            }
            return null;
        }
        public List<Order> GetAllOrders()
        {
            return this.orders.ToList();
        }
        public decimal GetTotalShopRevenue()
        { 
            decimal totalRevenue = 0;
            CalculateTotalShopRevenue(ref totalRevenue);
            return Math.Round(totalRevenue, 2, MidpointRounding.ToEven);
        }
        private void CalculateTotalShopRevenue(ref decimal amount)
        {
            foreach(Order o in orders)
            {
                amount += o.Total;
            }
        }
        public int GenerateUniqueID()
        {
            List<int> orderIDs = new List<int>();
            foreach (Order o in orders)
            {
                orderIDs.Add(o.ID);
            }
            return orderIDs.Max() + 1;
        }
    }
}

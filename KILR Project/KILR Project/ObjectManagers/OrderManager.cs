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
            if (o.IsAborted == false)
            {
                foreach (Product p in o.GetAllOrderProducts())
                {
                    TransactionsDataAccess.AddTransaction(o, p);
                }
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
        public void AbortOrder(Order o)
        {
            o.IsAborted = true;
            OrderDataAccess.AbortOrder(o);
        }
        public List<Order> GetAllOrders()
        {
            return this.orders.ToList();
        }
        public int GenerateUniqueID()
        {
            List<int> orderIDs = new List<int>();
            if (orders.Count != 0)
            {
                foreach (Order o in orders)
                {
                    orderIDs.Add(o.ID);
                }
                return orderIDs.Max() + 1;
            }
            else
            {
                return 10000;
            }
           
        }
    }
}

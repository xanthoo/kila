using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class IncomeManager
    {
        OrderManager om;
        private List<Transaction> transactions;
        public OrderManager Manager { get { return this.om; } }

        public IncomeManager(OrderManager om, List<Transaction>transactions)
        {
            this.om = om;
            this.transactions = transactions;
        }
        public decimal GetTotalShopRevenue()
        {
            decimal totalRevenue = 0;
            CalculateTotalShopRevenue(ref totalRevenue);
            return Math.Round(totalRevenue, 2, MidpointRounding.ToEven);
        }
        private void CalculateTotalShopRevenue(ref decimal amount)
        {
            foreach(Transaction t in transactions)
            {
                amount += t.ProductPrice - t.ProductBuyingPrice;
            }
        }
        public List<Transaction> GetAllTransactions()
        {
            return this.transactions.ToList();
        }
        public List<Transaction> GetTransactionsToday()
        {
            List<Transaction> today = new List<Transaction>();
            foreach(Transaction t in transactions)
            {
                if (t.CreatedOn.Substring(0, 7) == DateTime.Today.ToString("yy-MM-dd"))
                {
                    today.Add(t);
                }
;            }
            return today;
        }
        public void AddTransaction(Transaction t)
        {
            transactions.Add(t);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class Product
    {
        public static int seeder = 100;
        private int id;
        private string name;
        private int productId;
        private string productName;
        private int amount;
        private int minAmount;
        private int maxAmount;
        private decimal sellingPrice;
        private decimal buyingPrice;
        private bool isActive;

        public int ID { get { return this.productId; } }
        public string Name { get { return this.productName; } set { this.productName = value; } }
        public int Amount { get { return this.amount; } set { this.amount = value; } }
        public int MinAmount { get { return this.minAmount; } set { this.minAmount = value; } }
        public int MaxAmount { get { return this.maxAmount; } set { this.maxAmount = value; } }
        public decimal SellingPrice { get { return this.sellingPrice; } set { this.sellingPrice = value; } }
        public decimal BuyingPRice { get { return this.buyingPrice; } set { this.buyingPrice = value; } }
        public bool IsActive { get { return this.isActive; } set { this.isActive = value; } }

        public Product(string name, int amount, int minAmount, int maxAmount, decimal sellingPrice, decimal buyingPrice)
        {
            this.id = seeder;
            this.name = name;
            this.productId = seeder;
            this.productName = name;
            this.amount = amount;
            this.minAmount = minAmount;
            this.maxAmount = maxAmount;
            this.sellingPrice = sellingPrice;
            this.buyingPrice = buyingPrice;
            this.isActive = true;
            seeder++;
        }
        public string GetInfo()
        { 
            return $"{this.productId} - {this.productName} - Current Amount: {this.amount}";
        }
    }

}

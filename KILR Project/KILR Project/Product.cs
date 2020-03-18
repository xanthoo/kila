using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class Product
    {
        private int productId;
        private string productName;
        private int quanitity;
        private decimal sellingPrice;
        private decimal buyingPrice;
        private bool isActive;

        public int ID { get { return this.productId; } }
        public string Name { get { return this.productName; } set { this.productName = value; } }
        public int Quanitity { get { return this.quanitity; } set { this.quanitity = value; } }
        public decimal SellingPrice { get { return this.sellingPrice; } set { this.sellingPrice = value; } }
        public decimal BuyingPrice { get { return this.buyingPrice; } set { this.buyingPrice = value; } }
        public bool IsActive { get { return this.isActive; } set { this.isActive = value; } }

        public Product(int id, string name, int quanitity, decimal sellingPrice, decimal buyingPrice, bool isActive)
        {
            this.productId = id;
            this.productName = name;
            this.quanitity = quanitity;
            this.sellingPrice = sellingPrice;
            this.buyingPrice = buyingPrice;
            this.isActive = isActive;
        }
        public string GetInfo()
        { 
            return $"Id: {this.productId} - Name: {this.productName} - Current Quantitiy: {this.quanitity}";
        }
    }

}

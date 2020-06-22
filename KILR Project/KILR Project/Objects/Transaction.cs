using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class Transaction
    {
        private int orderId;
        private int productId;
        private decimal productPrice;
        private decimal productBuyingPrice;
        private string createdOn;

        public int OrderID { get { return this.orderId; } private set { this.orderId = value; } }
        public int ProductID { get { return this.productId; } private set { this.productId = value; } }
        public decimal ProductPrice { get { return this.productPrice; } private set { this.productPrice = value; } }
        public decimal ProductBuyingPrice { get { return this.productBuyingPrice; } private set { this.productBuyingPrice = value; } }
        public string CreatedOn { get { return this.createdOn; } private set { this.createdOn = value; } }

        public Transaction(int orderID, int productID, decimal productPrice, decimal productBuyingPrice, string createdOn)
        {
            OrderID = orderID;
            ProductID = productID;
            ProductPrice = productPrice;
            CreatedOn = createdOn;
            ProductBuyingPrice = productBuyingPrice; 
        }
        public string GetInfo()
        {
            return $"Order ID - {this.OrderID}  Product ID - {this.ProductID}  Created On:{this.CreatedOn}";
        }
    }
}

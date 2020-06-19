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
        private int minimumQuantity;
        private string dateCreated;
        private string dateUpdated;
        private string updatedBy;

        public int ID { get { return this.productId; } }
        public string Name { get { return this.productName; } set { this.productName = value; } }
        public int Quanitity { get { return this.quanitity; } set { this.quanitity = value; } }
        public decimal SellingPrice { get { return this.sellingPrice; } set { this.sellingPrice = value; } }
        public decimal BuyingPrice { get { return this.buyingPrice; } set { this.buyingPrice = value; } }
        public bool IsActive { get { return this.isActive; } set { this.isActive = value; } }
        public int MinimumQuantity { get { return this.minimumQuantity; } set { this.minimumQuantity = value; } }
        public string DateCreated { get { return this.dateCreated; } }
        public string DateUpdated { get { return this.dateUpdated; } set { this.dateUpdated = value; } }
        public string UpdatedBy { get { return this.updatedBy; } set { this.updatedBy = value; } }

        public Product(int id, string name, int quanitity, decimal sellingPrice, decimal buyingPrice, bool isActive, int minimumQuantity, string dateCreated, string dateUpdated, string updatedBy)
        {
            this.productId = id;
            this.productName = name;
            this.quanitity = quanitity;
            this.sellingPrice = sellingPrice;
            this.buyingPrice = buyingPrice;
            this.isActive = isActive;
            this.minimumQuantity = minimumQuantity;
            this.dateCreated = dateCreated;
            this.dateUpdated = dateUpdated;
            this.updatedBy = updatedBy;
        }
        public bool RestockRequest()
        {
            if(this.quanitity < this.minimumQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetInfo()
        {
            if (this.IsActive == true)
            {
                return $"Id: {this.productId} - Name: {this.productName} - Current Quantitiy: {this.quanitity}";
            }
            else
            {
                return $"Id: {this.productId} - Name: {this.productName} - Inactive";
            }
        }
        public string GetInfoSmaller()
        {
            return $"ID: {this.productId} - {this.productName} - Price: {this.SellingPrice}€";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KILR_Project
{
    public class Order
    {
        private int id;
        private string orderedOn;
        private string madeBy;
        private decimal total;
        private int amountOfItems;
        private bool isAborted;

        private List<Product> items;
        public int ID { get { return this.id; } set { this.id = value; } }
        public string OrderedOn { get { return this.orderedOn; } private set { this.orderedOn = value; } }
        public string MadeBy { get { return this.madeBy; } private set { this.madeBy = value; } }
        public decimal Total { get { return this.total; } set { this.total = value; } }
        public int AmountOfItems { get { return this.amountOfItems; } set { this.amountOfItems = value; } }
        public bool IsAborted { get { return this.isAborted; } set { this.isAborted = value; } }
        public Order(int id, string orderedOn, string madeBy, decimal total)
        {
            this.id = id;
            this.orderedOn = orderedOn;
            this.madeBy = madeBy;
            this.total = total;
            this.isAborted = false;
            this.items = new List<Product>();
        }
        public Order(int id, string orderedOn, string madeBy, decimal total,int quantity, bool isAborted)
        {
            this.id = id;
            this.orderedOn = orderedOn;
            this.madeBy = madeBy;
            this.total = total;
            this.amountOfItems = quantity;
            this.isAborted = isAborted;
            this.items = new List<Product>();
        }
        public void AddProduct(Product p)
        {
            try
            {
                items.Add(p);
                Total += p.SellingPrice;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Invalid ID!");
            }
        }
        public List<Product> GetAllOrderProducts()
        {
            List<Product> helperList = new List<Product>();
            foreach (Product p in items)
            {
                helperList.Add(p);
            }
            return helperList.ToList();
        }
        public void RemoveProduct(int index)
        {
            Total -= items[index].SellingPrice;
            items.RemoveAt(index);
        }
        public void CompleteOrder()
        {
            Receipt receipt = new Receipt(this);
            receipt.GenerateReceieptinPDF();
        }
        public string GetInfo()
        {
            if (this.isAborted == false)
            {
                return $"ID: {this.ID} - Handled By: {this.madeBy} - Date: {this.orderedOn} - Total: {this.total} - {this.amountOfItems} items purchased";
            }
            else
            {
                return $"ID: {this.ID} - Handled By: {this.madeBy} - Date: {this.orderedOn} - Order Aborted";
            }
        }
    }
}

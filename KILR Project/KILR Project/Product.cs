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
        private int amount;
        private int minAmount;
        private int maxAmount;

        public int ID { get { return this.id; } }
        public string Name { get { return this.name; } }
        public int Amount { get { return this.amount; } }
        public int MinAmount { get { return this.minAmount; } }
        public int MaxAmount { get { return this.maxAmount; } }

        public Product(string name, int amount, int minAmount, int maxAmount)
        {
            this.id = seeder;
            this.name = name;
            this.amount = amount;
            this.minAmount = minAmount;
            this.maxAmount = maxAmount;
            seeder++;
        }
        public string GetInfo()
        {
            return $"{this.id} - {this.name} - Current Amount: {this.amount}";
        }
    }
}

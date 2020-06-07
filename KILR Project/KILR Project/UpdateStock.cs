using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KILR_Project
{
    public partial class UpdateStock : Form
    {
        Main m;
        Product stock;
        StockDetails sd;
        StockManager sm;
        User u;
        public UpdateStock(StockDetails sd, Main m, Product p, StockManager sm, User u)
        {
            InitializeComponent();
            this.m = m;
            this.stock = p;
            this.sd = sd;
            this.sm = sm;
            this.u = u; 
            tbBuyingPrice.Text = p.BuyingPrice.ToString();
            tbName.Text = p.Name;
            tbQuantity.Text = p.Quanitity.ToString();
            tbMinimumQuantity.Text = p.MinimumQuantity.ToString();
            tbSellingPrice.Text = p.SellingPrice.ToString();
            if(p.IsActive == true)
            {
                rbActive.Checked = true;
            }
            else
            {
                rbInactive.Checked = true;
            }

        }

        private void UpdateStock_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text.Trim();
                int quantity = Convert.ToInt32(tbQuantity.Text);
                int minimumQuantity = Convert.ToInt32(tbMinimumQuantity.Text);
                decimal sellingPrice = Convert.ToDecimal(tbSellingPrice.Text);
                decimal buyingPrice = Convert.ToDecimal(tbBuyingPrice.Text);
                decimal roundSelling = Math.Round(sellingPrice, 2, MidpointRounding.ToEven);
                decimal roundBuying = Math.Round(buyingPrice, 2, MidpointRounding.ToEven);
                if (Regex.IsMatch(name, "^[A-Z, a-z, 0-9]{2,30}$"))
                {
                    if (Regex.IsMatch(quantity.ToString(), "^[0-9]{0,7}$"))
                    {
                            if (quantity > 0 && sellingPrice > 0 && buyingPrice > 0 && minimumQuantity > 0)
                            {
                            if (CheckIfProductChanged(name, quantity, minimumQuantity, sellingPrice, buyingPrice) == false)
                            {
                                this.stock.Name = name;
                                this.stock.Quanitity = quantity;
                                this.stock.SellingPrice = roundSelling;
                                this.stock.BuyingPrice = roundBuying;
                                this.stock.MinimumQuantity = minimumQuantity;
                                this.stock.DateUpdated = DateTime.Now.ToString();
                                this.stock.UpdatedBy = u.Username;
                                if (rbActive.Checked == true)
                                {
                                    this.stock.IsActive = true;
                                }
                                else
                                {
                                    this.stock.IsActive = false;
                                }
                                ProductDataAccess.UpdateStock(this.stock);
                                MessageBox.Show("Stock Updated!");
                            }
                            else
                            {
                                MessageBox.Show("No changes have been made!");
                            }
                            }
                            else
                            {
                                MessageBox.Show("Cannot be less than 0!");
                            }
                    }
                    else
                    {
                        MessageBox.Show("Quantity number has not been set correctly!");
                    }
                }
                else
                {
                    MessageBox.Show("Product name must have a length of 3 to 30 characters!");
                }
            }
                catch(FormatException)
            {
                MessageBox.Show("Incorrect format!");
            }
            
        }
        private bool CheckIfProductChanged(string name, int quantity, int minimumQuantity, decimal sellingPrice, decimal buyingPrice)
        {
            if (name == stock.Name && quantity == stock.Quanitity && minimumQuantity == stock.MinimumQuantity && sellingPrice == stock.SellingPrice && buyingPrice == stock.BuyingPrice && rbActive.Checked == stock.IsActive)
                return true;
            else
                return false;
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            sd = new StockDetails(stock, m, sm, u);
            sd.Show();
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

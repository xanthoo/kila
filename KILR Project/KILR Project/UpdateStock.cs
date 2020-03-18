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
        public UpdateStock(StockDetails sd, Main m, Product p, StockManager sm)
        {
            InitializeComponent();
            this.m = m;
            this.stock = p;
            this.sd = sd;
            this.sm = sm;
            tbBuyingPrice.Text = p.BuyingPrice.ToString();
            tbName.Text = p.Name;
            tbQuantity.Text = p.Quanitity.ToString();
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
                string name = tbName.Text;
                int quantity = Convert.ToInt32(tbQuantity.Text);
                decimal sellingPrice = Math.Round(Convert.ToDecimal(tbSellingPrice.Text), 2);
                decimal buyingPrice = Math.Round(Convert.ToDecimal(tbBuyingPrice.Text), 2);
                if (Regex.IsMatch(name, "^[A-Z]{1}[a-z]{2,30}$"))
                {
                    if (Regex.IsMatch(quantity.ToString(), "^[0-9]{0,7}$"))
                    {
                        if (Regex.IsMatch(sellingPrice.ToString(), "^[0-9]{0,9}$") && Regex.IsMatch(buyingPrice.ToString(), "^[0-9]{0,9}$"))
                        {
                            if (quantity >= 0 && sellingPrice >= 0 && buyingPrice >= 0)
                            {
                                this.stock.Name = name;
                                this.stock.Quanitity = quantity;
                                this.stock.SellingPrice = sellingPrice;
                                this.stock.BuyingPrice = buyingPrice;

                                if (rbActive.Checked == true)
                                {
                                    this.stock.IsActive = true;
                                }
                                else
                                {
                                    this.stock.IsActive = false;
                                }
                                sm.UpdateStock(this.stock);
                            }
                            else
                            {
                                MessageBox.Show("Cannot be less than 0!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Price has not been set correctly", "Make sure the information provided is correct", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantity number is too large!");
                    }
                }
                else
                {
                    MessageBox.Show("Product name must start with a capital letter and it must have a length of 3 to 30 characters!");
                }
            }
                catch(FormatException)
            {
                MessageBox.Show("Incorrect format!");
            }
            
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            sd = new StockDetails(stock, m, sm);
            sd.Show();
            this.Close();
        }
    }
}

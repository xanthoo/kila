using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KILR_Project
{
    public partial class StockDetails : Form
    {
        Main m;
        Product stock;
        StockManager sm;
        public StockDetails(Product p, Main m, StockManager sm)
        {
            InitializeComponent();
            this.stock = p;
            this.m = m;
            this.sm = sm;
            buyingLbl.Text = p.BuyingPrice.ToString();
            stockNameLbl.Text = p.Name;
            idlbl.Text = p.ID.ToString();
            pricelbl.Text = p.SellingPrice.ToString();
            quantitylbl.Text = p.Quanitity.ToString();
            if (p.IsActive == true)
            {
                statuslbl.Text = "Active";
            }
            else
            {
                statuslbl.Text = "Inactive";
            }
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {

        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            m.Visible = true;
            this.Close();
        }

        private void BtnUpdStock_Click(object sender, EventArgs e)
        {
            UpdateStock us = new UpdateStock(this, this.m, this.stock, sm);
            us.Show();
            this.Close();
        }
    }
}

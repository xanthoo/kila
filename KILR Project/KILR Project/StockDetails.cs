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
        public StockDetails(Product p, Main m)
        {
            InitializeComponent();
            this.m = m;
            buyingLbl.Text = p.BuyingPrice.ToString();
            stockNameLbl.Text = p.Name;
            idlbl.Text = p.ID.ToString();
            statuslbl.Text = p.IsActive.ToString();
            pricelbl.Text = p.SellingPrice.ToString();
            quantitylbl.Text = p.Quanitity.ToString();
        }

        private void StockDetails_Load(object sender, EventArgs e)
        {

        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            m.Visible = true;
            this.Close();
        }
    }
}

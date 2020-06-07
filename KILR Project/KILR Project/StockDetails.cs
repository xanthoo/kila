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
        User u;
        public StockDetails(Product p, Main m, StockManager sm, User u)
        {
            InitializeComponent();
            this.stock = p;
            this.m = m;
            this.sm = sm;
            this.u = u;
            buyingLbl.Text = p.BuyingPrice.ToString();
            stockNameLbl.Text = p.Name;
            lblMinAmount.Text = p.MinimumQuantity.ToString();
            idlbl.Text = p.ID.ToString();
            pricelbl.Text = p.SellingPrice.ToString();
            quantitylbl.Text = p.Quanitity.ToString();
            lblDateCreated.Text = p.DateCreated.Substring(0,10);
            if (!String.IsNullOrWhiteSpace(p.UpdatedBy))
            {
                lblUpdatedBy.Text = p.UpdatedBy;
            }
            else
            {
                lblUpdatedBy.Text = "This Product has not been updated.";
            }
            if (!String.IsNullOrWhiteSpace(p.DateUpdated))
            {
                lblUpdated.Text = p.DateUpdated;
            }
            else
            {
                lblUpdated.Text = "This Product has not been updated.";
            }
            if (p.IsActive == true)
            {
                statuslbl.Text = "Active";
            }
            else
            {
                statuslbl.Text = "Inactive";
            }
            if (p.RestockRequest() == true)
            {
                lblRestockRequest.Visible = true;
            }
            else
            {
                lblRestockRequest.Visible = false;
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
            UpdateStock us = new UpdateStock(this, this.m, this.stock, sm, u);
            us.Show();
            this.Close();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

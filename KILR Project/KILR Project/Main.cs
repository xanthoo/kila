using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace KILR_Project
{
    public partial class Main : Form
    {


        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        StockManager sm;
        public Main()
        {
            InitializeComponent();
            sm = new StockManager("Kristian");

            PopulateList();
            RefreshStock();
        }
        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateDepartment createDepartmentForm = new CreateDepartment(this);
            createDepartmentForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (lbDepartments.SelectedIndex > -1)
            {
                System.Data.DataRowView selectedItem = lbDepartments.SelectedItem as System.Data.DataRowView;
                var relevantID = (int)selectedItem.Row.ItemArray[0];

                DepartmentInformation departmentInfoForm = new DepartmentInformation(this, relevantID);
                CreateDepartment createDepartmentForm = new CreateDepartment(this);

                departmentInfoForm.Show();

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM department WHERE name LIKE '%" + textBox8.Text + "%'", connection);
                connection.Open();

                adapter.Fill(dt);
                lbDepartments.DataSource = null;
                lbDepartments.DataSource = dt;
                lbDepartments.DisplayMember = "name";
            }
            catch (Exception ex)
            {


            }
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbStockName.Text.Trim();
                int quantity = Convert.ToInt32(tbStockQuantity.Text);
                decimal sellingPrice = Math.Round(Convert.ToDecimal(tbStockPrice.Text), 2);
                decimal buyingPrice = Math.Round(Convert.ToDecimal(tbStockBuying.Text), 2);
                if (Regex.IsMatch(name, "^[A-Z]{1}[a-z]{2,30}$"))
                {
                    if (Regex.IsMatch(quantity.ToString(), "^[0-9]{0,7}$"))
                    {
                        if (Regex.IsMatch(sellingPrice.ToString(), "^[0-9]{0,9}$") && Regex.IsMatch(buyingPrice.ToString(), "^[0-9]{0,9}$"))
                            {
                            if (sm.AddStock(new Product(0, name, quantity, sellingPrice, buyingPrice, true)) == true)
                            {
                                MessageBox.Show("Stock succesfully created!");
                                RefreshStock();
                            }
                            else
                            {
                                MessageBox.Show("Check your connection to the database");
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
            catch (Exception ex)
            {
                MessageBox.Show("Make sure the information provided is corrrect!");
            }
        }

        private void StockPage_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnStockInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbFindStock.Text);
                if (sm.CheckIfStockExists(id) != false)
                {
                    Product stock = sm.FindStock(id);
                    StockDetails sd = new StockDetails(stock, this, sm);
                    this.Visible = false;
                    sd.Show();
                }
                else
                {
                    MessageBox.Show("Make sure you've entered the correct id", "Could not find stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format!");
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbFindStock.Text);
                if (sm.CheckIfStockExists(id) != false)
                {
                    int amount = Convert.ToInt32(tbStockAmount.Text);
                    if (amount > 0)
                    {
                        Product p = sm.FindStock(id);
                        sm.Decrease(p, amount);
                        RefreshStock();
                    }
                    else
                    {
                        MessageBox.Show("Amount cannot be 0 or less");
                    }
                }
                else
                {
                    MessageBox.Show("Make sure you've entered the correct id", "Could not find stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format!");
            }

        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbFindStock.Text);
                if (sm.CheckIfStockExists(id) != false)
                {
                    int amount = Convert.ToInt32(tbStockAmount.Text);
                    if (amount > 0)
                    {
                        Product p = sm.FindStock(id);
                        sm.Increase(p, amount);
                        RefreshStock();
                    }
                    else
                    {
                        MessageBox.Show("Amount cannot be 0 or less");
                    }
                }
                else
                {
                    MessageBox.Show("Make sure you've entered the correct id", "Could not find stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format!");
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
   
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStock();
        }
        public void RefreshStock()
        {
            sm.GetAllStocks();
            lbStock.Items.Clear();
            foreach (Product p in sm.GetAllStocks())
            {
                lbStock.Items.Add(p.GetInfo());
            }
        }

        private void BtnFilterStock_Click(object sender, EventArgs e)
        {
            sm.GetAllStocks();
            lbStock.Items.Clear();
            foreach (Product p in sm.GetAllStocks())
            {
                if (cbActive.Checked == true)
                {
                    if (p.IsActive == true)
                    {
                        lbStock.Items.Add(p.GetInfo());
                    }
                }
                if(cbInactive.Checked == true)
                {
                    if(p.IsActive == false)
                    {
                        lbStock.Items.Add(p.GetInfo());
                    }
                }
            }
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        public void PopulateList()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM department", connection);
                connection.Open();

                adapter.Fill(dt);
                lbDepartments.DataSource = null;
                lbDepartments.DataSource = dt;
                lbDepartments.DisplayMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

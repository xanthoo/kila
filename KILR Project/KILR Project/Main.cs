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

namespace KILR_Project
{
    public partial class Main : Form
    {


        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        StockManager sm;
        User user;
        public Main(object user)
        {
            InitializeComponent();
            this.user = user as User;

            sm = new StockManager("Kristian");

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
                DepartmentInformation departmentInfoForm = new DepartmentInformation(this);
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
                string name = tbStockName.Text;
                int quantity = Convert.ToInt32(tbStockQuantity.Text);
                decimal sellingPrice = Convert.ToDecimal(tbStockPrice.Text);
                decimal buyingPrice = Convert.ToDecimal(tbStockBuying.Text);
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
                    StockDetails sd = new StockDetails(stock, this);
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
        public void RefreshStock()
        {
            sm.GetAllStocks();
            lbStock.Items.Clear();
            foreach (Product p in sm.GetAllStocks())
            {
                lbStock.Items.Add(p.GetInfo());
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
   
        }
    }
}

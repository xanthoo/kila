using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public partial class IncomeStatistics : Form
    {
        IncomeManager im;
        Main main;
        public IncomeStatistics(IncomeManager im, Main main)
        {
            InitializeComponent();
            this.im = im;
            this.main = main;
            lblTotal.Text = im.GetTotalShopRevenue() + "€";
            lblTotalTransactions.Text = im.GetAllTransactions().Count().ToString();

        }

        private void IncomeStatistics_Load(object sender, EventArgs e)
        {

        }

        private void BtnRevenueDay_Click(object sender, EventArgs e)
        {
            foreach (var series in chartRevenue.Series)
            {
                series.Points.Clear();
            }
            panelAllTransactions.Visible = false;
            panelTotalRevenue.Visible = true;
            panelTransactionsDay.Visible = false;
            panelOrders.Visible = false;
            panelHide.Visible = false;
            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = kilrdb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                List<Order> orders = new List<Order>();
                List<Product> products = new List<Product>();
                orders.Clear();
                string sql = "SELECT date(added_on), COUNT(order_id) AS num_orders, SUM(product_price - product_buyingprice) AS daily_total" +
                    " FROM transactions " +
                    "WHERE added_on>=date_sub(current_date, INTERVAL 31 DAY) " +
                    "GROUP BY date(added_on) ";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartRevenue.Series["Revenue"].Points.AddXY(Convert.ToDateTime(reader[0]).ToString("yyyy-MM-dd"), Convert.ToDecimal(reader[2]).ToString());
               }
            }
            catch (Exception)
            {
                throw new Exception("Check your connection to the database!");
            }
            finally
            {
                connection.Close();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnAllTransactions_Click(object sender, EventArgs e)
        {
            lbTransactions.Items.Clear();
            foreach (Transaction t in im.GetAllTransactions())
            {
                lbTransactions.Items.Add(t.GetInfo());
            }
            panelAllTransactions.Visible = true;
            panelTotalRevenue.Visible = false;
            panelTransactionsDay.Visible = false;
            panelOrders.Visible = false;
            panelHide.Visible = false;
        }
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            lbTransactions.Items.Clear();
            string date = datePicker.Value.ToString("yyyy-MM-dd");
            foreach(Transaction t in im.GetAllTransactions())
            {
                if (date == Convert.ToDateTime(t.CreatedOn).ToString("yyyy-MM-dd")) 
                {
                    lbTransactions.Items.Add(t.GetInfo());
                }
            }
        }

        private void BtnTransactionsDaily_Click(object sender, EventArgs e)
        {
            foreach (var series in chartTransactions.Series)
            {
                series.Points.Clear();
            }
            panelAllTransactions.Visible = false;
            panelTotalRevenue.Visible = false;
            panelTransactionsDay.Visible = true;
            panelOrders.Visible = false;
            panelHide.Visible = false;
            string connectionString = "datasource = 127.0.0.1; port = 3306; username = root; password =; database = kilrdb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                List<Order> orders = new List<Order>();
                List<Product> products = new List<Product>();
                orders.Clear();
                string sql = "SELECT date(added_on), COUNT(order_id) AS num_orders, SUM(product_price - product_buyingprice) AS daily_total" +
                    " FROM transactions " +
                    "WHERE added_on>=date_sub(current_date, INTERVAL 31 DAY) " +
                    "GROUP BY date(added_on) ";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chartTransactions.Series["Amount"].Points.AddXY(Convert.ToDateTime(reader[0]).ToString("yyyy-MM-dd"), reader[1].ToString());
                }
            }
            catch (Exception)
            {
                throw new Exception("Check your connection to the database!");
            }
            finally
            {
                connection.Close();
            }

        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.main.Visible = true;
        }

        private void DateOrders_ValueChanged(object sender, EventArgs e)
        {
            lbOrders.Items.Clear();
            string date = dateOrders.Value.ToString("yyyy-MM-dd");
            foreach (Order o in im.Manager.GetAllOrders())
            {
                if (date == Convert.ToDateTime(o.OrderedOn).ToString("yyyy-MM-dd"))
                {
                    lbOrders.Items.Add(o.GetInfo());
                }
            }
        }

        private void BtnAllOrders_Click(object sender, EventArgs e)
        {
            lbOrders.Items.Clear();
            foreach (Order o in im.Manager.GetAllOrders())
            {
                lbOrders.Items.Add(o.GetInfo());
            }
            panelAllTransactions.Visible = false;
            panelTotalRevenue.Visible = false;
            panelTransactionsDay.Visible = false;
            panelOrders.Visible = true;
            panelHide.Visible = false;
        }
    }
}

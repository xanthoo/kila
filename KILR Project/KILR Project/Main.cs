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
        User user;
        EmployeeManager empMang;
        DepartmentManager dm;
        public Main(object user)
        {
            InitializeComponent();
            this.user = user as User;

            sm = new StockManager("Product Manager");
            empMang = new EmployeeManager();
            dm = new DepartmentManager("Jupiter Managers");

            PopulateDepartmentsList();
            PopulateEmployeesList();
            RefreshStock();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string HireDate = DateTime.Today.ToString("yyyy-MM-dd");
            Department dep = dm.GetDepartmentByName(cbDep.SelectedItem.ToString());
            empMang.AddEmployee(tbFName.Text, tbSurname.Text, dep, (Position)cbPostition.SelectedIndex, tbEmail.Text, tbAddress.Text, (Shift)cbShift.SelectedIndex, HireDate, Convert.ToDouble(tbHWage.Text));
            PopulateEmployeesList();
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format!");
                return;
            }
        }

        public void PopulateDepartmentsList()
        {
            List<Department> departments = dm.GetDepartments();
            lbDepartments.Items.Clear();
            cbDep.Items.Clear();
            foreach (Department d in departments)
            {
                lbDepartments.Items.Add(d.GetInfo());
                cbDep.Items.Add(d.Name);
            }
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
            Department department = null;
            try
            {
                department = dm.GetDepartment(Convert.ToInt32(textBoxDepartmentId.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format!");
                return;
            }
            if (department == null)
            {
                MessageBox.Show("Department not found.");
            }
            else
            {
                DepartmentInformation departmentInfoForm = new DepartmentInformation(this, Convert.ToInt32(textBoxDepartmentId.Text), this.dm);
                CreateDepartment createDepartmentForm = new CreateDepartment(this);

                departmentInfoForm.Show();

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            List<Department> departments = dm.GetDepartments(textBox8.Text);
            lbDepartments.Items.Clear();
            foreach (Department d in departments)
            {
                lbDepartments.Items.Add(d.GetInfo());
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

            if (cbActive.Checked == false && cbInactive.Checked == false)
            {
                foreach (Product p in sm.GetAllStocks())
                {
                    lbStock.Items.Add(p.GetInfo());
                }
                return;
            }

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
        public void PopulateEmployeesList()
        {
            lbEmployees.Items.Clear();
            if (cbEmployees.Checked == false && cbAdministrators.Checked == false && cbManagers.Checked == false)
            {
                foreach (Employee e in empMang.GetAllEmployees())
                {
                    lbEmployees.Items.Add(e.GetInfo());
                }
                return;
            }

            foreach (Employee e in empMang.GetAllEmployees())
            {
                if (cbEmployees.Checked == true)
                {
                    if (e.GetEmployeePosition() == Position.EMPLOYEE)
                    {
                        lbEmployees.Items.Add(e.GetInfo());
                    }
                }
                if (cbAdministrators.Checked == true)
                {
                    if (e.GetEmployeePosition() == Position.ADMINISTRATOR)
                    {
                        lbEmployees.Items.Add(e.GetInfo());
                    }
                }
                if (cbManagers.Checked == true)
                {
                    if (e.GetEmployeePosition() == Position.MANAGER)
                    {
                        lbEmployees.Items.Add(e.GetInfo());
                    }
                }
            }
        }

        private void btnEmpInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection Cn = new MySqlConnection(connectionString);
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"select id from employee where id= {tbFindEmployee.Text}";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            int id = -1;
            while (Rdr.Read())
            {
                id = Convert.ToInt32(Rdr["id"]);
            }
            if (id > 0)
            {
                EmployeeInformation empInfo = new EmployeeInformation(id);
                empInfo.Visible = true;
            }
            else
            {
                MessageBox.Show("No user with that ID!");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                PopulateEmployeesList();
                PopulateDepartmentsList();
                RefreshStock();
            }
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeesPage_Click(object sender, EventArgs e)
        {

        }

        private void cbDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            PopulateEmployeesList();
        }
    }
}

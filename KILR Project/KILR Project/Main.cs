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
        Employee employee;
        EmployeeManager empMang;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";

        public Main()
        {
            InitializeComponent();

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM employee", connection);
                connection.Open();

                adapter.Fill(dt);
                lbEmployees.DataSource = null;
                lbEmployees.DataSource = dt;
                lbEmployees.DisplayMember = "name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            empMang = new EmployeeManager();
            string HireDate = DateTime.Today.ToString("yyyy-MM-dd"); 
            employee = new Employee(tbFName.Text, tbSurname.Text, cbDep.SelectedIndex, (Position)cbPostition.SelectedIndex, tbEmail.Text, tbAddress.Text, (Shift)cbShift.SelectedIndex, Convert.ToDateTime(HireDate), Convert.ToDouble(tbHWage.Text));
            empMang.AddEmpployee(employee);
            string query = "INSERT INTO employee(`id`, `firstname`, `lastname`, `email`, `address`,`department`, `position`, `shift`, `hiredate`, `hourlywage`) VALUES (NULL, '" + tbFName.Text + "', '" + tbSurname.Text + "', '" + tbEmail.Text + "', '" + tbAddress.Text + "', '" + cbDep.SelectedItem + "', '" + cbPostition.SelectedItem + "', '" + cbShift.SelectedItem + "', '" + HireDate + "', '" + tbHWage.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader MyReader;
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MyReader = commandDatabase.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            if (lbDepartments.SelectedIndex > -1)
            {
                DepartmentInformation departmentInfoForm = new DepartmentInformation(this);
                CreateDepartment createDepartmentForm = new CreateDepartment(this);

                departmentInfoForm.Show();

            }
        }

        private void BtnEmpInfo_Click(object sender, EventArgs e)
        {
            MySqlConnection Cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;");
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
                MessageBox.Show("USER FOUND!");
                EmployeeInformation empInfo = new EmployeeInformation(id);
                empInfo.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("No user with that ID!");
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string radioButton = "Employee";
            if(rbAdmin.Checked)
            {
                radioButton = "Administrator";
            }
            if(rbManagers.Checked)
            {
                radioButton = "Manager";
            }
            lbEmployees.Items.Clear();
            MySqlConnection Cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;");
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"select * from employee where position= '{radioButton}'";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            while (Rdr.Read())
            {
                lbEmployees.Items.Add("ID: " + Rdr["id"].ToString() + " Name: " + Rdr["firstname"].ToString() + " " + Rdr["lastname"].ToString() + " Department: " + Rdr["department"].ToString());
            }
        }
    }
}

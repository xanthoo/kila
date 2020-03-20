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
    public partial class EditDepartment : Form
    {
        DepartmentManager dm;
        DepartmentInformation depInfo;
        Main mainDepartmentInfo;
        int departmentId;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";

        public EditDepartment(Main mainForm,DepartmentInformation infoForm, int DepartmentID)
        {
            InitializeComponent();
            dm = new DepartmentManager("Jupiter Managers");
            depInfo = infoForm;
            departmentId = DepartmentID;
            mainDepartmentInfo = mainForm;
            RefreshList();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
            string query = "UPDATE `department` SET `name`='" + tbDepartmentName.Text + "',`staffamount`='" + tbMaxPeople.Text + "',`managerid`='" + tbMinPeople.Text + "' WHERE id =" + departmentId;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                if (!string.IsNullOrWhiteSpace(tbDepartmentName.Text) && !string.IsNullOrWhiteSpace(tbMaxPeople.Text) && !string.IsNullOrWhiteSpace(tbMinPeople.Text))
                {
                    int parsedValue;
                    if (!int.TryParse(tbMaxPeople.Text, out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");
                        return;
                    }
                    if (!int.TryParse(tbMinPeople.Text, out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");
                        return;
                    }
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Department succesfully edited");
                    mainDepartmentInfo.PopulateDepartmentsList();
                    databaseConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {

        }
        private void RefreshList()
        {
            lbDepartmentEmployees.Items.Clear();
            Department d = dm.GetDepartment(departmentId);
            foreach (Employee e in d.GetEmployees())
            {
                lbDepartmentEmployees.Items.Add(e.GetInfo());
            }


            lbOtherEmployees.Items.Clear();
            Department d2 = dm.GetDepartment(departmentId);
            foreach (Employee e in d2.GetOtherEmployees())
            {
                lbOtherEmployees.Items.Add(e.GetInfo());
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            int foundId = -1;
            Department d2 = dm.GetDepartment(departmentId);
            try
            {
                foreach (Employee employee in d2.GetOtherEmployees())
                {
                    if (employee.GetId() == Convert.ToInt32(tbFindEmployee.Text))
                    {
                        foundId = employee.GetId();
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format!");
                return;
            }

            if (foundId != -1)
            {
                string query = $"UPDATE employee SET department = {departmentId} WHERE id = {foundId}";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader MyReader;
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MyReader = commandDatabase.ExecuteReader();
                    RefreshList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Employee was not found!");
            }
        }

        private void btnRmvEmp_Click(object sender, EventArgs e)
        {
            int foundId = -1;
            Department d2 = dm.GetDepartment(departmentId);
            foreach (Employee employee in d2.GetEmployees())
            {
                if (employee.GetId() == Convert.ToInt32(tbFindEmployee.Text))
                {
                    foundId = employee.GetId();
                    break;
                }
            }

            if (foundId != -1)
            {
                string query = $"UPDATE employee SET department = -1 WHERE id = {foundId}";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader MyReader;
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MyReader = commandDatabase.ExecuteReader();
                    RefreshList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Employee was not found!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //private Department FoundDepartment()
        //{
        //    Department d = dm.GetDepartment(departmentId);
        //    return d;

        //}
        //private void RefreshList()
        //{
        //    lbDepartmentEmployees.Items.Clear();
        //    foreach (Employee e in FoundDepartment().GetEmployees())
        //    {
        //        lbDepartmentEmployees.Items.Add(e.GetInfo());
        //    }
        //}
    }
}

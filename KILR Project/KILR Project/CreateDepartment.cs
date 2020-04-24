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
    public partial class CreateDepartment : Form
    {
        Main mainDepartmentInfo;
        public CreateDepartment(Main mainForm)
        {
            InitializeComponent();
            mainDepartmentInfo = mainForm;
            FillCombo();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
            string query = "INSERT INTO department(`id`, `name`, `staffamount`, `managerid`,`date`) VALUES (NULL, '" + tbDepartmentName.Text + "', '" + tbStaffNumber.Text + "', '" + cmbManagerId.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                if (!string.IsNullOrWhiteSpace(tbDepartmentName.Text) && !string.IsNullOrWhiteSpace(cmbManagerId.Text) && !string.IsNullOrWhiteSpace(tbStaffNumber.Text))
                {
                    int parsedValue;
                    if (!int.TryParse(cmbManagerId.Text, out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");
                        return;
                    }
                    if (!int.TryParse(tbStaffNumber.Text, out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");
                        return;
                    }
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Department succesfully created");
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
        public void FillCombo()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
            string query = "SELECT * FROM EMPLOYEE WHERE position = 'manager'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            while (myReader.Read())
            {
                string sname = myReader.GetString("id");
                cmbManagerId.Items.Add(sname);
            }
        }

        private void CreateDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}

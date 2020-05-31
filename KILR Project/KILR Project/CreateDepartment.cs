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
        string connectionString;
        public CreateDepartment(Main mainForm)
        {
            InitializeComponent();
            mainDepartmentInfo = mainForm;
            FillCombo();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConnectionString();
            DB.ConfirmCreatedDepartment(tbDepartmentName.Text, tbStaffNumber.Text, Convert.ToInt32(cmbManagerId.Text));
            mainDepartmentInfo.PopulateDepartmentsList();
            cmbManagerId.Items.Remove(cmbManagerId.SelectedItem);
        }
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FillCombo()
        {
            ConnectionString();
            string query = "SELECT * FROM `Employee` Where department = 0 AND position = 'manager'";
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
        private void ConnectionString()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        }
    }
}

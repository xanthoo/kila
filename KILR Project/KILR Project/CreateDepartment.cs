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
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
          //  string query = "INSERT INTO department(`id`, `name`, `staffamount`, `managerid`) VALUES (NULL, '" + tbDepartmentName.Text + "', '" + tbMaxPeople.Text + "', '" + tbMinPeople.Text + "')";
            string query = "INSERT INTO department(`id`, `name`, `staffamount`, `managerid`,`date`) VALUES (NULL, '" + tbDepartmentName.Text + "', '" + tbMaxPeople.Text + "', '" + tbMinPeople.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Department succesfully created");
                mainDepartmentInfo.PopulateList();
                databaseConnection.Close();
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
    }
}

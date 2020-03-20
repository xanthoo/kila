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
        DepartmentInformation depInfo;
        Main mainDepartmentInfo;
        int departmentId;

        public EditDepartment(Main mainForm,DepartmentInformation infoForm, int DepartmentID)
        {
            InitializeComponent();
            depInfo = infoForm;
            departmentId = DepartmentID;
            mainDepartmentInfo = mainForm;
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
                    mainDepartmentInfo.PopulateList();
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
    }
}

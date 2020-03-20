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
    public partial class DepartmentInformation : Form
    {
        Main mainDepartmentInfo;
        CreateDepartment createDepartmentForm;
        DepartmentInformation depInfo;

        int departmentId;
        string connectionString;
        public DepartmentInformation(Main mainForm, int DepartmentID)
        {
            InitializeComponent();
            departmentId = DepartmentID;
            mainDepartmentInfo = mainForm;

            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM department where id ="+departmentId, connection);
            connection.Open();

            adapter.Fill(dt);

            int id= (int)dt.Rows[0].ItemArray[0];
            string name = (string)dt.Rows[0].ItemArray[1];
            int staffamount= (int)dt.Rows[0].ItemArray[2];
            int managerid = (int)dt.Rows[0].ItemArray[3];
            DateTime date = (DateTime)dt.Rows[0].ItemArray[4];

            lblDepartmentName.Text = name;
            label6.Text = date.ToString();
            label4.Text = staffamount.ToString();
            label1.Text = id.ToString();
            label8.Text = managerid.ToString();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand("DELETE from department where id=" + departmentId, connection);
            commandDatabase.CommandTimeout = 60;
            connection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            mainDepartmentInfo.PopulateList();

            MessageBox.Show("The department has been deleted!");
            this.Close();

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditDep_Click(object sender, EventArgs e)
        {
 
            EditDepartment editDepartmentForm = new EditDepartment(this.mainDepartmentInfo,depInfo, departmentId);
            editDepartmentForm.Show();
            this.Close();
        }

        private void DepartmentInformation_Load(object sender, EventArgs e)
        {

        }
    }
}

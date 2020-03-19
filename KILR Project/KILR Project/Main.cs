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
       

        public Main()
        {
            InitializeComponent();
            PopulateList();     

        }

        public void PopulateList() {
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
                System.Data.DataRowView selectedItem = lbDepartments.SelectedItem as System.Data.DataRowView;
                var relevantID = (int)selectedItem.Row.ItemArray[0];
                
                DepartmentInformation departmentInfoForm = new DepartmentInformation(this, relevantID);
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM department WHERE name LIKE '%"+textBox8.Text+"%'", connection);
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public partial class EmployeeInformation : Form
    {
        Main m;
        Employee newEmp;
        EmployeeManager employeeManager;
        public int newId;
        public EmployeeInformation(int id)
        {
            InitializeComponent();
            newId = id;
            MySqlConnection Cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;");
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"select * from employee where id= {id}";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            while (Rdr.Read())
            {
                lblAddress.Text = Rdr["address"].ToString();
                lblFName.Text = Rdr["firstname"].ToString();
                lblLName.Text = Rdr["lastname"].ToString();
                lblReleaseDate.Text = Rdr["firedate"].ToString();
                lblHireDate.Text = Rdr["hiredate"].ToString();
                lblEmail.Text = Rdr["email"].ToString();
                if (Rdr["department"].ToString() == "-1")
                {
                    lblDepts.Text = "No Department";
                }
                else
                {
                    lblDepts.Text = Rdr["department"].ToString();
                }
            }

            employeeManager = new EmployeeManager();
        }

        private void Jupiterlbl_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeInformation_Load(object sender, EventArgs e)
        {

        }


        private void BtnRmv_Click(object sender, EventArgs e)
        {
            string ReleaseDate = DateTime.Today.ToString("yyyy-MM-dd");
            employeeManager.RemoveEmployee(newId, ReleaseDate);
            MessageBox.Show("Employee has been released");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void BtnRmv_Click_1(object sender, EventArgs e)
        {
            string ReleaseDate = DateTime.Today.ToString("yyyy-MM-dd");
            employeeManager.RemoveEmployee(newId, ReleaseDate);
            MessageBox.Show("Employee has been released");
        }

        private void BtnShift_Click(object sender, EventArgs e)
        {
            AssignShift shift = new AssignShift(newId);
            shift.Show();
            this.Close();
        }

        private void BtnUpdtDetails_Click_1(object sender, EventArgs e)
        {
            UpdateEmployee update = new UpdateEmployee(newId);
            update.Show();
            this.Close();
        }

        private void BtnGoBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

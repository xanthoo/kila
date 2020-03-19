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
    public partial class EmployeeInformation : Form
    {
        Main m;
        Employee newEmp;
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
                lblShift.Text = Rdr["shift"].ToString();
                lblHireDate.Text = ((DateTime)Rdr["hiredate"]).ToString();
                lblEmail.Text = Rdr["email"].ToString();
                //lblHireDate.Text = Rdr["firedate"].ToString();
                lblDepts.Text = Rdr["department"].ToString();
            }
        }

        private void Jupiterlbl_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeInformation_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdtDetails_Click(object sender, EventArgs e)
        {
            UpdateEmployee update = new UpdateEmployee(newId);
            update.Show();
            this.Close();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            m = new Main();
            m.Visible = true;
            this.Close();
        }

        private void BtnRmv_Click(object sender, EventArgs e)
        {
            MySqlConnection Cn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;");
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"DELETE from employee where id= {newId}";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public partial class UpdateEmployee : Form
    {
        EmployeeManager em;
        public int newId;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public UpdateEmployee(int id)
        {
            InitializeComponent();
            em = new EmployeeManager();
            newId = id;
            MySqlConnection Cn = new MySqlConnection(connectionString);
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"select * from employee where id= {id}";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            while (Rdr.Read())
            {
                tbFName.Text = Rdr["firstname"].ToString();
                tbSurname.Text = Rdr["lastname"].ToString();
                tbEmail.Text = Rdr["email"].ToString();
                tbAddress.Text = Rdr["address"].ToString();
                tbJobPos.Text = Rdr["position"].ToString();
                tbDep.Text = Rdr["department"].ToString();
                tbCity.Text = Rdr["city"].ToString();
                tbWage.Text = Rdr["hourlywage"].ToString();
                tbZipCode.Text = Rdr["zipcode"].ToString();
            }
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            EmployeeInformation newForm = new EmployeeInformation(newId);
            newForm.Visible = true;
            this.Close();
        }

        private void BtnUpdtDts_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(tbEmail.Text);
            if (match.Success)
            {
                em.UpdateEmployee(tbFName.Text, tbSurname.Text, tbEmail.Text, tbAddress.Text, tbJobPos.Text, tbDep.Text, newId, tbCity.Text, tbZipCode.Text, Convert.ToDouble(tbWage.Text));
            }
            else
            {
                MessageBox.Show("Please provide a correct email!");
            }
        }
    }
}

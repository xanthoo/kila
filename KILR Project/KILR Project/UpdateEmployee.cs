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
    public partial class UpdateEmployee : Form
    {
       
        public int newId;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public UpdateEmployee(int id)
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
                tbFName.Text = Rdr["firstname"].ToString();
                tbSurname.Text = Rdr["lastname"].ToString();
                tbEmail.Text = Rdr["email"].ToString();
                tbAddress.Text = Rdr["address"].ToString();
                tbJobPos.Text = Rdr["position"].ToString();
                tbDep.Text = Rdr["department"].ToString();
            }
            //try
            //{
            //    MySqlConnection connection = new MySqlConnection(connectionString);
            //    DataTable dt = new DataTable();
            //    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM employee", connection);
            //    connection.Open();

                //    adapter.Fill(dt);
                //    //lbDepartmentEmployees.DataSource = null;
                //    //lbDepartmentEmployees.DataSource = dt;
                //    //lbDepartmentEmployees.DisplayMember = "name";
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            EmployeeInformation newForm = new EmployeeInformation(newId);
            newForm.Visible = true;
            this.Close();
        }

        private void BtnUpdtDts_Click(object sender, EventArgs e)
        {
            string query = $"UPDATE employee SET firstname = '{tbFName.Text}', lastname = '{tbSurname.Text}', email = '{tbEmail.Text}', address = '{tbAddress.Text}', department = '{tbDep.Text}' WHERE id = {newId}";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader MyReader;
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MyReader = commandDatabase.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

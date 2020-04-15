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
    public partial class AssignShifts : Form
    {
        public int newId;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public AssignShifts(int id)
        {
            InitializeComponent();
            newId = id;
            MySqlConnection Cn = new MySqlConnection(connectionString);
            MySqlCommand Cmd = Cn.CreateCommand();
            Cn.Open();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AssignShifts_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string date = dtpShift.Value.ToString("yyyy-MM-dd");
            //string query = $"INSERT INTO workshift(`shift`, `date`, `empId`) SELECT (`shift`, `date`, `empId`) FROM DUAL WHERE NOT EXISTS(SELECT * FROM workshift WHERE shift = {(Shift)cbShift.SelectedIndex} AND date = {date} AND empId = {newId} LIMIT 1)";
            string query = $"INSERT into workshift(`id`, `shift`, `date`, `empId`) VALUES (NULL, '" + (Shift)cbShift.SelectedIndex + "', '" + date + "', '" + newId + "')";
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

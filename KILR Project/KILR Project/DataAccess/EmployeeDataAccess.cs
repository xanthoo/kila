
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public static class DB
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";

        public static List<string> GetShifts(int id)
        {
            List<string> shifts = new List<string>();
            MySqlConnection Cn = new MySqlConnection(connectionString);
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"select * from workshift where empId= {id}";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            while (Rdr.Read())
            {

                shifts.Add("Shift: " + Rdr["shift"].ToString() + " Date: " + Rdr["date"].ToString());
            }
            return shifts;
        }
        public static void AddDayShift(Shift shift, string date, int id)
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MySqlCommand commandDatabase;
            string query = $"INSERT into workshift(`id`, `shift`, `date`, `empId`) VALUES (NULL, '" + shift + "', '" + date + "', '" + id + "')";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();
        }
        public static List<string> GetEmployeesByName(string name)
        {
            List<string> employees = new List<string>();
            MySqlConnection Cn = new MySqlConnection(connectionString);
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"select * from employee where firstname= '{name}' OR lastname='{name}'";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            while (Rdr.Read())
            {
                employees.Add("ID: " + Rdr["id"].ToString() + " Name: " + Rdr["firstname"].ToString() + " " + Rdr["lastname"].ToString() + " DepId: " + Rdr["department"].ToString() + " Pos: " + Rdr["position"].ToString());
            }
            return employees;
        }
        public static bool GetEmployeeById(int id)
        {
            MySqlConnection Cn = new MySqlConnection(connectionString);
            MySqlCommand Cmd = Cn.CreateCommand();
            Cmd.CommandText = $"select id from employee where id= {id}";
            Cn.Open();
            MySqlDataReader Rdr = Cmd.ExecuteReader();
            int newId = -1;
            while (Rdr.Read())
            {
                newId = Convert.ToInt32(Rdr["id"]);
            }
            if (newId > 0)
            {
                return true;
            }
            return false;
        }
        public static bool UpdateEmployee(string firstName, string surname, string email, string address, string jobPosition, string department, int id)
        {
            string query = $"UPDATE employee SET firstname = '{firstName}', lastname = '{surname}', email = '{email}', address = '{address}', position = '{jobPosition}', department = '{department}' WHERE id = {id}";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader MyReader;
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MyReader = commandDatabase.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
      
    }
    
}

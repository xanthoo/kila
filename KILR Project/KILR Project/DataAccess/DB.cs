
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
        public static bool UpdateEmployee(string firstName, string surname, string email, string address, string jobPosition, string department, int id, string city, string zip, double wage)
        {
            string query = $"UPDATE employee SET firstname = '{firstName}', lastname = '{surname}', email = '{email}', address = '{address}', position = '{jobPosition}', department = '{department}', city = '{city}', zipcode = '{zip}', hourlywage = '{wage}' WHERE id = {id}";
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
        public static void AddEmployee(string fName, string lastName, Department d, Position position, string email, string address, String HireDate, double hourlyWage, string password, string city, string gender, string zipcode)
        {
            string query;
            if (position == Position.ADMINISTRATOR || position == Position.MANAGER)
            {
                query = "INSERT INTO employee(`firstname`, `lastname`, `email`, `address`,`department`, `position`, `hiredate`, `hourlywage`, `password`, `city`, `gender`, `zipcode`)" +
                $" VALUES ('{fName}', '{lastName}', '{email}', '{address}', {0}, '{position.ToString()}', '{HireDate}', {hourlyWage}, '{password}', '{city}', '{gender}', '{zipcode}');";
            }
            else
            {
                query = "INSERT INTO employee(`firstname`, `lastname`, `email`, `address`,`department`, `position`, `hiredate`, `hourlywage`, `password`, `city`, `gender`, `zipcode`)" +
                $" VALUES ('{fName}', '{lastName}', '{email}', '{address}', {d.Id}, '{position.ToString()}', '{HireDate}', {hourlyWage}, '{password}', '{city}', '{gender}', '{zipcode}');";
            }
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
        public static bool RemoveEmployee(int id, string ReleaseDate)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"UPDATE `employee` SET `firedate` =  '" + ReleaseDate + "'  WHERE id = " + id + "";
                connection.Open();
                MySqlDataReader Rdr = cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
    
}

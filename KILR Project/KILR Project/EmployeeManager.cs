using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace KILR_Project
{
    class EmployeeManager
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public List<Employee> GetAllEmployees(bool fired = false)
        {
            /*try
            {*/
            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter;
            if (fired)
            {
                adapter = new MySqlDataAdapter("SELECT * FROM employee", connection);
            }
            else
            {
                adapter = new MySqlDataAdapter("SELECT * FROM employee WHERE firedate IS NULL", connection);
            }
            connection.Open();

            adapter.Fill(dt);

            List<Employee> employees = new List<Employee>();
            foreach (DataRow row in dt.Rows)
            {

                Position position = Position.EMPLOYEE;
                switch (row["position"].ToString())
                {
                    case "EMPLOYEE":
                        position = Position.EMPLOYEE;
                        break;
                    case "MANAGER":
                        position = Position.MANAGER;
                        break;
                    case "ADMINISTRATOR":
                        position = Position.ADMINISTRATOR;
                        break;
                }

              

                employees.Add(
                    new Employee(
                        (int)row["id"],
                        row["firstname"].ToString(),
                        row["lastname"].ToString(),
                        (int)row["department"],
                        position,
                        row["email"].ToString(),
                        row["address"].ToString(),
                        row["hiredate"].ToString(),
                        Convert.ToDouble(row["hourlywage"].ToString())
                    )
                );
            }

            return employees;
            /*}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }*/
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in GetAllEmployees())
            {
                if (employee.Id == id)
                {
                    return employee;
                }
            }
            return null;
        }
        public void AddEmployee(string fName, string lastName, Department d, Position position, string email, string address, String HireDate, double hourlyWage, string password, string city, string gender, string zipcode)
        {
            string query;
            if(position == Position.ADMINISTRATOR || position == Position.MANAGER)
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
        public bool RemoveEmployee(int id, string ReleaseDate)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"UPDATE `employee` SET firedate = " + ReleaseDate + " WHERE id = " + id + "";
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
        public bool CheckIfEmployeeExists(int id)
        {
            foreach (Employee employee in GetAllEmployees())
            {
                if (employee.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Employee> GetAssoicatedEmployees(Department d)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee e in d.GetEmployees())
            {
                employees.Add(e);
            }
            return employees;
        }


    }
}

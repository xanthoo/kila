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
        private List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
        }
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
        public Employee GetEmployee(int id) // not used
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
            Employee e = new Employee(1, fName, lastName, d.Id, position, email, address, HireDate, hourlyWage);
            employees.Add(e);
            DB.AddEmployee(fName, lastName, d, position, email, address, HireDate, hourlyWage, password, city, gender, zipcode);
        }
        public bool RemoveEmployee(int id, string ReleaseDate)
        {
            foreach (Employee employee in GetAllEmployees())
            {
                if (employee.Id == id)
                {
                    DB.RemoveEmployee(id, ReleaseDate);
                    return true;
                }
            }
            return false;
            
        }
        public bool CheckIfEmployeeExists(int id) // not used!!!
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
        public List<Employee> GetAssoicatedEmployees(Department d) // not used!!!
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee e in d.GetEmployees())
            {
                employees.Add(e);
            }
            return employees;
        }
        public void UpdateEmployee(string firstName, string surname, string email, string address, string jobPosition, string department, int id, string city, string zip, double wage)
        {
            DB.UpdateEmployee(firstName, surname, email, address, jobPosition, department, id, city, zip, wage);
        }
    }
}

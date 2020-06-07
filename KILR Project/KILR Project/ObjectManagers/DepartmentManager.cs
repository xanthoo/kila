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
    public class DepartmentManager
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        private string name;
        public DepartmentManager(string name)
        {
            this.name = name;
        }
        public bool AddDepartment(Department d)
        {
            string query = "INSERT INTO department(`id`, `name`, `staffamount`,`managerid`,`date`) VALUES(NULL, '" + d.Name + "', '" + d.MaxStaff + "', '" + d.ManagerID + "', '" + d.CreatedDate + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        public Department GetDepartment(int id)
        {
            foreach(Department d in GetDepartments())
            {
                if(d.Id == id)
                {
                    return d;
                }
            }
            return null;
        }
        public Department GetDepartmentByName(string name)
        {
            foreach(Department d in GetDepartments())
            {
                if(name == d.Name)
                {
                    return d;
                }
            }
            return null;
        }
        public List<Department> GetDepartments(string filterName = "")
        {
            List<Department> departments = new List<Department>();
            departments.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = "SELECT * FROM department WHERE name LIKE '%" + filterName + "%';";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                departments.Add(new Department(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), Convert.ToInt32(reader[3]), reader[4].ToString()));
            }
            connection.Close();
            return departments;
        }
    }
}

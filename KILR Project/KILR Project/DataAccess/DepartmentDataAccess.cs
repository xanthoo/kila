using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public class DepartmentDataAccess
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public static bool UpdateDepartment(string depName, string staffAmount, int id)
        {
            string query = "UPDATE `department` SET `name`='" + depName + "',`staffamount`='" + staffAmount + "',`managerid`='"  + "' WHERE id =" + id;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                if (!string.IsNullOrWhiteSpace(depName) && !string.IsNullOrWhiteSpace(staffAmount))
                {
                    int parsedValue;
                    if (!int.TryParse(staffAmount, out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");

                    }
                    if (!int.TryParse(staffAmount, out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");

                    }
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Department succesfully edited");

                    databaseConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public static bool RemoveEmployeeFromDepartment(int departmentId, string findEmployees)
        {
            DepartmentManager dm;
            dm = new DepartmentManager("Jupiter Managers");
            int foundId = -1;
            Department d2 = dm.GetDepartment(departmentId);
            foreach (Employee employee in d2.GetEmployees())
            {
                if (employee.GetId() == Convert.ToInt32(findEmployees))
                {
                    foundId = employee.GetId();
                    break;
                }
            }

            if (foundId != -1)
            {
                string query = $"UPDATE employee SET department = -1 WHERE id = {foundId}";
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
            else
            {
                MessageBox.Show("Employee was not found!");
            }
            return false;
        }
        public static bool AddEmployeeFromDepartment(int departmentId, string findEmployees)
        {
            DepartmentManager dm;
            dm = new DepartmentManager("Jupiter Managers");
            int foundId = -1;
            Department d2 = dm.GetDepartment(departmentId);
            try
            {
                foreach (Employee employee in d2.GetOtherEmployees())
                {
                    if (employee.GetId() == Convert.ToInt32(findEmployees))
                    {
                        foundId = employee.GetId();
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect format!");

            }

            if (foundId != -1)
            {
                string query = $"UPDATE employee SET department = {departmentId} WHERE id = {foundId}";
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
            else
            {
                MessageBox.Show("Employee was not found!");
            }
            return false;
        }
        public static bool RemoveDepartment(int departmentId)
        {

            DialogResult answer = MessageBox.Show("Are you sure you want to delete this department?", "Delete department", MessageBoxButtons.YesNo);
            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM employee WHERE department=" + departmentId, connection);
            adapter.Fill(dt);
            connection.Open();
            if (dt.Rows.Count <= 1)
            {
                if (answer == DialogResult.Yes)
                {
                    MySqlCommand commandDatabase = new MySqlCommand("DELETE from department where id=" + departmentId, connection);
                    commandDatabase.CommandTimeout = 60;

                    MySqlDataReader myReader = commandDatabase.ExecuteReader();


                    MessageBox.Show("The department has been deleted!");

                }

            }
            else
            {
                MessageBox.Show("You can't delete a department with employees in it.");
            }
            return false;
        }
        public static bool ConfirmCreatedDepartment(string depName, string staffAmount, int managerId)
        {
            string query = "INSERT INTO department(`id`, `name`, `staffamount`, `managerid`,`date`) VALUES (NULL, '" + depName + "', '" + staffAmount + "', '" + managerId + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                if (!string.IsNullOrWhiteSpace(depName) && !string.IsNullOrWhiteSpace(Convert.ToString(managerId)) && !string.IsNullOrWhiteSpace(staffAmount))
                {
                    int parsedValue;
                    if (!int.TryParse(Convert.ToString(managerId), out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");

                    }
                    if (!int.TryParse(staffAmount, out parsedValue))
                    {
                        MessageBox.Show("'Staff number' and 'manager id' are number fields only!");

                    }

                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Department succesfully created");

                    databaseConnection.Close();
                }

            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}

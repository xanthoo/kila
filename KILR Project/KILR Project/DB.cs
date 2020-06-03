﻿
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

        public static DataRow FindUser(string username, string password)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT id, username, position FROM users WHERE username = @username AND password = @password",
                    connection
                );
                adapter.SelectCommand.Parameters.AddWithValue("@username", username);
                adapter.SelectCommand.Parameters.AddWithValue("@password", password);
                connection.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    return null;
                }

                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //STOCK DATABASE MANAGER

        public static void AddStock(Product p)
        {
            string query = "INSERT INTO product(`productid`, `productname`, `quantity`,`sellingprice`,`buyingprice`,`stockactivity`,`minquantity`,`datecreated`) VALUES(NULL, '" + p.Name + "', '" + p.Quanitity + "', '" + p.SellingPrice + "', '" + p.BuyingPrice + "', 1, '" + p.MinimumQuantity + "', '" + p.DateCreated + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

            }
            catch (Exception)
            {
                throw new Exception("Check your connection to the database!");
            }
            finally
            {
                databaseConnection.Close();
            }
        }
        public static List<Product> GetAllStocks()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                List<Product> products = new List<Product>();
                products.Clear();
                string sql = " SELECT * FROM product;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Product(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), Convert.ToDecimal(reader[3]), Convert.ToDecimal(reader[4]), Convert.ToBoolean(reader[5]), Convert.ToInt32(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8])));
                }
                return products;
            }
            catch (Exception)
            {
                throw new Exception("Check your connection to the database!");
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool UpdateStock(Product p)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                if (p.IsActive == true)
                {
                    string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice +
                    "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '" + 1 + "', `minquantity` = '" + p.MinimumQuantity + "', `dateupdated` = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' WHERE `product`.`productid` = " + p.ID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    return true;

                }
                else
                {
                    string sql = " UPDATE `product` SET `productname` = '" + p.Name + "', `quantity` = '" + p.Quanitity + "', `sellingprice` = '" + p.SellingPrice +
                    "', `buyingprice` = '" + p.BuyingPrice + "', `stockactivity` = '" + 0 + "', `minquantity` = '" + p.MinimumQuantity + "', `dateupdated` = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' WHERE `product`.`productid` = " + p.ID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    connection.Open();
                    int effectedRows = cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new Exception("Check your connection to the database!");
            }
            finally
            {
                connection.Close();
            }

        }
        //END OF STOCK SYSTEM
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
        public static bool UpdateDepartment(string depName, string staffAmount, string managerId, int id)
        {
            string query = "UPDATE `department` SET `name`='" + depName + "',`staffamount`='" + staffAmount + "',`managerid`='" + managerId + "' WHERE id =" + id;
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                if (!string.IsNullOrWhiteSpace(depName) && !string.IsNullOrWhiteSpace(staffAmount) && !string.IsNullOrWhiteSpace(managerId))
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

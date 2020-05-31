
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

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
    }
}

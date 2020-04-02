using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace KILR_Project
{
    class UserManager
    {
        private string connectionString;

        public UserManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public User GetUser(string username, string password)
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
                adapter.SelectCommand.Parameters.AddWithValue("@password", ComputeSha256Hash(password));
                connection.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0) {
                    return null;
                }

                RoleEnum role = RoleEnum.Employee;
                switch ((int)dt.Rows[0]["position"])
                {
                    case 0:
                        role = RoleEnum.Admin;
                        break;
                    case 1:
                        role = RoleEnum.Manager;
                        break;
                    case 2:
                        role = RoleEnum.Employee;
                        break;
                }

                return new User(
                    dt.Rows[0]["id"].ToString(),
                    dt.Rows[0]["username"].ToString(),
                    role
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;

namespace KILR_Project
{
    class UserManager
    {
        public User GetUser(string username, string password)
        {
            DataRow user = DB.FindUser(username, ComputeSha256Hash(password));
            if (user == null) {
                return null;
            }

            RoleEnum role = RoleEnum.Employee;
            switch ((int)user["position"])
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
                user["id"].ToString(),
                user["username"].ToString(),
                role
            );
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

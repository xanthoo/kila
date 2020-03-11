using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }

        public User GetUser(string username, string password)
        {
            return users.Find(user =>
                user.Role != RoleEnum.Employee &&
                user.Username == username &&
                user.Password == password
            );
        }
    }
}

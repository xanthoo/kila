using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum RoleEnum
{
    Admin = 0,
    Manager = 1,
    Employee = 2
}

namespace KILR_Project
{
    class User
    {
        private RoleEnum role;
        private String password;
        private String username;
        private int id;

        public RoleEnum Role { get; set; }
        public String Username { get; set; }
        public String Id { get; set; }

        public User(String Id, String Username, RoleEnum Role)
        {
            this.Id = Id;
            this.Username = Username;
            this.Role = Role;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    class Employee
    {
        private String fristName;
        private String lastName;
        private int departmentId;
        private String adress;
        private String email;
        private decimal hourlyWage;
        private int id;

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Adress { get; set; }
        public String Email { get; set; }
        public int DepartmentId { get; set; }
        public decimal HourlyWage { get; set; }
        public int Id { get; set; }

        public String GetInfo()
        {
            return $"Employee name: {this.FirstName} {this.LastName}, adress: {this.adress}, email: {this.email}, hourly wage: {this.hourlyWage} ";

        }
    }
}

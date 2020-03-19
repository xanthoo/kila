using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class Employee
    {
        private String fristName;
        private String lastName;
        private int departmentId;
        private String address;
        private String email;
        private double hourlyWage;
        private int id;
        private String username;
        private Shift employeeShift;
        private int employeeId;
        private Position position;
        private DateTime hiredDate;
        private DateTime firedDate;

        public Employee(string fName, string lastName, int dep, Position position, string email, string address, Shift shift, DateTime HireDate, double hourlyWage)
        {
            this.fristName = fName;
            this.lastName = lastName;
            this.departmentId = dep;
            this.position = position;
            this.email = email;
            this.employeeShift = shift;
            this.hourlyWage = hourlyWage;
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Username { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public int DepartmentId { get; set; }
        public Shift EmployeeShift { get; set; }
        public decimal Salary { get; set; }
        public Position EmployeePosition { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime FiredDate { get; set; }
        public decimal HourlyWage { get; set; }
        public int EmployeeId { get; set; }

        public String GetInfo()
        {
            return $"Employee name: {this.FirstName} {this.LastName}, adress: {this.address}, email: {this.email}, hourly wage: {this.hourlyWage} ";

        }
    }
}

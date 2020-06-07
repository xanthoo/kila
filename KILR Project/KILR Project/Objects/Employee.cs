using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    public class Employee
    {
        private String firstName;
        private String lastName;
        private int departmentId;
        private String address;
        private String email;
        private double hourlyWage;
        private int id;
        private String username;
        private Shift employeeShift;
        private Position position;
        private String hiredDate;
        private String firedDate;

        public Employee(int id, string fName, string lastName, int dep, Position position, string email, string address, String HireDate, double hourlyWage)
        {
            this.id = id;
            this.firstName = fName;
            this.lastName = lastName;
            this.departmentId = dep;
            this.position = position;
            this.address = address;
            this.email = email;
            this.hiredDate = HireDate;
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
        public String HiredDate { get; set; }
        public String FiredDate { get; set; }
        public decimal HourlyWage { get; set; }
        public int Id { get; set; }
        public int GetId()
        {
            return this.id;
        }
        public Position GetEmployeePosition()
        {
            return this.position;
        }

        public String GetInfo()
        {
            return $"Id: {this.id} - Name: {this.firstName} {this.lastName} DepId: {this.departmentId} Pos: {this.position}";

        }
    }
}

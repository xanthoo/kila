using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace KILR_Project
{
    public class Department
    {
        private int id;
        private String name;
        private string createdDate;
        private int maxStaff;
        private int managerID;
        private List<Employee> employees;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        public int ManagerID { get { return managerID; } }

        public int Id{get { return this.id; }}

        public String Name { get { return this.name; } }

        public int MaxStaff{get {return this.maxStaff; }}
        public string CreatedDate { get { return this.createdDate; } }
        public Department(int id, String name, int maxStaff, int managerID, string created)
        {
            this.id = id;
            this.name = name;
            this.maxStaff = maxStaff;
            this.managerID = managerID;
            this.createdDate = created;
            employees = new List<Employee>(maxStaff);
        }
        public void AddEmployees(Employee e)
        {
            employees.Add(e);
        }


        public List<Employee> GetEmployees()
        {
            List<Employee> people = new List<Employee>();
            people.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = " SELECT * FROM `employee` WHERE department = " + this.id + ";";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter;
            adapter = new MySqlDataAdapter(sql, connection);
            connection.Open();

            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {

                Position position = Position.EMPLOYEE;
                switch (row["position"].ToString())
                {
                    case "EMPLOYEE":
                        position = Position.EMPLOYEE;
                        break;
                    case "MANAGER":
                        position = Position.MANAGER;
                        break;
                    case "ADMINISTRATOR":
                        position = Position.ADMINISTRATOR;
                        break;
                }

                Shift shift = Shift.AFTERNOON;
                switch (row["shift"].ToString())
                {
                    case "AFTERNOON":
                        shift = Shift.AFTERNOON;
                        break;
                    case "DAY":
                        shift = Shift.DAY;
                        break;
                    case "NIGHT":
                        shift = Shift.NIGHT;
                        break;
                }

                people.Add(
                    new Employee(
                        (int)row["id"],
                        row["firstname"].ToString(),
                        row["lastname"].ToString(),
                        (int)row["department"],
                        position,
                        row["email"].ToString(),
                        row["address"].ToString(),
                        shift,
                        row["hiredate"].ToString(),
                        Convert.ToDouble(row["hourlywage"].ToString())
                    )
                );
            }
            connection.Close();

            Console.WriteLine("empoyees count:");
            Console.WriteLine(people.Count);
            return people;
        }
        public List<Employee> GetOtherEmployees()
        {
            List<Employee> people = new List<Employee>();
            people.Clear();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = " SELECT * FROM `employee` WHERE department <> " + this.id + ";";
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter;
            adapter = new MySqlDataAdapter(sql, connection);
            connection.Open();

            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {

                Position position = Position.EMPLOYEE;
                switch (row["position"].ToString())
                {
                    case "EMPLOYEE":
                        position = Position.EMPLOYEE;
                        break;
                    case "MANAGER":
                        position = Position.MANAGER;
                        break;
                    case "ADMINISTRATOR":
                        position = Position.ADMINISTRATOR;
                        break;
                }

                Shift shift = Shift.AFTERNOON;
                switch (row["shift"].ToString())
                {
                    case "AFTERNOON":
                        shift = Shift.AFTERNOON;
                        break;
                    case "DAY":
                        shift = Shift.DAY;
                        break;
                    case "NIGHT":
                        shift = Shift.NIGHT;
                        break;
                }

                people.Add(
                    new Employee(
                        (int)row["id"],
                        row["firstname"].ToString(),
                        row["lastname"].ToString(),
                        (int)row["department"],
                        position,
                        row["email"].ToString(),
                        row["address"].ToString(),
                        shift,
                        row["hiredate"].ToString(),
                        Convert.ToDouble(row["hourlywage"].ToString())
                    )
                );
            }
            connection.Close();

            Console.WriteLine("empoyees count:");
            Console.WriteLine(people.Count);
            return people;
        }
        //public List<Employee>

        public String GetInfo()
        {
            return $"Department id: {this.id} , name: {this.name} and staff amount of {employees.Count} people";
        }
        
    }
}

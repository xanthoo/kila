using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KILR_Project
{
    class EmployeeManager
    {
        List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in employees)
            {
                if(employee.EmployeeId == id)
                {
                    return employee;
                }
            }
            return null;
        }
        public void AddEmpployee(Employee e)
        {
            employees.Add(e);
        }
        public void RemoveEmployee(Employee e)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if(employees[i] == e)
                {
                    employees.RemoveAt(i);
                }
            }
        }
        public bool CheckIfEmployeeExists(Employee e)
        {
            foreach (Employee employee in employees)
            {
                if(employee == e)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

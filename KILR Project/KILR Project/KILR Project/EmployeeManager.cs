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
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in employees)
            {
                if(employee.Id == id)
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
        public bool RemoveEmployee(Employee e)
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

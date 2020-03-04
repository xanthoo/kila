using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kilr_application
{

    public partial class Form1 : Form
    {
        private API api = new API();

        public Form1()
        {
            InitializeComponent();

            // API example
            List<Employee> employees = api.Get<List<Employee>>("employees");
            Console.WriteLine(employees.Count);
            if (employees.Count > 0) {
                Console.WriteLine(employees[0].first_name + " " + employees[0].last_name);
            }
        }
    }
}

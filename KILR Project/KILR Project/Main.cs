using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KILR_Project
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            
        }
        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateDepartment createDepartmentForm = new CreateDepartment(this);
            createDepartmentForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (lbDepartments.SelectedIndex > -1)
            {
                DepartmentInformation departmentInfoForm = new DepartmentInformation(this);
                CreateDepartment createDepartmentForm = new CreateDepartment(this);
               
                departmentInfoForm.Show();

            }
        }
    }
}

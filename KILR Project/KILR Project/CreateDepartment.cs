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
    public partial class CreateDepartment : Form
    {
        Main mainDepartmentInfo;
        public CreateDepartment(Main mainForm)
        {
            InitializeComponent();
            mainDepartmentInfo = mainForm;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbDepartmentName.Text.Length > 0)
            {
                if (tbMaxPeople.Text.Length > 0)
                {
                    if (tbMinPeople.Text.Length > 0)
                    {
                        var result = ("Department name: " + tbDepartmentName.Text + " | " + " Min employees: " + tbMinPeople.Text + " | " + " Max employees: " + tbMaxPeople.Text);

                        mainDepartmentInfo.lbDepartments.Items.Add(result);
                    }
                }
            }
       
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

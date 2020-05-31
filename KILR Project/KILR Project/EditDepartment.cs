using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KILR_Project
{
    public partial class EditDepartment : Form
    {
        DepartmentManager dm;
        DepartmentInformation depInfo;
        Main mainDepartmentInfo;
        int departmentId;
        string connectionString;

        public EditDepartment(Main mainForm,DepartmentInformation infoForm, int DepartmentID)
        {
            InitializeComponent();
            dm = new DepartmentManager("Jupiter Managers");
            depInfo = infoForm;
            departmentId = DepartmentID;
            mainDepartmentInfo = mainForm;
            RefreshList();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConnectionString();
            DB.UpdateDepartment(tbDepartmentName.Text, tbMaxPeople.Text, tbMinPeople.Text, departmentId);
            mainDepartmentInfo.PopulateDepartmentsList();

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditDepartment_Load(object sender, EventArgs e)
        {

        }
  

        private void btnAddEmp_Click(object sender, EventArgs e)
        {

            DB.AddEmployeeFromDepartment(departmentId, tbFindEmployee.Text);
            RefreshList();
        }

        private void btnRmvEmp_Click(object sender, EventArgs e)
        {
            DB.RemoveEmployeeFromDepartment(departmentId, tbFindEmployee.Text);
            RefreshList();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //private Department FoundDepartment()
        //{
        //    Department d = dm.GetDepartment(departmentId);
        //    return d;

        //}
        //private void RefreshList()
        //{
        //    lbDepartmentEmployees.Items.Clear();
        //    foreach (Employee e in FoundDepartment().GetEmployees())
        //    {
        //        lbDepartmentEmployees.Items.Add(e.GetInfo());
        //    }
        //}
        private void ConnectionString()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        }
        private void RefreshList()
        {
            lbDepartmentEmployees.Items.Clear();
            Department d = dm.GetDepartment(departmentId);
            foreach (Employee e in d.GetEmployees())
            {
                lbDepartmentEmployees.Items.Add(e.GetInfo());
            }

            lbOtherEmployees.Items.Clear();
            Department d2 = dm.GetDepartment(departmentId);
            foreach (Employee e in d2.GetOtherEmployees())
            {
                lbOtherEmployees.Items.Add(e.GetInfo());
            }
        }
    }
}

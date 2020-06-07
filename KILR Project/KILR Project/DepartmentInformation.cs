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
    public partial class DepartmentInformation : Form
    {
        Main mainDepartmentInfo;
        CreateDepartment createDepartmentForm;
        DepartmentInformation depInfo;
        DepartmentManager dm;
        Department department;

        int departmentId;
        string connectionString;
        public DepartmentInformation(Main mainForm, int DepartmentID, DepartmentManager dm)
        {
            InitializeComponent();
            departmentId = DepartmentID;
            mainDepartmentInfo = mainForm;
            this.dm = dm;
            ConnectionString();
            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM department where id =" + departmentId, connection);
            connection.Open();

            adapter.Fill(dt);

            int id = (int)dt.Rows[0].ItemArray[0];
            string name = (string)dt.Rows[0].ItemArray[1];
            int staffamount = (int)dt.Rows[0].ItemArray[2];
            int managerid = (int)dt.Rows[0].ItemArray[3];
            DateTime date = (DateTime)dt.Rows[0].ItemArray[4];

            lblDepartmentName.Text = name;
            lblDateCreated.Text = date.ToString();
            lblMaxStaffAmount.Text = staffamount.ToString();
            lblDepartmentID.Text = id.ToString();
            lblManagerId.Text = managerid.ToString();
            RefreshList();

            connection.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DepartmentDataAccess.RemoveDepartment(departmentId);
            mainDepartmentInfo.PopulateDepartmentsList();
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditDep_Click(object sender, EventArgs e)
        {
            Console.WriteLine("departmentId");
            Console.WriteLine(departmentId);
            EditDepartment editDepartmentForm = new EditDepartment(this.mainDepartmentInfo, depInfo, departmentId);
            editDepartmentForm.Show();
            this.Close();
        }

        private void DepartmentInformation_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RefreshList()
        {
            Department d = dm.GetDepartment(departmentId);
            lbDepEmps.Items.Clear();
            foreach (Employee e in d.GetEmployees())
            {
                lbDepEmps.Items.Add(e.GetInfo());
            }
        }
        private void ConnectionString()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        }
    }
}

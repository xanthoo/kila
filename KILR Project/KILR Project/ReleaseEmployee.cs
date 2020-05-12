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
    public partial class ReleaseEmployee : Form
    {
        int newId;
        EmployeeManager em;
        public ReleaseEmployee(int id)
        {
            InitializeComponent();
            newId = id;
            em = new EmployeeManager();
        }

        private void BtnRmv_Click(object sender, EventArgs e)
        {
            string date = dtpRelease.Value.ToString("yyyy-MM-dd");
            em.RemoveEmployee(newId, date);
            MessageBox.Show("Employee release date set!");
            btnRmv.Enabled = false;
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            EmployeeInformation ei = new EmployeeInformation(newId);
            ei.Show();
            this.Close();
        }
    }
}

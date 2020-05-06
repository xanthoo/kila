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
    public partial class AssignShift : Form
    {
        public int newId;
        public AssignShift(int id)
        {
            InitializeComponent();
            newId = id;
            foreach (var item in DB.GetShifts(id))
            {
                lbShifts.Items.Add(item);
            }
        }

        private void BtnShift_Click_1(object sender, EventArgs e)
        {
            lbShifts.Items.Clear();
            if (!rbtnDay.Checked && !rdbtnMonth.Checked)
            {
                MessageBox.Show("Please select day or month.");
            }
            else
            {
                if (rdbtnMonth.Checked)
                {
                    int num = DateTime.DaysInMonth(dtpShift.Value.Year, dtpShift.Value.Month);
                    for (int i = 1; i <= num; i++)
                    {
                        DateTime currentDate = new DateTime(dtpShift.Value.Year, dtpShift.Value.Month, i);
                        DB.AddDayShift((Shift)cbShift.SelectedIndex, currentDate.ToString("yyyy-MM-dd"), newId);
                    }
                    foreach (var item in DB.GetShifts(newId))
                    {
                        lbShifts.Items.Add(item);
                    }
                }
                else
                {
                    string date = dtpShift.Value.ToString("yyyy-MM-dd");
                    DB.AddDayShift((Shift)cbShift.SelectedIndex, date, newId);
                    foreach (var item in DB.GetShifts(newId))
                    {
                        lbShifts.Items.Add(item);
                    }
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            EmployeeInformation empInfo = new EmployeeInformation(newId);
            empInfo.Show();
            this.Close();
        }
    }
}

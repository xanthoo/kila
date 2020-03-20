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
    public partial class Login : Form
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kilrdb;";
        private UserManager userManager;

        public Login()
        {
            InitializeComponent();

            userManager = new UserManager(connectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = userManager.GetUser(
                tbUsername.Text,
                tbPassword.Text
            );

            if (user == null)
            {
                MessageBox.Show("Incorrect details!");
            }
            else
            {
                Main mainForm = new Main(user);
                mainForm.Show();
                this.Close();
            }
        }
    }
}

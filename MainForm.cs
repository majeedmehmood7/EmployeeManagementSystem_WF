using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are You Want to logout ??", "Confirmation Message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void Dashboard_btn_Click(object sender, EventArgs e, Dashboard dashboard)
        {
           
        }

        private void Employee_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            employee1.Visible = true;
            salary1.Visible =false;
       }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            employee1.Visible = false;
            salary1.Visible = true;
        }

        private void greent_user_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            employee1.Visible = false;
            salary1.Visible = false;
        }
    }
}

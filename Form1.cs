using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9C6UBMA;Initial Catalog=employee;Integrated Security=True;Encrypt=False;");
     
        Myconnection connect = new Myconnection();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm Register = new RegisterForm();
            Register.Show();
            this.Hide();
        }

        private void Login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            Login_password.PasswordChar = Login_showpassword.Checked ? '\0' : '*';
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
               

            if (login_username.Text == "" || Login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9C6UBMA;Initial Catalog=employee;Integrated Security=True;Encrypt=False;"))
                {
                    try
                    {
                        //connect.Open();
                        //string InsertDate = "SELECT * FROM users WHERE username = @username AND password = @password";

                        //using (SqlCommand cmd = new SqlCommand(InsertDate, connect))
                        //{
                        //    cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                        //    cmd.Parameters.AddWithValue("@password", Login_password.Text.Trim());

                        //    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        //    {
                        //        DataTable table = new DataTable();
                        //        adp.Fill(table);

                        //        if (table.Rows.Count >= 1)
                        //        {
                        //            MessageBox.Show("Login successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //            MainForm mainform = new MainForm();
                        //            mainform.Show();
                        //            this.Hide();
                        //        }
                        //        else
                        //        {
                        //            MessageBox.Show("Login failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //        }
                        //    }
                        //}

                        using (connect)
                        {

                            SqlCommand cmd = new SqlCommand("sp_role_login1", connect);
                            cmd.CommandType = CommandType.StoredProcedure;
                            connect.Open();
                            cmd.Parameters.AddWithValue("@uname", login_username.Text);
                            cmd.Parameters.AddWithValue("upass", Login_password.Text);
                            SqlDataReader rd = cmd.ExecuteReader();
                            if (rd.HasRows)
                            {
                                rd.Read();
                                if (rd[4].ToString() == "Admin")
                                {
                                    Myconnection.type = "A";
                                     
                                }
                                else if (rd[4].ToString()== "User")
                                {
                                    Myconnection.type = "U";
                                }

                                MainForm mainform = new MainForm();
                                mainform.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }

                        }

                    }

                    
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

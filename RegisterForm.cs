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
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9C6UBMA;Initial Catalog=employee;Integrated Security=True;Encrypt=False;");



        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();
            LoginForm.Show();
            this.Hide();
        }

        private void Signup_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = Signup_showpassword.Checked ? '\0' : '*';

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if((signup_username.Text == "") || (Signup_showpassword.Text == ""))
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Check for the user Is user is already exist.

                        string setusername = "SELECT COUNT(id)s FROM users WHERE username = @user";

                        using(SqlCommand checkUser = new SqlCommand(setusername , connect))
                        {
                            checkUser.Parameters.AddWithValue("@user" , signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if(count >=1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "Is Already Taken"
                                    ,"Error Message " , MessageBoxButtons.OK,MessageBoxIcon.Error );

                                

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertDate = "INSERT INTO users" +
                                    "(username,password,date_register) " +
                                    "VALUES(@username , @password , @date_register)";

                                using (SqlCommand cmd = new SqlCommand(insertDate, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date_register", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Register Successfully"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 Login = new Form1();
                                    Login.Show();
                                    this.Hide();
                                }
                            }

                        }
                        }

                       
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error" + ex,
                         "Error Message"   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}

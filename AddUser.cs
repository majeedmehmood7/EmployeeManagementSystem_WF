using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class AddUser : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9C6UBMA;Initial Catalog=employee;Integrated Security=True;Encrypt=False;");
        public AddUser()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            adduser_password.PasswordChar = Signup_showpassword.Checked ? '\0' : '*';
        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
            Image img = imagebox.Image;
            ImageConverter converter = new ImageConverter();
            var imageConverter = converter.ConvertTo(img, typeof(Byte[]));

            if ((adduser_username.Text == "") || (adduser_password.Text == "" || adduser_Status.Text == ""))
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Check for the user Is user is already exist.

                        string setusername = "SELECT COUNT(id)s FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(setusername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", adduser_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(adduser_username.Text.Trim() + "Is Already Taken"
                                    , "Error Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);



                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertDate = "INSERT INTO users" +
                                    "(username,password,date_register,status,picture) " +
                                "VALUES(@username , @password , @date_register,@status,@picture)";

                                using (SqlCommand cmd = new SqlCommand(insertDate, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", adduser_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", adduser_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", adduser_Status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@picture", imageConverter);
                                    cmd.Parameters.AddWithValue("@date_register", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Register Successfully"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    
                                }
                            }

                        }
                    }




                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex,
                         "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void Insert_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Title = "Open Image";
            dia.Filter = "Image Files (*.jpg; *.png) |*jpg;*png";

            if(dia.ShowDialog() == DialogResult.OK)
            {
                imagebox.Image = Image.FromFile(dia.FileName);
            }
        }
    }
}


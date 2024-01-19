using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EmployeeManagementSystem
{
    public partial class Manager : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9C6UBMA;Initial Catalog=employee;Integrated Security=True;Encrypt=False;");

        public Manager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //connect.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO manager (managerId, managerName, gender) VALUES (@managerid, @managername, @gender)", connect);

            //cmd.Parameters.AddWithValue("@managerid", manager_id.Text);
            //cmd.Parameters.AddWithValue("@managername", manager_name.Text);
            //cmd.Parameters.AddWithValue("@gender", manager_gender.Text.Trim());

            //cmd.ExecuteNonQuery();
            //connect.Close();

            //MessageBox.Show("Data is saved into the database");

            Image img = imagebox.Image;
            ImageConverter converter = new ImageConverter();
            var imageConverter = converter.ConvertTo(img, typeof(Byte[]));

            if (manager_id.Text == ""
              || manager_name.Text == ""
              || manager_gender.Text == ""
              || imagebox.Image == null
               )
            {

                MessageBox.Show("Please fill all the blank fields "
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                        connect.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO manager (managerId, managerName, gender,picture) VALUES (@managerid, @managername, @gender ,@picture)", connect);

                        cmd.Parameters.AddWithValue("@managerid", manager_id.Text);
                        cmd.Parameters.AddWithValue("@managername", manager_name.Text);
                        cmd.Parameters.AddWithValue("@gender", manager_gender.Text.Trim());
                        cmd.Parameters.AddWithValue("@picture", imageConverter);
                

                        cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Data Saved Successfully",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   

                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image img = imagebox.Image;
            ImageConverter converter = new ImageConverter();
            var imageConverter = converter.ConvertTo(img, typeof(Byte[]));

            if (manager_id.Text == ""
               || manager_name.Text == ""
               || manager_gender.Text == ""
               || imagebox.Image == null
                )
            {

                MessageBox.Show("Please fill all the blank fields "
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE manager SET managerName = @managername, gender = @gender WHERE managerId = @managerid", connect);

                        cmd.Parameters.AddWithValue("@managerid", manager_id.Text);
                        cmd.Parameters.AddWithValue("@managername", manager_name.Text);
                        cmd.Parameters.AddWithValue("@gender", manager_gender.Text.Trim());

                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Data Updated Successfully",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    }
                    catch(Exception ex) {
                        MessageBox.Show("Error: " + ex.Message,
                           "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                    
                }

                   

            }


        }

        private void insert_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Open Image";
            file.Filter = "Image Files (*.jpg; *.png) |*jpg;*png";

            if (file.ShowDialog() == DialogResult.OK) 
            {
                imagebox.Image = Image.FromFile(file.FileName);
            }

        }

    }
}
    


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
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class Employee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9C6UBMA;Initial Catalog=employee;Integrated Security=True;Encrypt=False;");
        DateTime today = DateTime.Today;
        

        public Employee()
        {
            InitializeComponent();
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listdata = new List<EmployeeData>();

            dataGridView1.DataSource = ed.employeeListData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void add_employee_Add_button_Click(object sender, EventArgs e)
        {
            if (add_employee_id.Text == ""
               || add_employee_name.Text == ""
               || add_employee_gender.Text == ""
               || add_employee_number.Text == ""
               || add_employee_position.Text == ""
               || status.Text == ""
               || employee_picture.Image == null
                ) 
            {

            MessageBox.Show("Please fill all the blank fields " 
                ,"Error Message" , MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            else
            {
                if (connect.State == ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";
                        using (SqlCommand checkEM = new SqlCommand(checkEmID, connect))
                        {
                            checkEM.Parameters.AddWithValue("@emID", add_employee_id.Text.Trim());
                            int count = (int)checkEM.ExecuteScalar();

                            if (count >= 1)  // Check for count greater than 0, not 1
                            {
                                MessageBox.Show(add_employee_id.Text.Trim() + " is Already Taken",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                // Stop execution if the ID is already taken
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees" +
                                    "(employee_id, full_name, gender, contact_number" +
                                    ", position, image, salary, insert_data, status)" +
                                    "VALUES(@employeeID, @fullname, @gender, @contactnumber" +
                                    ", @position, @image, @insertdate, @status)";

                                string imagePath = Path.Combine(@"D:\EMS C#\EmployeeManagementSystem\Directory\", add_employee_id.Text.Trim() + ".jpg");
                                string directoryPath = Path.GetDirectoryName(imagePath);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(employee_picture.ImageLocation, imagePath, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", add_employee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", add_employee_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", add_employee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactnumber", add_employee_number.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", add_employee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", imagePath);
                                    cmd.Parameters.AddWithValue("@insertdate", today);
                                    cmd.Parameters.AddWithValue("@status", status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Data Added Successfully",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }

                    catch (Exception ex)
                    {
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

        private void add_employee_import_btn_Click(object sender, EventArgs e)
        {
            try {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png) |*jpg;*png";
                string imagepath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    employee_picture.ImageLocation = imagepath;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex, "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           

        }
    }
}

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

            connect.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO manager (managerId, managerName, gender) VALUES (@managerid, @managername, @gender)", connect);

            cmd.Parameters.AddWithValue("@managerid", manager_id.Text);
            cmd.Parameters.AddWithValue("@managername", manager_name.Text);
            cmd.Parameters.AddWithValue("@gender", manager_gender.Text.Trim());

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Data is saved into the database");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmd = new SqlCommand("UPDATE manager SET managerName = @managername, gender = @gender WHERE managerId = @managerid", connect);

            cmd.Parameters.AddWithValue("@managerid", manager_id.Text);
            cmd.Parameters.AddWithValue("@managername", manager_name.Text);
            cmd.Parameters.AddWithValue("@gender", manager_gender.Text.Trim());

            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Data is Update into the database");


        }
    }
}
    


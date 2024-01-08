using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class EmployeeData
    {
        public int ID { get; set; }
        public string Employee_ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Position {  get; set; }

        public string Image {  get; set; }

        public int Salary { get; set; }

        public string Status {  get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-9C6UBMA;Initial Catalog=employee;Integrated Security=True;Encrypt=False;");

        public List<EmployeeData> employeelistData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "Select * From employees Where delete data is NULL";
                    using(SqlCommand cmd = new SqlCommand(selectData,connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData employeedata = new EmployeeData();
                            employeedata.ID = (int)reader["id"];
                            employeedata.Name= reader["full_name"].ToString();
                            employeedata.Employee_ID = reader["employee_id"].ToString() ;
                            employeedata.Gender = reader["gender"].ToString();
                            employeedata.Contact = reader["contact_number"].ToString();
                            employeedata.Position = reader["position"].ToString();
                            employeedata.Image = reader["image"].ToString();
                            employeedata.Salary = (int)reader["salary"];
                            employeedata.Status = reader["status"].ToString();

                            listdata.Add(employeedata);

                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error : " +ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}

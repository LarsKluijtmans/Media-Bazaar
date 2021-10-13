using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar.Class.ManagmentClasses
{
    public class DepartmentManagment
    {
        List<Department> departments;

        public static string GET_DEPARTMENTS = "SELECT `HeadDepatment`,`DepartmentName` FROM `departments`;";
        public DepartmentManagment()
        {
            departments = new List<Department>();
        }



        public List<Department> Departments
        {
            get { return departments; }
            set { departments = value; }
        }

     
        public void ViewAllDepartments()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_DEPARTMENTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Department department ;

                while (reader.Read())
                {
                    department = new Department(reader[1].ToString() , reader[0].ToString());
                    departments.Add(department);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

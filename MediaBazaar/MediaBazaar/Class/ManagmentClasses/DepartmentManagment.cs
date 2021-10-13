using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaar.Class.ManagmentClasses
{
    public class DepartmentManagment
    {
        List<Department> departments;

        public static string GET_DEPARTMENTS = "SELECT `HeadDepatment`,`DepartmentName`,`DepartmentID`  FROM `departments`;";
        public static string ADD_DEPARTMENT = "INSERT INTO departments ( DepartmentName, CompanyID, HeadDepatment) VALUES (@DepartmentName, @CompanyID, @HeadDepatment);";
        public static string EDIT_DEPARTMENT = "UPDATE departments SET DepartmentName = @DepartmentName, HeadDepatment = @HeadDepatment WHERE DepartmentID = @DepartmentID;";

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
                    department = new Department(reader[2].ToString() ,reader[1].ToString() , reader[0].ToString());
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

        public void AddDepartment(string Name, string Head, string CompanyID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = ADD_DEPARTMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DepartmentName", Name);
                cmd.Parameters.AddWithValue("@HeadDepatment", Head);
                cmd.Parameters.AddWithValue("@CompanyID", CompanyID);


                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

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

        public void EditDepartment(string Name, string Head, string DepartmetnID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = EDIT_DEPARTMENT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@DepartmentName", Name);
                cmd.Parameters.AddWithValue("@HeadDepatment", Head);
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmetnID);


                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

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

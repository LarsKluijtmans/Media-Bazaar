using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class DepartmentManagment
    {

        public static string GET_DEPARTMENTS = "SELECT `DepartmentID` , `HeadDepatment`,`DepartmentName` FROM `departments`;";
        public static string ADD_DEPARTMENT = "INSERT INTO departments ( DepartmentName, CompanyID, HeadDepatment) VALUES (@DepartmentName, @CompanyID, @HeadDepatment);";
        public static string EDIT_DEPARTMENT = "UPDATE departments SET DepartmentName = @DepartmentName, HeadDepatment = @HeadDepatment WHERE DepartmentID = @DepartmentID;";

        public DataTable ViewAllDepartments()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = GET_DEPARTMENTS;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataAdapter reader = new MySqlDataAdapter(sql, conn);

                DataTable table = new DataTable();
                reader.Fill(table);

                return table;
            }
            catch (MySqlException msqEx)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            DataTable a = new DataTable();
            return a;
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
            {  }
            catch (Exception)
            { }
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
            { }
            catch (Exception)
            {  }
            finally
            {
                conn.Close();
            }
        }
    }
}

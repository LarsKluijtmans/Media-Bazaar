using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses
{
   public class dbCompanyManagment : ICompanyManagment
    {
        public static string GET_COMPANY = " SELECT Employee.EmployeeID, CompanyName, company.Address, company.Email, KVK, btw, company.PhoneNumber, company.CompanyID FROM `EMPLOYEE` INNER JOIN contract ON employee.EmployeeID = contract.EmployeeID INNER JOIN  jobs ON jobs.JobTitle = contract.JobTitle INNER JOIN departments ON departments.DepartmentID = jobs.DepartmentID INNER JOIN company ON company.CompanyID = departments.CompanyID HAVING employee.EmployeeID = @EmployeeID;";
        public static string Edit_COMPANY = "UPDATE company SET CompanyName = @CompanyName, Address = @Address, Email = @Email, KVK = @KVK, btw = @btw , PhoneNumber = @PhoneNumber WHERE CompanyID = @CompanyID;";

        public Company GetCompany(int UserID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_COMPANY;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmployeeID", UserID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Company Company;

                while (reader.Read())
                {
                    Company = new Company(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString());

                    return Company;
                }
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public void EditCompany(string Name, string Adress, string PhoneNumber, string Email, string BTW, string KVK, string ID)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = Edit_COMPANY;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CompanyName", Name);
                cmd.Parameters.AddWithValue("@Address", Adress);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@KVK", KVK);
                cmd.Parameters.AddWithValue("@btw", BTW);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@CompanyID", ID);

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
            }
            catch (MySqlException)
            { }
            catch (Exception)
            { }
            finally
            {
                conn.Close();
            }
        }
    }
}

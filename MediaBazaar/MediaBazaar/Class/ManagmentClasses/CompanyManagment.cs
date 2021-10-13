using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace MediaBazaar.Class.ManagmentClasses
{
    class CompanyManagment
    {
        public Company company;
        public static string GET_COMPANY = " SELECT Employee.EmployeeID, CompanyName, company.Address, company.Email, KVK, btw, company.PhoneNumber FROM `EMPLOYEE` INNER JOIN contract ON employee.EmployeeID = contract.EmployeeID INNER JOIN  jobs ON jobs.JobTitle = contract.JodTitle INNER JOIN departments ON departments.DepartmentID = jobs.DepartmentID INNER JOIN company ON company.ComapnyID = departments.CompanyID HAVING employee.EmployeeID = @EmployeeID;";

        public void GetCompany(int UserID)
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
                    Company = new Company(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                    company = Company;
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

        public void EditCompany()
        {

        }
    }
}

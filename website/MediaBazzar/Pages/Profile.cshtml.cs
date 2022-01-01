using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibraryProject.ChildClasses;

namespace MediaBazzar.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public Admin employee { get; set; }

        public void OnGet()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = EmployeeManagement.GET_EMPLOYEE_BY_USERNAME;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", User.Identity.Name.ToString());

                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32("Active") == 1)
                    {
                        employee = new Admin();

                        employee.EmployeeID = reader.GetInt32("EmployeeID");
                        employee.FirstName = reader.GetString("FirstName");
                        employee.LastName = reader.GetString("LastName");
                        employee.Username = reader.GetString("UserName");
                        employee.Password = reader.GetString("Password");
                        employee.BSN = reader.GetInt32("BSN");
                        employee.City = reader.GetString("Address");
                        employee.Email = reader.GetString("Email");
                        employee.PhoneNumber = reader.GetInt32("PhoneNumber");
                    }
                    else
                    {
                        ViewData["Message"] = "Whats worng whight you, get out of here!!!";
                    }
                }
            }
            catch (MySqlException)
            {
                ViewData["Message"] = "Error please try again later.";
            }
            finally
            {
                conn.Close();
            }
        }
        public void OnPost()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = EmployeeManagement.EDIT_EMPLOYEE_BY_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@UserName", employee.Username);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                cmd.Parameters.AddWithValue("@BSN", employee.BSN);
                cmd.Parameters.AddWithValue("@City", employee.City);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();

            }
            catch (MySqlException)
            {
                ViewData["Message"] = "Error!! There is aproblem with the database. ";
            }
            catch
            { 
                ViewData["Message"] = "Error please try again later."; 
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

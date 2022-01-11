using ClassLibraryProject.Class;
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

            string sql = "SELECT * FROM Employee WHERE UserName = @UserName;";

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
                        employee.City = reader.GetString("City");
                        employee.Email = reader.GetString("Email");
                        employee.PhoneNumber = reader.GetString("PhoneNumber");
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
            employee.EmployeeManagerAll.UpdateOwnInfo(employee);
      
        }
    }
}

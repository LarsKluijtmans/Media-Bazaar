using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibraryProject.ChildClasses;
using System;
using ClassLibraryProject;
using System.Security.Claims;
using ClassLibraryProject.dbClasses;

namespace MediaBazzar.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        public dbLoginManager dbLogin = new dbLoginManager();

        [BindProperty]
        public DepotEmployee Employee { get; set; }

        [BindProperty]
        public int EmployeeID { get; set; }

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Username { get; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public int BSN { get;  }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string Email { get;  }
        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        public DateTime DateOfBirth { get;  }
        [BindProperty]
        public string PersonalEmail { get; set; }



        public IActionResult OnGet()
        {
            // get current user
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = (DepotEmployee)dbLogin.GetEmployeeByEmail(userEmail);

            return Page();
        }
        public IActionResult OnPost()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = (DepotEmployee)dbLogin.GetEmployeeByEmail(userEmail);

            if (Employee != null)
            {
                Employee.FirstName = FirstName;
                Employee.LastName = LastName;
                Employee.City = City;
                Employee.PhoneNumber = PhoneNumber;
                Employee.ZipCode = ZipCode;
                Employee.Address = Address;
                Employee.PersonalEmail = PersonalEmail;
                Employee.Password = Password;

                /*cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@City", e.City);
                cmd.Parameters.AddWithValue("@PhoneNumber", e.PhoneNumber);
                cmd.Parameters.AddWithValue("@StreetName", e.Address);
                cmd.Parameters.AddWithValue("@ZipCode", e.ZipCode);
                cmd.Parameters.AddWithValue("@PersonalEmail", e.PersonalEmail);
                cmd.Parameters.AddWithValue("@Password", e.Password);*/
                IEmployeeManagerAll employeeManagerAll = new EmployeeManager();
                employeeManagerAll.UpdateOwnInfo(Employee);

            } else
            {
                ViewData["Message"] = "Error";
            }

            return Page();
        }

    }
}

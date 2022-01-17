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

            ViewData["Message"] = Employee.EmployeeID.ToString();


            return Page();
        }
        public IActionResult OnPost()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = (DepotEmployee)dbLogin.GetEmployeeByEmail(userEmail);

            if (Employee != null)
            {
                Employee.Address = Address;
                ViewData["Message"] = $"{Employee.EmployeeID} {Employee.Address}";

                //Employee.EmployeeManagerAll.UpdateOwnInfo(Employee);
            } else
            {
                ViewData["Message"] = "Error";
            }

            return Page();
        }

    }
}

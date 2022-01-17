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
        public Employee Employee { get; set; }

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public IActionResult OnGet()
        {
            // get current user
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = dbLogin.GetEmployeeByEmail(userEmail);
             
            if (Employee is DepotEmployee)
            {
                this.FirstName = Employee.FirstName;
                this.LastName = Employee.LastName;
                this.Email = Employee.Email;
            }

            return Page();
        }
        public IActionResult OnPost()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = dbLogin.GetEmployeeByEmail(userEmail);

            Employee.FirstName = FirstName;
            Employee.LastName = LastName;
            Employee.Email = Email;

            Employee.EmployeeManagerAll.UpdateOwnInfo(Employee);

            return Page();
        }

    }
}

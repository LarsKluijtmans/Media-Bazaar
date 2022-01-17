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
using System.Text.RegularExpressions;

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

            Employee a = dbLogin.GetEmployeeByEmail(userEmail);

            Employee = new DepotEmployee();

            Employee.EmployeeID = a.EmployeeID;
            Employee.FirstName = a.FirstName;
            Employee.LastName = a.LastName;
            Employee.PhoneNumber = a.PhoneNumber;
            Employee.Email = a.Email;
            Employee.ZipCode = a.ZipCode;
            Employee.Address = a.Address;
            Employee.City = a.City;
            Employee.DateOfBirth = a.DateOfBirth;
            Employee.BSN = a.BSN;
            Employee.Username = a.Username;
            Employee.Password = a.Password;
            Employee.PersonalEmail = a.PersonalEmail;

            Employee = dbLogin.GetEmployeeByEmail(userEmail);

            return Page();
        }
        public IActionResult OnPost()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);



            Employee a = dbLogin.GetEmployeeByEmail(userEmail);

            Employee = new DepotEmployee();

            Employee.EmployeeID = a.EmployeeID;
            Employee.FirstName = a.FirstName;
            Employee.LastName = a.LastName;
            Employee.PhoneNumber = a.PhoneNumber;
            Employee.Email = a.Email;
            Employee.ZipCode = a.ZipCode;
            Employee.Address = a.Address;
            Employee.City = a.City;
            Employee.DateOfBirth = a.DateOfBirth;
            Employee.BSN = a.BSN;
            Employee.Username = a.Username;
            Employee.Password = a.Password;
            Employee.PersonalEmail = a.PersonalEmail;
            Employee = dbLogin.GetEmployeeByEmail(userEmail);

            if (!Regex.IsMatch(Employee.PhoneNumber, @"^(\+)316[0-9]{8}$"))
            {
                ViewData["Message"] = "PhoneNumber has to start with +316.";
                return Page();
            }
            if (!Regex.IsMatch(Employee.Password, @"^[a-zA-Z][0-9]{7}$"))
            {
                ViewData["Message"] = "Password has to have at least 8 characters.";
                return Page();
            }

            IEmployeeManagerOffice OF = new EmployeeManager();

            foreach (Employee e in OF.GetAllEmployees())
            {
                try
                {
                    if (e.PersonalEmail == Employee.PersonalEmail)
                    {
                        ViewData["Message"] = "Persenal email already exists.";
                        return Page();
                    }
                }
                catch
                {
                    ViewData["Message"] = "Persenal email already exists.";
                    return Page();
                }
            }

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


                IEmployeeManagerAll employeeManagerAll = new EmployeeManager();

                if (Employee is SalesRepresentative)
                {
                    employeeManagerAll.UpdateOwnInfo(Employee);
                }

            } else
            {
                ViewData["Message"] = "Error";
            }

            return Page();
        }
    }
}

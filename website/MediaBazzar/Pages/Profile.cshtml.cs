using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ClassLibraryProject.ChildClasses;
using System.Security.Claims;
using ClassLibraryProject.dbClasses;

namespace MediaBazzar.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public Employee CurrentEmployee { get; set; }

        public dbLoginManager dbLogin = new dbLoginManager();

        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        [BindProperty]
        public string PhoneNumber { get; set; }
        [BindProperty]
        public string PersonalEmail { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnGet()
        {
            // get current employee
            var employeeID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //CurrentEmployee = dbLogin.checkLogin()

            return Page();

        }
        public void OnPost()
        {
            
        }
    }
}

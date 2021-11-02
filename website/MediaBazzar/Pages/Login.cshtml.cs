using ClassLibrary1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MediaBazzar.Pages
{

    public class LoginModel : PageModel
    {

        [BindProperty]
        public User user { get; set; }

     //   public string PageTitle { get; set; }
     //   public string Message { get; set; }
     
       // public Login Login { get; set; }

        //public void OnPost() //Add Check if required is ok
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Message = "Login Successful";
        //        ViewData["Message"] = Message;

        //    }
        //}

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("User") == "admin")
                return new RedirectToPageResult("UserHome");
            if (HttpContext.Session.GetString("User") == "employee")
                return new RedirectToPageResult("EmployeeHome");
            return Page();
        }


        public IActionResult OnPost()
        {
            if (((user.Username == "admin") || (user.Username == "employee")) && (user.Password == "1"))
            {
                HttpContext.Session.SetString("User", user.Username);
                if (user.Username == "admin")
                    return new RedirectToPageResult("UserHome");
                else
                    return new RedirectToPageResult("EmployeeHome");
            }
            else
            {
                // invalid credentials
                ViewData["LoginMessage"] = "Invalid credentials, try again";
                return Page();
            }
        }
    }


 }
    
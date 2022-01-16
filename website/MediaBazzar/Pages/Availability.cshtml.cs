//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;
//using ClassLibraryProject.Class;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace MediaBazaarWebsite.Pages
//{
//    public class AvailableModel : PageModel
//    {

//        [BindProperty]
//        [Required]
//        public bool Prefered { get; set; }
//        [BindProperty]
//        [Required]
//        public int Day { get; set; }
//        [BindProperty]
//        [Required]
//        public string Shift { get; set; }

//        public SelectList Prefereds { get; set; }

//        public SelectList Shifts { get; set; }

//        public List<PreferedWorkTime> pwt { get; set; }



//        private CookieOptions cookieOptions = new CookieOptions
//        {
//            Expires = DateTime.Now.AddMinutes(5)
//        };

//        public IActionResult OnGetLogout()
//        {
//            HttpContext.Session.Remove("User");
//            return new RedirectToPageResult("Login");
//        }

//        public void OnGet()
//        {
//            PreferedWorkTimeManagement workTimeManagement = new PreferedWorkTimeManagement();
//            pwt = workTimeManagement.GetPreferedWorkTimeForEmployee(LoginModel.EmployeeID);
//            this.Prefereds = new SelectList(pwt, "Day", "Shift");

//        }


//        public void OnPostSubmit()
//        {
//            PreferedWorkTimeManagement preferedWorkTime = new PreferedWorkTimeManagement();
//            foreach (PreferedWorkTime p in pwt)
//            {
//                preferedWorkTime.EditPreferedWorkTimeForEmployee(p.Day, p.Shift, p.Prefered);
//            }
//        }
//    }
//}

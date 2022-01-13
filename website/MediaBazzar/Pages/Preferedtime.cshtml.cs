using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryProject;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    [Authorize]
    public class PreferedtimeModel : PageModel
    {


        [BindProperty]
        [Required]
        public int Prefered { get; set; }
        [BindProperty]
        [Required]
        public int Day { get; set; }
        [BindProperty]
        [Required]
        public string Shift { get; set; }

        public PreferedWorkTime preferedWork;

        private CookieOptions cookieOptions = new CookieOptions
        {
            Expires = DateTime.Now.AddMinutes(5)
        };

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("User");
            return new RedirectToPageResult("Login");
        }

      //  public void OnGet()
      //  {
      //      if (HttpContext.Session.GetString("User") == null)
      //      {
      //          return new RedirectToPageResult("Index");
      //      }

      //      PreferedWorkTimeManagement workTimeManagement = new PreferedWorkTimeManagement();
      ////      PreferedWorkTime preferedWork = workTimeManagement.GetAllPreferedWorkTime(HttpContext.Session.GetString("User"));


      //  }

    }
}

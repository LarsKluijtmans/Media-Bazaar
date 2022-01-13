using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazzar.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
 

        [BindProperty]
        public PreferedWorkTime schedule { get; set; }

        public List<PreferedWorkTime> pws { get; set; }

        private CookieOptions cookieOptions = new CookieOptions
        {
            Expires = DateTime.Now.AddMinutes(30)
        };

        public IActionResult OnGetLogout()
        { 
            HttpContext.Session.Remove("User");
            return new RedirectToPageResult("Login");
        }

        public void OnGet()
        {
            pws = new List<PreferedWorkTime>();
            PlanningManagment planning = new PlanningManagment();
            List<PreferedWorkTime> schedules = planning.GetPlanningForEmployee(LoginModel.EmployeeID);
            pws.AddRange(schedules);
        }
    }
}

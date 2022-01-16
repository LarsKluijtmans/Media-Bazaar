using System;
using System.Collections.Generic;
using ClassLibraryProject.Class;
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
            Expires = DateTime.Now.AddMinutes(5)
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
            List<PreferedWorkTime> schedules = planning.GetPlanningForEmployee(LoginModel.emplContract.Employee.EmployeeID.ToString());
            pws.AddRange(schedules);
        }
    }
}

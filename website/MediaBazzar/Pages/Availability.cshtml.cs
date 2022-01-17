using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class AvailabilityModel : PageModel
    {
        public dbLoginManager dbLogin = new dbLoginManager();

        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty]
        public DateTime Unavailable { get; set; }
        
        public void OnGet()
        { 
            // get current user
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = dbLogin.GetEmployeeByEmail(userEmail);
        }
        public IActionResult OnPost()
        {
            // get current user
            var userEmail = User.FindFirstValue(ClaimTypes.Email);

            Employee = dbLogin.GetEmployeeByEmail(userEmail);

            /* Week, Day and Year based on entered date */
            int weekNumber = GetWeekOfYear(Unavailable);
            string day = Unavailable.DayOfWeek.ToString();
            int year = Unavailable.Year;

            /* Create Unavailability */
            Unavailability unavailability = new Unavailability(year, weekNumber, day, Employee);

            /* Add Unavailability to database */
            IAvailabilityManager availabilityManager = new AvailabilityManager();
            
            if (availabilityManager.EnterAvailability(unavailability))
            {
                ViewData["Message"] = "Unavailability Entered";
            }

            return Page();
        }
        public int GetWeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}

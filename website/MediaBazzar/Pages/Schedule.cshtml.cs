using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using ClassLibraryProject.Class;
using ClassLibraryProject.Enum;
using ClassLibraryProject.ManagmentClasses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;

namespace MediaBazzar.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        [BindProperty]
        public  int week  { get; set; }
        [BindProperty]
        public int year { get; set; }

        public Days Day = Days.Monday;
        public Shifts Shift = Shifts.Morning;
        public WorkingToday WorkingToday = new WorkingToday();

        [BindProperty]
        public PreferedWorkTime schedule { get; set; }
        public List<PreferedWorkTime> pws { get; set; }
       
        private CookieOptions cookieOptions = new CookieOptions
        {
            Expires = DateTime.Now.AddMinutes(5)
        };

        public IActionResult OnGetLogout()
        {
            Day = Days.Monday;
            Shift = Shifts.Morning;
            HttpContext.Session.Remove("User");
            return new RedirectToPageResult("Login");
        }

        public void OnGet()
        {
            DateTime time = DateTime.Now;
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            week = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            year = time.Year;

            Day = Days.Monday;
            Shift = Shifts.Morning;
            pws = new List<PreferedWorkTime>();
            PlanningManagment planning = new PlanningManagment();
        }


        public bool ShiftIncrease()
        {
            try
            {
                Shift++;
                return true;
            }
            catch { return true; }
        }
        public bool DayIncrease()
        {
            try 
            { 
                Day++;
                return true;
            }
            catch { return true; }
        }

        public WorkingToday IsWorkingToday()
        {
            MySqlConnection conn = Utils.GetConnection();

            string sql = $"SELECT shift FROM `planning` WHERE `Week` = {week} and `Year`= {year} and `Day` = '{Day}' and `EmployeeID` =";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                WorkingToday.morning = false; 
                WorkingToday.afternoon = false; 
                WorkingToday.evening = false; 

                while (reader.Read())
                {

                    if (reader[0].ToString() == "Morning")
                    { WorkingToday.morning = true; }
                    if (reader[0].ToString() == "Afternoon")
                    { WorkingToday.afternoon = true; }
                    if (reader[0].ToString() == "Evening")
                    { WorkingToday.evening = true; }

                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return WorkingToday;
        }
    }
}

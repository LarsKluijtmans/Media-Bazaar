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

namespace MediaBazzar.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public Admin employee { get; set; }
        DBEmployeeManager updateporfile = new DBEmployeeManager();

        [BindProperty]
        public string Password { get; set; }

        //public void OnGet()
        //{
        //    updateporfile = new DBEmployeeManager();
        //    Employee a = updateporfile.GetEmployeeByID(LoginModel.emplContract.Employee.EmployeeID);

        //    employee.EmployeeID = a.EmployeeID;
        //    employee.FirstName = a.FirstName;
        //    employee.LastName = a.LastName;
        //    employee.PhoneNumber = a.PhoneNumber;
        //    employee.Email = a.Email;
        //    employee.City = a.City;
        //    employee.BSN = a.BSN;
        //    employee.Username = a.Username;
        //    employee.Password = a.Password;
        //    employee.ZipCode = a.ZipCode;
        //    employee.Address = a.Address;
        //    employee.DateOfBirth = a.DateOfBirth;
        //    employee.PersonalEmail = a.PersonalEmail;
        //}
        //public void OnPost()
        //{

        //    if (employee.Password == Password)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            updateporfile = new DBEmployeeManager();
        //            updateporfile.UpdateOwnInfo(employee);
        //        }
        //    }
        //    else
        //    {
        //        ViewData["Message"] = "Passwords not the same.";
        //    }
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        // fields
        private int employeeID;
        private string firstName;
        private string lastName;
        private string username;
        private string password;
        private int bsn;
        private int active;
        private string city;
        private string email;
        private int phoneNumber;
        private string dateOfBirth;

        // properties
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int BSN { get; set; }
        public int Active { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }

        // constructor
        public Employee()
        {

        }
        public Employee(int employeeID, string firstName, string lastName, int phoneNumber, string email, string city, string dateOfBirth, int bsn, string username, string password)
        {
            this.EmployeeID = employeeID;
            this.LastName = firstName;
            this.FirstName = lastName;
            this.Username = username;
            this.Password = password;
            this.BSN = bsn;
            this.Active = 1;
            this.City = city;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.DateOfBirth = dateOfBirth;
        } 
    }
}

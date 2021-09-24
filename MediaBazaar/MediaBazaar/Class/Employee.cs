using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
    {
    public class Employee
    {
        // fields
        private static int nextEmployeeID = 1;
        private int employeeID;
        private string lastName;
        private string firstName;
        private string gender;
        private int phoneNumber;
        private string email;
        private string city;
        private string dateOfBirth;
        private int bsn;
        private string username;
        private string password;
        private JobTitle type;

        private Contract contract; /* every employee has 1 contract*/

        private List<Shift> schedule; // list of shifts for schedule

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
        public string DateOfBirth { get; set; }
        public int BSN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int EmployeeID { get; private set; }
        public JobTitle Type { get; set; }
        public Contract Contract { get; set; }
        public List<Shift> Schedule { get; set; }
        // constructor
        public Employee(string lastname, string firstname, string gender, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password, JobTitle type)
         {
            Schedule = new List<Shift>();
            this.EmployeeID = nextEmployeeID;
            nextEmployeeID++;

            this.LastName = firstname;
            this.FirstName = lastname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateofbirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
            this.Type = type;
              
         }
        // methodes
        public override string ToString()
        {
            return $"ID: {EmployeeID} - Name: {FirstName} {LastName} - Email: {Email} - Type: {Type.ToString()}";
        }
    }
    }

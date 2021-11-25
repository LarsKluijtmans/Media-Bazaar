using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class Employee
    {
        // fields
        private int employeeID;
        private string lastName;
        private string firstName;
        private int phoneNumber;
        private string email;
        private string city;
        private string dateOfBirth;
        private int bsn;
        private string username;
        private string password;

        private Contract contract; /* every employee has 1 contract*/


        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int PhoneNumber { get; set; }
        public string City { get; set; }
        public string DateOfBirth { get; set; }
        public int BSN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int EmployeeID { get;  set; }
        public Contract Contract { get; set; }


        public Employee()
        {

        }
        public Employee(int id,string lastname, string firstname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
        {
            EmployeeID = id;
            this.LastName = lastname;
            this.FirstName = firstname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateofbirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;

        }
        // constructor
        public Employee(string lastname, string firstname,  int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
         {
            this.LastName = LastName;
            this.FirstName = firstname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateofbirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
              
         }
        // methodes
        public override string ToString()
        {
            return $"ID: {EmployeeID} - Name: {FirstName} {LastName} - Email: {Email}";
        }
    }
    }

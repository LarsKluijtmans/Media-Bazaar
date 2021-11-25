using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public int BSN { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public int EmployeeID 
        {
            get { return employeeID; }  
            set { employeeID = value; } 
        }
        public Contract Contract { get; set; }

        // constructor
        public Employee()
        { }

        public Employee(string lastname, string firstname,  int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
         {
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

        public Employee(int employeeid, string lastname, string firstname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateofbirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
            this.EmployeeID = employeeid;
        }

        // methodes
        public override string ToString()
        {
            return $"ID: {EmployeeID} - Name: {FirstName} {LastName} - Email: {Email}";
        }
    }
    }

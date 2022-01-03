using System;
using System.Collections.Generic;

namespace ClassLibraryProject.Class
{
    public abstract class Employee
    {
        // fields
        private int employeeID;
        private string firstName;
        private string lastName;
        private int phoneNumber;
        private string email;
        private string city;
        private DateTime dateOfBirth;
        private int bsn;
        private string username;
        private string password;

        private List<Contract> contracts; // list of contracts for employee (only 1 can be active)

        // properties
        public int EmployeeID { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BSN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Contract> Contracts { get; set; }

        // constructor
        public Employee()
        {

        }
        public Employee(string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
         {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateOfBirth;
            this.BSN = bsn;
            this.Username = username;
            this.Password = password;
         }

        public Employee(int employeeID, string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.City = city;
            this.DateOfBirth = dateOfBirth;
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

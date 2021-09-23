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
        private string address;
        private string dateOfBirth;
        private int bsn;
        private string username;
        private string password;
        private JobTitle type;

        private Contract contract; /* every employee has 1 contract*/

        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
        public int BSN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int EmployeeID { get; private set; }
        public JobTitle Type { get; set; }


        // constructors
        public Contract Contract
        {
            get { return contract; }
            private set { contract = value; }
        }
    

        public Employee(string lastname, string firstname, string gender, int phonenumber, string email, string address, string dateofbirth, int bsn, string username, string password, JobTitle type)
            {
                this.employeeID = nextEmployeeID;
                nextEmployeeID++;
                this.lastName = firstname;
                this.firstName = lastname;
                this.gender = gender;
                this.phoneNumber = phonenumber;
                this.email = email;
                this.address = address;
                this.dateOfBirth = dateofbirth;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
                this.type = type;
            }

        public Employee(string firstname, string lastname, int phonenumber, int bsn, string username, string password, string email)
            {
                this.lastName = lastname;
                this.firstName = firstname;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
                this.phoneNumber = phonenumber;
                this.email = email;

            }

         public Employee() 
        {

        }
         // methodes

        //public Shift MostPreferedTimeToWork()
        //    {
        //    return this.shift;
        //    }

        // public Shift LeastPreferedTimeToWork()  
        //    {
        //    if (this.shift == Shift.MORNING)
        //    {
        //        return Shift.EVENING;
        //    }
        //    else
        //        return Shift.MORNING;
        //    }

         public string Tostring()
            {
            return $"Name: {firstName}, Name: {lastName}, Email: {email}";
            }

        public override string ToString()
        {
            return $"ID: {EmployeeID }Name: {FirstName} {LastName} - Email: {Email}";
        }
    }
    }

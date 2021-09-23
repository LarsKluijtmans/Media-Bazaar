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
        private string lastname;
        private string firstname;
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
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int EmployeeID { get; private set; }
        public JobTitle Type { get; set; }


        // constructors

        public string Username { get; private set; }
        public string Password { get; private set; }

        public Contract Contract
        {
            get { return contract; }
            private set { contract = value; }
        }
    

        public Employee(string lastname, string firstname, string gender, int phonenumber, string email, string address, string dateofbirth, int bsn, string username, string password, JobTitle type)
            {
                this.employeeID = nextEmployeeID;
                nextEmployeeID++;
                this.lastname = lastname;
                this.firstname = firstname;
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

        public Employee(string lastname, string firstname, int phonenumber, int bsn, string username, string password, string email)
            {
                this.lastname = lastname;
                this.firstname = firstname;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
                this.phoneNumber = phonenumber;
                this.email = email;

            }

         public Employee() // need this constructor to implement formemployee
        {

        }
         // methodes

        public Shift MostPreferedTimeToWork()
            {
            return this.shift;
            }

         public Shift LeastPreferedTimeToWork()  
            {
            if (this.shift == Shift.MORNING)
            {
                return Shift.EVENING;
            }
            else
                return Shift.MORNING;
            }

         public string Tostring()
            {
            return $"Name: {firstname}, Name: {lastname}, Email: {email}";
            }

        public override string ToString()
        {
            return $"ID: {EmployeeID }Name: {Firstname} {Lastname} - Email: {Email}";
        }
    }
    }

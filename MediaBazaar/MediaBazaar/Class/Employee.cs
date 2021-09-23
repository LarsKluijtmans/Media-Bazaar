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
        private int phonenumber;
        private string email;
        private string address;
        private DateTime dateofbirth;
        private int bsn;
        private string username;
        private string password;
        private Shift shift;


        private Contract contract; /* every employee has 1 contract*/

        // properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int EmployeeID { get; private set; }


        // constructors

        public string Username { get; private set; }
        public string Password { get; private set; }

        public Contract Contract
        {
            get { return contract; }
            private set { contract = value; }
        }
    

        public Employee(int employeeID, string lastname, string firstname, string gender, int phonenumber, string email, string address, DateTime dateofbirth, int bsn, string username, string password, Shift shift)
            {
                this.employeeID = nextEmployeeID;
                nextEmployeeID++;
                this.lastname = lastname;
                this.firstname = firstname;
                this.gender = gender;
                this.phonenumber = phonenumber;
                this.email = email;
                this.address = address;
                this.dateofbirth = dateofbirth;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
                this.shift = shift;
            }

        public Employee(string lastname, string firstname, int phonenumber, int bsn, string username, string password, string email)
            {
                this.lastname = lastname;
                this.firstname = firstname;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
                this.phonenumber = phonenumber;
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

        }
    }

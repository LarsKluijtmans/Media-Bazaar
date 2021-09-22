using System;

namespace MediaBazaar
{
    public class Employee
    {
        // fields
        private static int counter = 1;
        private int employeeID;
        private string lastname;
        private string firstname;
        private int phonenumber;
        private string email;
        private string address;
        private DateTime dateofbirth;
        private int bsn;
        private string username;
        private string password;
        private JobTitle jobtitle;
        private Shift shift;


        // properties
        public int EmployeeID 
        { 
            get { return employeeID; } 
            set { employeeID = value; } 
        }
        public JobTitle JobTitle 
        { 
            get { return jobtitle; }
            set { jobtitle = value; } 
        }
        public string Username 
        { 
            get { return username; } 
            set { username = value; } 
        }
        public string Password 
        { 
            get { return password; } 
            set { password = value; } 
        }


        // constructors
        public Employee(string lastname, string firstname, int bsn, string username, string password)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.bsn = bsn;
            Username = username;
            Password = password;
        }
        public Employee(string lastname, string firstname, int phonenumber, string email, string address, DateTime dateofbirth,
            int bsn, string username, string password, Shift shift)
        {
            EmployeeID = counter;
            this.lastname = lastname;
            this.firstname = firstname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.address = address;
            this.dateofbirth = dateofbirth;
            this.bsn = bsn;
            this.username = username;
            this.password = password;
            this.shift = shift;

            counter++;
        }


        // methods
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
            return $"ID: {EmployeeID}, Name: {firstname + lastname}, Email: {email}";
        }

    }
}

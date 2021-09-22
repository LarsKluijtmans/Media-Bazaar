using System;

namespace MediaBazaar
{
    public class Employee
    {


        // fields
        private static int employeeID = 1;
        private string lastname;
        private string firstname;
        private int phonenumber;
        private string email;
        private string address;
        private DateTime dateofbirth;
        private int bsn;
        private string username;
        private string password;
        private Shift shift;

        // properties

        public int EmployeeID { get; private set; }


        // constructors

        public Jobs Jobtitle { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public Contract Contract { get; private set; }
        public Employee(string lastname, string firstname, int bsn, string username, string password)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.bsn = bsn;
            this.Username = username;
            this.Password = password;
        }
        public Employee(int employeeID, string lastname, string firstname,  int phonenumber, string email, string address, DateTime dateofbirth,
            int bsn, string username, string password, Shift shift)
        {
            employeeID++;
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

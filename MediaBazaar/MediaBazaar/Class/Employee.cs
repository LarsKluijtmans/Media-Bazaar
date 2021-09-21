using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
    {
    public class Employee
    {


        // fields
        private static int employeeID = 1;
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

        private Jobs jobTitle;
        private string floor;
        private int workHoursPerWeek;
        private int salaryPerHour;
        private DateTime startDate;
        private DateTime endDate;
        private string reasonForTermination;

        // properties

        public int EmployeeID { get; private set; }


        // constructors

        public Jobs Jobtitle { get; set; }

        public string Username { get; private set; }
        public string Password { get; private set; }

        public Contract Contract{ get; private set; }
            public Employee(string lastname, string firstname, int bsn, string username, string password, Jobs JobTitle)
            {
                this.lastname = lastname;
                this.firstname = firstname;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
               this.jobTitle = JobTitle;
            }
        public Employee(int employeeID, string lastname, string firstname, string gender, int phonenumber, string email, string address, DateTime dateofbirth, 
            int bsn, string username, string password, Shift shift, Jobs JobTitle, string Floor,int WorkHoursPerWeek, int SalaryPerHour,
            DateTime StartDate, DateTime EndDate, string ReasonForTermination)
        {
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
            this.jobTitle = JobTitle;
            this.floor = Floor;
            this.workHoursPerWeek = WorkHoursPerWeek;
            this.salaryPerHour = SalaryPerHour;
            this.startDate = StartDate;
            this.endDate = EndDate;
            this.reasonForTermination = ReasonForTermination;
        }

        public void EndContract(string ReasonForTermination, DateTime EndDate)
        {
            reasonForTermination = ReasonForTermination;
            endDate = EndDate;
        }

        public void EndContract(string ReasonForTermination)
        {
            reasonForTermination = ReasonForTermination; ;
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

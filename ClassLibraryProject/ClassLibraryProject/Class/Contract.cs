using System;

namespace ClassLibraryProject.Class
{
    public class Contract
    {
        // fields
        private int contractID;
        private Employee employee;
        private string jobTitle;
        private int workHoursPerWeek;
        private double salaryPerHour;
        private DateTime startDate;
        private DateTime endDate;
        private string reasonForTermination;
        private string department;

        // properties
        public int ContractID { get; set; }
        public Employee Employee { get; set; }
        public string JobTitle { get; set; }
        public int WorkHoursPerWeek { get; set; }
        public double SalaryPerHour { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ReasonForTermination { get; set; }
        public string Department { get; set; }

        // constructor
        public Contract(Employee employee, string jobTitle, int workHoursPerWeek, double salaryPerHour, DateTime startDate, DateTime endDate, string department)
        {
            this.Employee = employee;
            this.JobTitle = jobTitle;
            this.WorkHoursPerWeek = workHoursPerWeek;
            this.SalaryPerHour = salaryPerHour;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ReasonForTermination = null;
            this.Department = department;
        }

        public void EndContract(string reasonForTermination, DateTime endDate)
        {
            this.ReasonForTermination = reasonForTermination;
            this.EndDate = endDate;
        }
    }
}

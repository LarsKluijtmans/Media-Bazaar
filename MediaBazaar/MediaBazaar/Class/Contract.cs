using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Contract
    {
        // fields
        private int contractID;
        private int employeeID;
        private string jobTitle;
        private int workHoursPerWeek;
        private int salaryPerHour;
        private string startDate;
        private string endDate;
        private string reasonForTermination;

        // properties
        public int ContractID { get; set; }
        public int EmployeeID { get; set; }
        public string JobTitle { get; set; }
        public int WorkHoursPerWeek { get; set; }
        public int SalaryPerHour { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ReasonForTermination { get; set; }

        // constructor
        public Contract(int employeeID, string jobTitle, int workHoursPerWeek, int salaryPerHour, string startDate)
        {
            this.ContractID = contractID;
            this.EmployeeID = employeeID;
            this.JobTitle = jobTitle;
            this.WorkHoursPerWeek = workHoursPerWeek;
            this.SalaryPerHour = salaryPerHour;
            this.StartDate = startDate;
            this.EndDate = null;
            this.ReasonForTermination = null;
        }

        public void EndContract(string reasonForTermination, string endDate)
        {
            this.ReasonForTermination = reasonForTermination;
            this.EndDate = endDate;
        }
    }
}

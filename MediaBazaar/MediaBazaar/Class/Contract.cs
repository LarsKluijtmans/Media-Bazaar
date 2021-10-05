using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Contract
    {
        // fields
        private DateTime startDate;
        private DateTime endDate = new DateTime(9999, 12, 31);
        private double salaryPerHour;
        private int workHoursPerWeek;
        private string reasonForTermination;

        // properties
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double SalaryPerHour { get; set; }
        public int WorkHoursPerWeek { get; set; }
        public string ReasonForTermination { get; set; }

        // constructor
        public Contract(int year, int month, int day, double salaryPerHour, int workHoursPerWeek)
        {
            this.StartDate = new DateTime(year, month, day);
            this.SalaryPerHour = salaryPerHour;
            this.WorkHoursPerWeek = workHoursPerWeek;
            this.ReasonForTermination = null;
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
    }
}

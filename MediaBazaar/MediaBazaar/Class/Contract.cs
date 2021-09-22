using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Contract
    {
        private JobTitle jobTitle;
        private string floor;
        private int workHoursPerWeek;
        private int salaryPerHour;
        private DateTime startDate;
        private DateTime endDate;
        private string reasonForTermination;

        public Contract(JobTitle jobTitle, string Floor, int WorkHours,
            int Salary, DateTime StartDate, DateTime EndDate, string ReasonForTermination)
        {
            this.jobTitle = jobTitle;
            floor = Floor;
            workHoursPerWeek = WorkHours;
            salaryPerHour = Salary;
            startDate = StartDate;
            endDate = EndDate;
            reasonForTermination = ReasonForTermination;
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

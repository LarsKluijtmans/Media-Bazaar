using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Contract
    {
        private int employeeId;
        private Jobs jobTitle;
        private string floor;
        private int workHoursPerWeek;
        private int salaryPerHour;
        private DateTime startDate;
        private DateTime endDate;
        private string reasonForTermination;
        
        public Contract (int EmployeeID, Jobs Job, String Floor, int WorkHours,
            int Salary, DateTime StartDate, DateTime EndDate, string ReasonForTermination)
        {
            employeeId = EmployeeID;
            jobTitle = Job;
            floor = Floor;
            workHoursPerWeek = WorkHours;
            salaryPerHour = Salary;
            startDate = StartDate;
            endDate = EndDate;
            reasonForTermination = ReasonForTermination;
        }

        public void EndContract( string ReasonForTermination, DateTime EndDate) 
        {
            reasonForTermination = ReasonForTermination;
            endDate = EndDate;
        }

        public void EndContract(string ReasonForTermination)
        {
            reasonForTermination = ReasonForTermination;;
        }
    }
}

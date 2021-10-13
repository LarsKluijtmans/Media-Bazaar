using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class ContractManagement
    {
        // fields

        // sql
        public static string CREATE_CONTRACT = "INSERT INTO Contract (JodTitle, WorkHoursPerWeek, SalaryPerHour, StartDate) VALUES (@JobTitle, @WorkHoursPerWeek, @SalaryPerHour, @StartDate);";
        public static string GET_ALL_CONTRACTS = "SELECT * FROM Contract ORDER BY EmployeeID;";
        public static string UPDATE_CONTRACT = "UPDATE Contract SET JodTitle = @JobTitle, WorkHoursPerWeek = @WorkHoursPerWeek, SalaryPerHour = @SalaryPerHour, StartDate = @StartDate;";
        public static string DELETE_CONTRACT_BY_ID = "DELETE FROM Contract WHERE EmployeeID = @EmployeeID";

        // properties

        // constructor
        public ContractManagement()
        {

        }

        // methods
    }
}

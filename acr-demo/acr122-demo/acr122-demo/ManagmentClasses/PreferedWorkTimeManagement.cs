using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class PreferedWorkTimeManagement
    {
        // sql
        public static string CREATE_PWT = "INSERT INTO WorkPreference (EmployeeID, Prefered, Day, Time) VALUES (@EmployeeID, @Prefered, @Day, @Time) WHERE EmployeeID = @EmployeeID;";
        public static string GET_ALL_PWT = "SELECT * FROM WorkPreference ORDER BY EmployeeID;";
        public static string UPDATE_PWT = "UPDATE WorkPreference SET Day = @Day, Time = @Time, Prefered = @Prefered WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_PWT_BY_ID = "DELETE FROM WorkPreference WHERE EmployeeID = @EmployeeID";

        public static string VIEW_PWT_BY_ID = "SELECT * FROM WorkPreference WHERE EmployeeID = @EmployeeID;";

        // constructor
        public PreferedWorkTimeManagement()
        {

        }
        // methods
    }
}

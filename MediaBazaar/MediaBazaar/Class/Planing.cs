namespace MediaBazaar.Class
{
    class Planing
    {

        private int workID;
        private string department;
        private int employeeID;
        private string day;
        private string time;

        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public int WorkID
        {
            get { return workID; }
            set { workID = value; }
        }


        public Planing(int WorkID, string Department, int EmployeeID, string Day, string Time)
        {
            workID = WorkID;
            department = Department;
            employeeID = EmployeeID;
            day = Day;
            time = Time;
        }

        public override string ToString() 
        {
            return $" workID: {workID}  department: {department}  employeeID: {employeeID}  day: {day}  time: {time}";
        }
    }
}

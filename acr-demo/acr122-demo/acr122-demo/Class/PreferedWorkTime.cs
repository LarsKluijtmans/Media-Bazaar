namespace ClassLibraryProject.Class
{
    public class PreferedWorkTime
    {
        //fields
        private int preferedID;
        private int employeeID;
        private bool prefered;
        private string day;
        private string time;



        //properties
        public int PreferedID
        {
            get { return preferedID; }
            set { preferedID = value; }
        }

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public bool Prefered
        {
            get { return prefered; }
            set { prefered = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Day
        {
            get { return day; }
            set { day = value; }
        }


        //constructor
        public PreferedWorkTime(int employeeId, string time, string day)
        {
            this.EmployeeID = employeeId;
            this.Time = time;
            this.Day = day;
            this.Prefered = true;
        }


        //methods
        public override string ToString()
        {
            return "  ID: " + PreferedID + "   EmployeeID: " + employeeID + "   prefered: " + prefered + "   day: " + day + "   time: " + time;
        }
    }
}

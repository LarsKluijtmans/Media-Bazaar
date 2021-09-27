namespace MediaBazaar.Class
{
    class PreferedWorkTime
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
        public PreferedWorkTime(int PreferedID, string Time, string Day, int EmployeeId, bool Prefered)
        {
            preferedID = PreferedID;
            time = Time;
            day = Day;
            employeeID = EmployeeId;
            prefered = Prefered;
        }


        //methods
        public override string ToString()
        {
            return "  ID: " + PreferedID + "   EmployeeID: " + employeeID + "   prefered: " + prefered + "   day: " + day + "   time: " + time;
        }
    }
}

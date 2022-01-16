namespace ClassLibraryProject.Class
{
    public class PreferedWorkTime
    {
        //fields
        private int preferedID;
        private int employeeID;
        private bool prefered;
        private string day;
        private string shift;



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

        public string Shift
        {
            get { return shift; }
            set { shift = value; }
        }

        public string Day
        {
            get { return day; }
            set { day = value; }
        }


        //constructor
        public PreferedWorkTime(bool prefered, string time, string day)
        {
            this.Prefered = prefered;
            this.Shift = shift;
            this.Day = day;
            this.Prefered = true;
        }

        public PreferedWorkTime(string shift, string day)
        {
            this.Shift = shift;
            this.Day = day;
        }

        //methods
        public override string ToString()
        {
            return "  ID: " + PreferedID + "   EmployeeID: " + employeeID + "   prefered: " + prefered + "   day: " + day + "   time: " + Shift;
        }
    }
}

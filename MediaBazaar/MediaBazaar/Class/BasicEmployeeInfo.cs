namespace MediaBazaar.Class
{
    public class BasicEmployeeInfo
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private string jobTitle;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public BasicEmployeeInfo(int EmployeeID, string Lastname, string Firstname, string JobTitle)
        {
            employeeID = EmployeeID;
            lastName = Lastname;
            firstName = Firstname;
            jobTitle = JobTitle;
        }
        // methodes
        public override string ToString()
        {
            return $"ID: {employeeID}   Name: {firstName} {lastName}  Job: {jobTitle}";
        }

    }
}

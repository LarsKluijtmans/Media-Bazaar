namespace MediaBazaar.Class
{
    class BasicEmployeeInfo
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private string jodTitle;

        public int  EmployeeID
        {
            get { return employeeID;  }
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

        public string JodTitle
        {
            get { return jodTitle; }
            set { jodTitle = value; }
        }

        public BasicEmployeeInfo(int EmployeeID, string Lastname, string Firstname, string JodTitle)
        {
            employeeID = EmployeeID;
            lastName = Lastname;
            firstName = Firstname;
            jodTitle = JodTitle;
        }
        // methodes
        public override string ToString()
        {
            return $"ID: {employeeID}   Name: {firstName} {lastName}  Job: {jodTitle}";
        }

    }
}

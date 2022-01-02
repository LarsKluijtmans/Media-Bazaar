using ClassLibraryProject.Class;

namespace ClassLibraryProject.ChildClasses
{
    public class DepotManager : Employee
    {
        public DepotManager() : base()
        { }
        public DepotManager(int employeeID, string lastname, string firstname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
            : base(employeeID, lastname, firstname, phonenumber, email, city, dateofbirth, bsn, username, password)
        {

        }
    }
}

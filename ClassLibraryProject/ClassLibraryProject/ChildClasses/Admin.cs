using ClassLibraryProject.Class;

namespace ClassLibraryProject.ChildClasses
{
    public class Admin : Employee
    {
        public Admin() : base()
        { }

        public Admin(int employeeID, string lastname, string firstname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password) 
            : base (employeeID, lastname, firstname, phonenumber, email, city, dateofbirth, bsn, username, password)
        {

        }
    }
}

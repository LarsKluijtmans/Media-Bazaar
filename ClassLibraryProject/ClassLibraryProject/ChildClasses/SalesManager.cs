using ClassLibraryProject.Class;

namespace ClassLibraryProject.ChildClasses
{
   public class SalesManager : Employee
    {
        public SalesManager() : base()
        { }
        public SalesManager(int employeeID, string lastname, string firstname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
       : base(employeeID, lastname, firstname, phonenumber, email, city, dateofbirth, bsn, username, password)
        {

        }
    }
}

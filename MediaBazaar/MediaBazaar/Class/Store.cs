using MediaBazaar.Class.ManagmentClasses;
namespace MediaBazaar.Class
{
    public class Store
    {
        public ProductManagment productManagment;
        public RestockManagment rectockManagment;
        public ReshelfManagment reshelfManagment;
        public ScheduleManagment scheduleManagment;
        public PlaningManagment planingManagment;
        public LoginManagment loginManagment;
        //public EmployeeManagment employeeManagment;
        //public ContractManagment contractManagment;
        //public check

        public Store()
        {
            productManagment = new ProductManagment();
            rectockManagment = new RestockManagment();
            reshelfManagment = new ReshelfManagment();
            scheduleManagment = new ScheduleManagment();
            planingManagment = new PlaningManagment();
            loginManagment = new LoginManagment();
            //employeeManagment = new employeeManagment();
            //contractManagment = new contractManagment();
        }
    }
}

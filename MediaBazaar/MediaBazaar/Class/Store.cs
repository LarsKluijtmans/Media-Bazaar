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
        public DepartmentManagment departmentManagment;
        public CompanyManagment companyManagment;
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
            departmentManagment = new DepartmentManagment();
            companyManagment = new CompanyManagment();
            //employeeManagment = new employeeManagment();
            //contractManagment = new contractManagment();
        }
    }
}

using ClassLibraryProject.ManagmentClasses;

namespace ClassLibraryProject.Class
{
    public class Store
    {
        public ProductManagment productManagment;
        public RestockManagment restockManagment;
        public ReshelfManagment reshelfManagment;
        public ScheduleManagment scheduleManagment;
        public PlanningManagment planningManagment;
        public LoginManagment loginManagment;
        public DepartmentManagment departmentManagment;
        public CompanyManagment companyManagment;
        public CheckinManagment checkinManagment;
        public EmployeeManagement employeeManagement;
        public SupplierManagment supplierManagment;
        public OrderInfoManagment orderInfoManagment;

        //public EmployeeManagment employeeManagment;
        //public ContractManagment contractManagment;

        public Store()
        {
            productManagment = new ProductManagment();
            restockManagment = new RestockManagment();
            reshelfManagment = new ReshelfManagment();
            scheduleManagment = new ScheduleManagment();
            planningManagment = new PlanningManagment();
            loginManagment = new LoginManagment();
            departmentManagment = new DepartmentManagment();
            companyManagment = new CompanyManagment();
            checkinManagment = new CheckinManagment();
            employeeManagement = new EmployeeManagement();
            supplierManagment = new SupplierManagment();
            orderInfoManagment = new OrderInfoManagment();
            //employeeManagment = new employeeManagment();
            //contractManagment = new contractManagment();
        }
    }
}

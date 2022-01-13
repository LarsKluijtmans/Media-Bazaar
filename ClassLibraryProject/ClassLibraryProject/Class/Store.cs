using ClassLibraryProject.dbClasses;
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
        public EmployeeManagement employeeManagement;
        public SupplierManagment supplierManagment;
        public OrderInfoManagment orderInfoManagment;
        public EmailManager emailManager;
        public BackUpManagment backUpManagment;

        public Store()
        {
            productManagment = new ProductManagment();
            //restockManagment = new RestockManagment();
            //reshelfManagment = new ReshelfManagment();
            //scheduleManagment = new ScheduleManagment();
            //planningManagment = new PlanningManagment();
            employeeManagement = new EmployeeManagement();
            //supplierManagment = new SupplierManagment();
            //orderInfoManagment = new OrderInfoManagment();


            //Dont need interface
            emailManager = new EmailManager();
            backUpManagment = new BackUpManagment();
        }
    }
}

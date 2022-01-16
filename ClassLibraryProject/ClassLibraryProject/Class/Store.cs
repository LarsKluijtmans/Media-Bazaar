using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses;

namespace ClassLibraryProject.Class
{
    public class Store
    {
        public ProductManagement productManagment;
        public RestockManagment restockManagment;
        public ReshelfManagment reshelfManagment;
        public ScheduleManagment scheduleManagment;
        public PlanningManagment planningManagment;
        public EmployeeManagement employeeManagement;
        public SupplierManagment supplierManagment;
        public EmailManager emailManager;
        public BackUpManagment backUpManagment;

        public Store()
        {
            productManagment = new ProductManagement();
            //restockManagment = new RestockManagment();
            //reshelfManagment = new ReshelfManagment();
           // scheduleManagment = new ScheduleManagment();
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

using System.Data;

namespace ClassLibraryProject.Interfaces
{
   public interface IDepartmentManagment
    {
        //Get all departments
        public DataTable ViewAllDepartments();


        //Add a new department
        public void AddDepartment(string Name, string Head, string CompanyID);

        // edit a department
        public void EditDepartment(string Name, string Head, string DepartmetnID);

        //Delete
        public void DeleteDepartment(int departmentID);
    }
}

namespace MediaBazaar.Class.ManagmentClasses
{
    class CompanyManagment
    {
        public static string GET_COMPANY = "SELECT contract.EmployeeID, contract.JodTitle, jobs.DepartmentID, companyName FROM `EMPLOYEE` INNER JOIN contract ON employee.EmployeeID = contract.EmployeeID INNER JOIN jobs ON jobs.JobTitle = contract.JodTitle INNER JOIN departments ON departments.DepartmentID = jobs.DepartmentID INNER JOIN company ON company.ComapnyID = departments.CompanyID;";



}
}

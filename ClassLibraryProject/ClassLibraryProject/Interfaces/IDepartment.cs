﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
  public interface IDepartment
    {  
        public DataTable ViewAllDepartments();

        public void AddDepartment(string Name, string Head, string CompanyID);

        public void EditDepartment(string Name, string Head, string DepartmetnID);

        public void DeleteDepartment(int departmentID);
    }
}

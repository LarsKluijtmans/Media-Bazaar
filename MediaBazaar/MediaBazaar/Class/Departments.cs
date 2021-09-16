using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    abstract class Departments
    {
        protected Store store;
        private int deprtmentID;
        private string departmentName;

        public Departments(int DeprtmentID, string DepartmentName)
        {
            deprtmentID = DeprtmentID;
            departmentName = DepartmentName;
        }
    }
}

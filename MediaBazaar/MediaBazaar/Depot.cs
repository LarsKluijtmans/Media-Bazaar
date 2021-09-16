using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Depot : Departments
    {
        public Depot(int DeprtmentID, string DepartmentName) : base(DeprtmentID, DepartmentName)
        {
            
        }

        public void RequestRestock(int amount, Porduct p)
        {


        }
    }
}

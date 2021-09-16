using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Sales: Departments
    {
        private int Floor;

        public Sales(int floor, int DeprtmentID, string DepartmentName) : base(DeprtmentID, DepartmentName) 
        {
            Floor = floor;
        }

        public void RequestProduct( /*Product p ,*/ int Amount)
        {
            /* Send product and amount to the Depot department*/ 
        }
    }
}

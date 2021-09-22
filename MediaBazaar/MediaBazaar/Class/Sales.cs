using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Sales: Departments
    {
        private int Floor;

        public Sales(int floor, int DeprtmentID, string DepartmentName) : base(DeprtmentID, DepartmentName) 
        {
            Floor = floor;
        }
    }
}

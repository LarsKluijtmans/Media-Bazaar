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

        public void RequestRequest( int ProductID, int Amount)
        {
            int amount = Amount;
            int productID = ProductID;

            foreach (Product p in store.Products)
            {
               if( p.ProductId == productID)
                {
                    Depot.porductRequests.Add(p);
                }

            }
        }
    }
}

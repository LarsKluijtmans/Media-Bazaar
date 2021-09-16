using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Depot : Departments
    {
        private List<Product> porductRequests;
        private List<Product> porductRestock;

        public Depot(int DeprtmentID, string DepartmentName) : base(DeprtmentID, DepartmentName)
        {
            porductRequests = new List<Product>();
            porductRestock = new List<Product>();
        }

        public void RequestRestock(int amount, Product p)
        {
            p.Amount = amount;

            porductRestock.Add(p);
        }

        public void ViewRestockRequest()
        {

        }
        public void ViewPorductRequests()
        {

        }

        public void FinishporductRequests( Product product)
        {
            foreach (Product p in store.product)
            { 
                if(product.Name == p.name)
                {
                    if (product.Amount > p.Amount)
                    {
                        p.Amount -= product.Amount;
                        /*Listbox.items.add("There are only "+ p.amount + p.name + "s left.")*/
                    }
                    else
                    {
                        /* listbox .clear*/
                        /* Listbox.add("There is not enough of this product in stock at the moment")*/
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Depot : Departments
    {
        private List<Product> productRequests;
        private List<Product> productRestock;

        public Depot(int DeprtmentID, string DepartmentName) : base(DeprtmentID, DepartmentName)
        {
            productRequests = new List<Product>();
            productRestock = new List<Product>();
        }

        public void RequestRestock(int amount, Product p)
        {
            p.Amount = amount;

            productRestock.Add(p);
        }

        public string FinishporductRequests( Product product)
        {
            foreach (Product p in store.Products)
            { 
                if(product.Name == p.Name)
                {
                    if (product.Amount > p.Amount)
                    {
                        p.Amount -= product.Amount;
                        return "There are only " + p.Amount +" "+ p.Name + "s left.";
                    }
                    else
                    {
                        return "There is not enough of this product in stock at the moment";
                    }
                }
                return "";
            }
            return "";
        }
    }
}

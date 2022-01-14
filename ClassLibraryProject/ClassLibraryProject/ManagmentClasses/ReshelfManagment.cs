using ClassLibraryProject.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using ClassLibraryProject.ManagmentClasses.ISalesEmployee;
using ClassLibraryProject.dbClasses.IDB;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ReshelfManagment : IReshelfDepotEmployee, IReshelfSalesEmployee
    {
        private List<int> numbers = new List<int>();
        public int id()
        {
            int n = 1;
            Random random = new Random();
            for (int i = 1000; i < 9999; i++)
            {
                numbers.Add(i);
            }
            foreach (int i in numbers)
            {
                n = random.Next(numbers.Count);
                if (i == numbers[n])
                {
                    return i;
                }
            }
            return n;
        }

        private IDBReshelf db;

        public ReshelfManagment(IDBReshelf dbReshelf)
        {
            db = dbReshelf;
        }

        //depot employee
        public List<Reshelf> GetReshelfRequests()
        {
            return db.GetReshelfRequests();
        }
        public bool CompleteReshelf(int id, Product product)
        {
            if (ReshelfByIDExist(id))
            {
                if (db.CompleteReshelf(id))
                {
                    int newAmount = product.AmountInDepot + GetReshelfByID(id).AmountRequested;
                    db.ChangeAmount(product, newAmount);

                    return true;
                }
                return false;
            }
            return false;
        }

        public bool DeleteReshelf(int id)
        {
            if (ReshelfByIDExist(id))
            {
                if (db.DeleteReshelf(id))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //sales employee
        public Product GetProduct(string barcode)
        {
            return db.GetProduct(barcode);
        }
        public bool RequestReshelf(Product product, int amount)
        {
            if (!ReshelfExist(product))
            {
                if (db.RequestReshelf(id(), product, amount))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //check
        private Reshelf GetReshelf(Product product)
        {
            foreach (Reshelf reshelf in db.GetReshelfRequests())
            {
                if (reshelf.Product == product && reshelf.Status == "Pending")
                {
                    return reshelf;
                }
            }
            return null;
        }
        private Reshelf GetReshelfByID(int id)
        {
            foreach (Reshelf reshelf in db.GetReshelfRequests())
            {
                if (reshelf.ID == id)
                {
                    return reshelf;
                }
            }
            return null;
        }
        public bool ReshelfExist(Product product)
        {
            if (GetReshelf(product) != null)
            {
                return true;
            }
            return false;
        }
        private bool ReshelfByIDExist(int id)
        {
            if (GetReshelfByID(id) != null)
            {
                return true;
            }
            return false;
        }
    }
}

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
        public bool RequestReshelf(int id, Product product, int amount)
        {
            if (ReshelfExist(product))
            {
                if (db.RequestReshelf(id, product, amount)
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
                if (reshelf.Product == product && reshelf.Status == "Pending" || reshelf.Status == "Ordered")
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
        private bool ReshelfExist(Product product)
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

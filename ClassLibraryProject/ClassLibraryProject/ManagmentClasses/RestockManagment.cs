using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using ClassLibraryProject.ManagmentClasses.IDepotManager;
using System.Collections.Generic;

namespace ClassLibraryProject.ManagmentClasses
{
    public class RestockManagment: IRestockDepotManager, IRestockDepotEmployee 
    {
        private IDBRestock db;

        public RestockManagment(IDBRestock dbRestock)
        {
            db = dbRestock;
        }

        //manager
        public bool OrderRestock(int id, int amount)
        {
            if (RestockByIDExist(id))
            {
                if(db.OrderRestock(id, amount) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public List<Restock> GetAllRestockRequests()
        {
            return db.GetRestockRequests();
        }
        public bool DeleteRestock(int id)
        {
            if (RestockByIDExist(id))
            {
                if (db.DeleteRestock(id) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //employee
        public List<Restock> GetOrderedRestockRequests()
        {
            List<Restock> restocks = new List<Restock>();

            foreach(Restock restock in db.GetRestockRequests())
            {
                if(restock.Status == "Ordered")
                {
                    restocks.Add(restock);
                }
            }
            return restocks;
        }    
        public bool RequestRestock(int id, Product product)
        {
            if (RestockExist(product))
            {
                if (db.RequestRestock(id, product) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool ReceiveRestock(int id, Product product)
        {
            if (RestockExist(product))
            {
                if (db.ReceiveRestock(id) == true)
                {
                    int newAmount = product.AmountInDepot + GetRestockByID(id).AmountRequested;
                    db.ChangeAmount(product, newAmount);
                    return true;
                }
                return false;
            }
            return false;
        }

        //check
        private Restock GetRestock(Product product)
        {
            foreach(Restock restock in db.GetRestockRequests())
            {
                if(restock.Product == product && restock.Status == "Pending" || restock.Status == "Ordered")
                {
                    return restock;
                }
            }
            return null;
        }
        private Restock GetRestockByID(int id)
        {
            foreach (Restock restock in db.GetRestockRequests())
            {
                if (restock.ID == id)
                {
                    return restock;
                }
            }
            return null;
        }
        private bool RestockExist(Product product)
        {
            if (GetRestock(product) != null)
            {
                return true;
            }
            return false;
        }
        private bool RestockByIDExist(int id)
        {
            if (GetRestockByID(id) != null)
            {
                return true;
            }
            return false;
        }  
    }
}

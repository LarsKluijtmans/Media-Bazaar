using System;
using System.Collections.Generic;
using System.Data;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using ClassLibraryProject.ManagmentClasses.IProductManager;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.ManagmentClasses
{
    public class SupplierManagment: ISupplierProductManager, IGetSupplier
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
                    numbers.Remove(i);
                    return i;
                }
            }
            return n;
        }

        private IDBSupplierManager db;

        public SupplierManagment(IDBSupplierManager dbSupplier)
        {
            db = dbSupplier;
        }

        public List<Supplier> GetSuppliers()
        {
            return db.GetSuppliers();
        }
        public bool AddSupplier(Supplier s)
        {
            return false;
        }
        public bool DeleteSupplier(Supplier s)
        {
            return false;
        }
        public bool UpdateSupplier(Supplier s)
        {
            
            return false;
        }

        private Supplier GetSupplierByName(string name)
        {
            foreach(Supplier supplier in db.GetSuppliers())
            {
                if(supplier.Name == name)
                {
                    return supplier;
                }
            }
            return null;
        }
        public Supplier GetSupplier(int id)
        {
            foreach (Supplier supplier in db.GetSuppliers())
            {
                if (supplier.ID == id)
                {
                    return supplier;
                }
            }
            return null;
        }
        private bool SupplierExist(string name)
        {
            if (GetSupplierByName(name) != null)
            {
                return true;
            }
            return false;
        }
        private bool SupplierExistByID(int id)
        {
            if (GetSupplier(id) != null)
            {
                return true;
            }
            return false;
        }

        public List<Supplier> GetSuppliersForProduct(Product p)
        {
            throw new NotImplementedException();
        }
    }
}

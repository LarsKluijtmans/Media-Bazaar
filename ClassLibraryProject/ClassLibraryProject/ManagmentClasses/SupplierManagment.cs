using System;
using System.Collections.Generic;
using System.Data;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses.IProductManager;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.ManagmentClasses
{
    public class SupplierManagment: ISupplierProductManager
    {
        private IDBSupplier db;

        public SupplierManagment(IDBSupplier dbSupplier)
        {
            db = dbSupplier;
        }

        public List<Supplier> GetSuppliers()
        {
            return db.GetSuppliers();
        }
        public bool AddSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber)
        {
            if (SupplierExist(name) == false)
            {
                if(db.AddSupplier(id, name, country, buildingNumber, postalCode, email, phoneNumber, bankNumber) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool DeleteSupplier(int id)
        {
            if (SupplierExistByID(id) == false)
            {
                if (db.DeleteSupplier(id) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool UpdateSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber)
        {
            if (SupplierExistByID(id) == false)
            {
                if (db.UpdateSupplier(id, name, country, buildingNumber, postalCode, email, phoneNumber, bankNumber) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        private Supplier GetSupplier(string name)
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
        private Supplier GetSupplierByID(int id)
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
            if (GetSupplier(name) != null)
            {
                return true;
            }
            return false;
        }
        private bool SupplierExistByID(int id)
        {
            if (GetSupplierByID(id) != null)
            {
                return true;
            }
            return false;
        }
    }
}

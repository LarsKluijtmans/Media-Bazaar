using System;
using System.Collections.Generic;
using System.Data;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using ClassLibraryProject.ManagmentClasses.IProductManager;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.ManagmentClasses
{
    public class SupplierManagment: ISupplierManagerPM, IGetSupplier
    {
        IDBSupplierManagerPM DBSupplierManagerPM { get; set; }

        public SupplierManagment()
        {
            this.DBSupplierManagerPM = new DBSupplierManager();
        }

        public List<Supplier> GetSuppliers()
        {
            return null;
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

        public Supplier GetSupplier(int id)
        {
            return null;
        }
        

        public List<Supplier> GetSuppliersForProduct(Product p)
        {
            return DBSupplierManagerPM.GetSuppliersForProduct(p);
        }
    }
}

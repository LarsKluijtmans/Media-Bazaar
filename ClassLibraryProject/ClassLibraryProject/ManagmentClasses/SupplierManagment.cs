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

        public List<Supplier> ReadSuppliers()
        {
            return DBSupplierManagerPM.ReadSuppliers();
        }
        public bool CreateSupplier(Supplier s)
        {
            return DBSupplierManagerPM.CreateSupplier(s);
        }
        public bool DeleteSupplier(Supplier s)
        {
            return false;
        }
        public bool UpdateSupplier(Supplier s)
        {
            
            return false;
        }

        public Supplier GetSupplierByID(int id)
        {
            return null;
        }
        

        public List<Supplier> GetSuppliersForProduct(Product p)
        {
            return DBSupplierManagerPM.GetSuppliersForProduct(p);
        }
    }
}

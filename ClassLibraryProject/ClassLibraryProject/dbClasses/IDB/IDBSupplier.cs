using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBSupplier
    {
        List<Supplier> GetSuppliers();
        bool AddSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber);
        bool UpdateSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber);
        bool DeleteSupplier(int id);
    }
}

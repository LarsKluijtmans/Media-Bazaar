using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBSupplierManager
    {
        List<Supplier> GetSuppliers();
        bool AddSupplier(Supplier s);
        bool UpdateSupplier(Supplier s);
        bool DeleteSupplier(Supplier s);
        List<Supplier> GetSuppliersForProduct(Product p);
    }
}

using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ProductManagment: IGetProduct
    {

        

        public Product GetProduct(string barcode)
        {
            throw new NotImplementedException();
        }
    }
}

using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IGetObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ProductManagment : IGetProduct, IProductManagerPM, IProductManagerSM
    {
        public IDBProductManagerPM DBProductManagerPM { get; set; }
        public IDBProductManagerSM DBProductManagerSM { get; set; }

        public ProductManagment()
        {
            this.DBProductManagerPM = new DBProductManager();
            this.DBProductManagerSM = new DBProductManager();
        }
        /* Esther Start */
        /* Product Manager */
        public bool CreateProduct(Product p)
        {
            return DBProductManagerPM.CreateProduct(p);
        }

        public bool DeleteProduct(Product p)
        {
            return DBProductManagerPM.DeleteProduct(p);
        }

        public List<Product> ReadProductsPM()
        {
            return DBProductManagerPM.ReadProductsPM();
        }

        public List<Product> SearchProductsPM(string search)
        {
            return DBProductManagerPM.SearchProductsPM(search);
        }

        public bool UpdateProduct(Product p)
        {
            return DBProductManagerPM.UpdateProduct(p);
        }
        /* Esther End */


        public Product GetProduct(string barcode)
        {
            throw new NotImplementedException();
        }
    }
}

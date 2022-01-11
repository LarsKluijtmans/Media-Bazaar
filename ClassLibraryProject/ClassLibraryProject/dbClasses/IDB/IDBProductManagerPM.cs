using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IDBProductManagerPM
    {
        public bool CreateProduct(Product p);
        public List<Product> ReadProductsPM();
        public bool UpdateProduct(Product p);
        public bool DeleteProduct(Product p);
        public List<Product> SearchProductsPM(string search);
        public Product GetProductByID(int productID);
    }
}

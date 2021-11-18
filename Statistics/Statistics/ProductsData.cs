using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class ProductsData
    {
        private int productID;
        private int amount;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public ProductsData(int productID, int amount)
        {
            ProductID = productID;
            Amount = amount;
        }
    }
}

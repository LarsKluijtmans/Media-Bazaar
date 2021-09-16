using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Product
    {
        private static int productId;
        private string barcode;
        private string name;
        private ProductType type;
        private int amount;

        // properties
        public static int ProductId { get; set; }

        // constructor
        public Product(string barcode, string name, ProductType type, int amount)
        {
            this.barcode = barcode;
            this.name = name;
            this.type = type;
            this.amount = amount;
        }
        // methods

    }
}

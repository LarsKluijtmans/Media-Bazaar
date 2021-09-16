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
        public string Barcode { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public int Amount { get; set; }
        // constructor
        public Product(string barcode, string name, ProductType type, int amount)
        {
            this.barcode = barcode;
            this.name = name;
            this.type = type;
            this.amount = amount;
        }
        // methods
        public void IncreaseProductAmount(int amount, Product p)
        {
            this.amount = amount;
        }
        public void DecreaseProductAmount(int amount, Product p)
        {
            this.amount = amount;
        }
        public override string ToString()
        {
            return null;
        }
    }
}

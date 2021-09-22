using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Product
    {
        private int productId;
        private static int nextProductID = 1;
        private string barcode;
        private string name;
        private ProductType type;
        private int amount;


        // properties
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public int Amount { get; set; }
        // constructor
        public Product(string barcode, string name, ProductType type, int amount)
        {
            this.productId = nextProductID;
            this.barcode = barcode;
            this.name = name;
            this.type = type;
            this.amount = amount;

            nextProductID++; 
        }
        public override string ToString()
        {
            return $"ID: {productId}, name: {name}, type: {type}, amount: {amount}, barcode: {barcode}";
        }
    }
}

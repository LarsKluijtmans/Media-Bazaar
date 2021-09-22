using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Product
    {
        //fields
        private int productID;
        private static int counter = 1;
        private string barcode;
        private string name;
        private ProductType productType;
        private int amount;


        //properties
        public int ProductID 
        {
            get { return productID; }
            set { productID = value; }
        }
        public string Barcode 
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ProductType ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }


        //constructor
        public Product(string barcode, string name, ProductType type, int amount)
        {
            ProductID = counter;
            Barcode = barcode;
            Name = name;
            ProductType = type;
            Amount = amount;

            counter++; 
        }


        //methods
        public override string ToString()
        {
            return $"ID: {ProductID}, name: {Name}, type: {ProductType}, amount: {Amount}, barcode: {Barcode}";
        }
    }
}

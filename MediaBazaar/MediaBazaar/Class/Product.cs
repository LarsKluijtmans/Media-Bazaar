using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    public class Product
    {
        //fields
        private int productID;
        private string barcode;
        private string name;
        private string productType;
        private int amountInStore;
        private int amountInDepot;


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
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int AmountInStore
        {
            get { return amountInStore; }
            set { amountInStore = value; }
        }
        public int AmountInDepot
        {
            get { return amountInDepot; }
            set { amountInDepot = value; }
        }

        //constructor
        public Product(int ID, string name, string type, string barcode, int AmountInDepot, int AmountInStore)
        {
            ProductID = ID;
            Barcode = barcode;
            Name = name;
            ProductType = type;
            amountInDepot = AmountInDepot;
            amountInStore = AmountInStore;
        }


        //methods
        public override string ToString()
        {
            return "  ID: " + ProductID + "   Barcode: " + Barcode + "   Name: " + Name + "   Type: " + ProductType + "   Amount in depot: " + amountInDepot + "   Amoutn in store: " + AmountInStore;
        }
    }
}

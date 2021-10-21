using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class Product
    {
        //fields
        private int productID;
        private string barcode;
        private string name;
        private string productType;
        private int price;
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

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int AmountInDepot
        {
            get { return amountInDepot; }
            set { amountInDepot = value; }
        }

        //constructor
        public Product(int id, string name, string type, string barcode, int amountInDepot, int Price)
        {
            ProductID = id;
            Barcode = barcode;
            Name = name;
            ProductType = type;
            AmountInDepot = amountInDepot;
            price = Price;
        }


        //methods
        public override string ToString()
        {
            return "  ID: " + ProductID + "   Name: " + Name + "   Type: " + ProductType + "   Amount in depot: " + AmountInDepot;
        }
        public string GetInfoForSale()
        {
            return "  ID: " + ProductID + "   Barcode: " + Barcode + "   Name: " + Name + "   Type: " + ProductType + "   Amoutn in store: " + Price;
        }
        public string GetInfoForDepot()
        {
            return "  ID: " + ProductID + "   Barcode: " + Barcode + "   Name: " + Name + "   Type: " + ProductType + "   Amount in depot: " + AmountInDepot;
        }
    }
}

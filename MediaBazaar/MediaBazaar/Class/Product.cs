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
        private int shelfSpace;
        private int warehouseAmount;
        private int amountRequested;
        private int requestID;

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
        public ProductType ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int ShelfSpace
        {
            get { return shelfSpace; }
            set { shelfSpace = value; }
        }
        public int WarehouseAmount
        {
            get { return warehouseAmount; }
            set { warehouseAmount = value; }
        }
        public int AmountRequested
        {
            get { return amountRequested; }
            set { amountRequested = value; }
        }
        public int RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }

        //constructor
        public Product(string name, ProductType type , int maxAmount)
        {
            ProductID = counter;
            Barcode = type.ToString().Substring(0, 3) + ProductID;            
            Name = name;
            ProductType = type;
            ShelfSpace = maxAmount;
            Amount = ShelfSpace;
            WarehouseAmount = 1000;

            counter++;
        }

        //methods
        public override string ToString()
        {
            return "ID: " + ProductID + " Name: " + Name + " Amount: " + Amount + " Shelf Space: " + ShelfSpace;
        }
        public string GetInfo()
        {
            return "ID: " + ProductID + " Barcode: " + Barcode + " Name: " + Name + " Type: " + ProductType;
        }
        public string RequestInfo()
        {
            return "RequestID: " + RequestID + ": "+ AmountRequested + " amount of " + Name;
        }
        public string WarehouseInfo()
        {
            return "Name: " + Name + " Amount left in Warehouse: " + WarehouseAmount;
        }
    }
}

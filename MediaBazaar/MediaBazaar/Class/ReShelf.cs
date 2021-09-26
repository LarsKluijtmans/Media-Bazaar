using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar.Class
{
    class ReShelf
    {
        private int shelfReplenishmentID;
        private int productID;
        private int amount;
        private string name;
        private int amountInStore;
        private int amountInDepot;


        public int ShelfReplenishmentID
        {
            get { return shelfReplenishmentID; }
            set { shelfReplenishmentID = value; }
        }
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
        public ReShelf(int ShelfReplenishmentID, int ProductID, int Amount, string name, int AmountInDepot, int AmountInStore)
        {
            Name = name;
            amountInDepot = AmountInDepot;
            amountInStore = AmountInStore;
            shelfReplenishmentID = ShelfReplenishmentID;
            productID = ProductID;
            amount = Amount;
        }


        public override string ToString()
        {
            return "ReshelfID: " + ShelfReplenishmentID + "   ProductID:" + ProductID + "   Amount :" + Amount + "   Name: " + Name + "   Amount in depot: " + amountInDepot + "   Amoutn in store: " + AmountInStore;
        }
    }
}

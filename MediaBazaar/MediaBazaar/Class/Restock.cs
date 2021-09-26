using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar.Class
{
    class Restock
    {
        private int restockReplenishmentID;
        private int productID;
        private int amount;
        private string name;
        private int amountInStore;
        private int amountInDepot;

        public int RestockReplenishmentID
        {
            get { return restockReplenishmentID; }
            set { restockReplenishmentID = value; }
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

        public Restock(int RestockReplenishmentID, int ProductID, int Amount, string Name, int AmountInStore, int AmountInDepot)
        {
            restockReplenishmentID = RestockReplenishmentID;
            productID = ProductID;
            name = Name;
            amountInDepot = AmountInDepot;
            amountInStore = AmountInStore;

            amount = Amount;
        }
        public override string ToString()
        {
            return "RestockID: " + restockReplenishmentID + "   ProductID:" + ProductID + "   Amount :" + Amount + "   Name: " + Name + "   Amount in depot: " + amountInDepot + "   Amoutn in store: " + AmountInStore;
        }
    }
}

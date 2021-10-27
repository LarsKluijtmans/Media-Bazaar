using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class Restock
    {
        private int restockReplenishmentID;
        private int productID;
        private string barcode;
        private int amountReceived;

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
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public int AmountReceived
        {
            get { return amountReceived; }
            set { amountReceived = value; }
        }

        public Restock(int restockReplenishmentID, int productID, string barcode, int amountInDepot, int amountReceived)
        {
            RestockReplenishmentID = restockReplenishmentID;
            ProductID = productID;
            Barcode = barcode;
            AmountReceived = amountReceived;
        }
    }
}

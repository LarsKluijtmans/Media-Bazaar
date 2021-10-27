
namespace ClassLibraryProject.Class
{
    public class Reshelf
    {
        private int reshelfReplinishmentID;
        private int productID;
        private string barcode;
        private int amountRequested;

        public int ReshelfReplenishmentID
        {
            get { return reshelfReplinishmentID; }
            set { reshelfReplinishmentID = value; }
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
        public int AmountRequested
        {
            get { return amountRequested; }
            set { amountRequested = value; }
        }

        public Reshelf(int restockReplenishmentID, int productID, string barcode, int amountInDepot, int amountRequested)
        {
            ReshelfReplenishmentID = restockReplenishmentID;
            ProductID = productID;
            Barcode = barcode;
            AmountRequested = amountRequested;
        }
    }
}

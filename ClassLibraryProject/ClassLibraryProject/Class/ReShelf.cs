
namespace ClassLibraryProject.Class
{
    public class Reshelf
    {
        private int id;
        //private Product product;
        private string barcode;
        private int productID;
        private int amountRequested;
        private string status;

        public int ID
        {
            get { return id; }
            set { id = value; }
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
        //public Product Product
        //{
        //    get { return product; }
        //    set { product = value; }
        //}
        public int AmountRequested
        {
            get { return amountRequested; }
            set { amountRequested = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Reshelf(int id, /*Product product*/string barcode, int productID, int amountRequested, string status)
        {
            ID = id;
            Barcode = barcode;
            ProductID = productID;
            //Product = product;
            AmountRequested = amountRequested;
            Status = status;
        }
    }
}

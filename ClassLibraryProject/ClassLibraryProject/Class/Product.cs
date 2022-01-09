
namespace ClassLibraryProject.Class
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

        private int sellingPrice;
        private bool isDiscontinued;


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

        public int SellingPrice { get; set; }
        public bool IsDiscontinued { get; set; }
        //constructor
        public Product(int id, string name, string type, string barcode, int sellingPrice)
        {
            ProductID = id;
            Barcode = barcode;
            Name = name;
            ProductType = type;
            AmountInDepot = 0;
            AmountInStore = 0;
            SellingPrice = sellingPrice;
            IsDiscontinued = false;
        }
        public Product(int id, string name, string type, string barcode, int sellingPrice, int amountInDepot, int amountInStore)
        {
            ProductID = id;
            Barcode = barcode;
            Name = name;
            ProductType = type;
            AmountInDepot = amountInDepot;
            AmountInStore = amountInStore;
            SellingPrice = sellingPrice;
            IsDiscontinued = false;
        }
        // methods
        public override string ToString()
        {
            return $"ID: {ProductID} - name:{Name}";
        }
    }
}

namespace ClassLibraryProject.Class
{
    public class OrderInfo
    {
        //fields
        private int id;
        private Supplier supplier;
        private Product product;
        private int minAmount;
        private int maxAmount;
        private int multiples;

        //properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Supplier Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public int MinAmount
        {
            get { return minAmount; }
            set { minAmount = value; }
        }
        public int MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; }
        }
        public int Multiples
        {
            get { return multiples; }
            set { multiples = value; }
        }

        //constructor
        public OrderInfo(int id, Supplier supplier, Product product, int minAmount, int maxAmount, int multiples)
        {
            ID = id;
            Supplier = supplier;
            Product = product;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            Multiples = multiples;
        }
    }
}

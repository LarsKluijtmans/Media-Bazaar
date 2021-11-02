namespace ClassLibraryProject.Class
{
    public class OrderInfo
    {
        private int orderInfoID;
        private int supplierID;
        private int productID;
        private int minAmount;
        private int maxAmount;
        private int multiples;

        public int OrderInfoID
        {
            get { return orderInfoID; }
            set { orderInfoID = value; }
        }
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
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
        public OrderInfo(int orderInfoID, int supplierID, int productID, int minAmount, int maxAmount, int multiples)
        {
            OrderInfoID = orderInfoID;
            SupplierID = supplierID;
            ProductID = productID;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            Multiples = multiples;
        }
    }
}

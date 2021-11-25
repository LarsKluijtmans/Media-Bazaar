using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class Restock
    {
        private int id;
        private Product product;
        private int amountReceived;
        private string status;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public int AmountReceived
        {
            get { return amountReceived; }
            set { amountReceived = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Restock(int id, Product product, int amountReceived, string status)
        {
            ID = id;
            Product = product;
            AmountReceived = amountReceived;
            Status = status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
{
    class Store
    {
        private List<Complaint> complaints;
        private List<Announcement> announcements;
        private List<Product> products;

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public Store()
        {
            complaints = new List<Complaint>();
            announcements = new List<Announcement>();
        }
        public void AddAnnouncement(Announcement a)
        {
            announcements.Add(a);
        }
        public Announcement GetAnnouncement(int id)
        {
            foreach(Announcement announcement in announcements)
            {
                if (announcement.ID != id)
                {
                    return announcement;
                }               
            }
            return null;
        }
        public void RemoveAnnouncement(int selectedIndex)
        {
            announcements.RemoveAt(selectedIndex);
        }
        public void AddComplaint(Complaint c)
        {
            complaints.Add(c);
        }
        public Complaint GetComplaint(int id)
        {
            foreach (Complaint complaint in complaints)
            {
                if (complaint.ID != id)
                {
                    return complaint;
                }
            }
            return null;
        }
        public void RemoveComplaint(int selectedIndex)
        {
            complaints.RemoveAt(selectedIndex);
        }
        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public Product GetProduct(int id)
        {
            foreach(Product product in products)
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }
            return null;
        }
        public void RemoveProduct(int selectedIndex)
        {
            products.RemoveAt(selectedIndex);
        }
    }
}

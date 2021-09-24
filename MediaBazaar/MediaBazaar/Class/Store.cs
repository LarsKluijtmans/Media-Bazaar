﻿using System.Collections.Generic;

namespace MediaBazaar
{
    public class Store
    {
        //fields
        private List<Complaint> complaints;
        private List<Announcement> announcements;
        private List<Product> products;
        private List<Employee> employees;


        //properties
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public List<Announcement> Announcements
        {
            get { return announcements; }
            set { announcements = value; }
        }
        public List<Complaint> Complaints
        {
            get { return complaints; }
            set { complaints = value; }
        }
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public List<Product> PendingRequestedProducts 
        { 
            get; set; 
        }
        public List<Product> History
        {
            get; set; 
        }


        //constructions
        public Store()
        {
            Complaints = new List<Complaint>();
            Announcements = new List<Announcement>();
            Employees = new List<Employee>();
            Products = new List<Product>();
        }


        //methods
        //ANNOUNCEMENT
        //public void AddAnnouncement(Announcement a)
        //{
        //    Announcements.Add(a);
        //}
        //public Announcement GetAnnouncement(int id)
        //{
        //    foreach (Announcement announcement in Announcements)
        //    {
        //        if (announcement.AnnouncementID == id)
        //        {
        //            return announcement;
        //        }
        //    }
        //    return null;
        //}
        //public void RemoveAnnouncement(int selectedIndex)
        //{
        //    announcements.RemoveAt(selectedIndex);
        //}

        ////COMPLAINTS
        //public void AddComplaint(Complaint c)
        //{
        //    Complaints.Add(c);
        //}
        //public Complaint GetComplaint(int id)
        //{
        //    foreach (Complaint complaint in Complaints)
        //    {
        //        if (complaint.ComplaintID == id)
        //        {
        //            return complaint;
        //        }
        //    }
        //    return null;
        //}
        //public void RemoveComplaint(int selectedIndex)
        //{
        //    Complaints.RemoveAt(selectedIndex);
        //}

        //PRODUCTS
        //public void AddProduct(Product p)
        //{
        //    Products.Add(p);
        //}
        //public Product GetProduct(int id)
        //{
        //    foreach (Product product in Products)
        //    {
        //        if (product.ProductID == id)
        //        {
        //            return product;
        //        }
        //    }
        //    return null;
        //}
        public void AddRequestedProduct(Product p)
        {
            PendingRequestedProducts.Add(p);
        }
        public void AddHistory(Product p)
        {
            History.Add(p);
        }
        //public bool AddAmountofProduct(int id, int amount)
        //{
        //    if (GetProduct(id) != null || (GetProduct(id).Amount + amount) > GetProduct(id).WarehouseAmount)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        GetProduct(id).Amount += amount;
        //        return true;
        //    }
        //}
        public void Refill(int id)
        {
            if (GetProduct(id) != null)
            {
                GetProduct(id).WarehouseAmount -= (GetProduct(id).ShelfSpace - GetProduct(id).Amount);
                GetProduct(id).Amount = GetProduct(id).ShelfSpace;
            }
        }
        public bool DecreaseAmountofProduct(int id, int amount)
        {
            if (GetProduct(id) == null || amount > GetProduct(id).Amount)
            {
                return false;
            }
            else
            {
                GetProduct(id).Amount -= amount;
                return true;
            }
        }

        //EMPLOYEE
        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.EmployeeID == id)
                {
                    return employee;
                }
            }
            return null;
        }
        public void RemoveEmployee(int selectedIndex)
        {
            Employees.RemoveAt(selectedIndex);
        }
        
    }
}

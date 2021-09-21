using System.Collections.Generic;

namespace MediaBazaar
{
    public class Store
    {
        private List<Complaint> complaints;
        private List<Announcement> announcements;
        private List<Product> products;
        private List<Employee> employees;

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public Store()
        {
            complaints = new List<Complaint>();
            announcements = new List<Announcement>();
            employees = new List<Employee>();
        }
        public void AddAnnouncement(Announcement a)
        {
            announcements.Add(a);
        }
        public Announcement GetAnnouncement(int id)
        {
            foreach (Announcement announcement in announcements)
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
            foreach (Product product in Products)
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

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee employee in employees)
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
            employees.RemoveAt(selectedIndex);

        }
        public void amountDecreaseProduct(Product p, int amount)
        {
            foreach (Product product in Products)
            {
                if (product == p)
                {
                    p.Amount -= product.Amount;
                }
            }
        }

        public void amountIncreaseProduct(Product p, int amount)
        {
            foreach (Product product in Products)
            {
                if (product == p)
                {
                    p.Amount += product.Amount;
                }
            }
        }
    }
}

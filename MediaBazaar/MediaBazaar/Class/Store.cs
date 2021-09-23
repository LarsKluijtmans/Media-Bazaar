using System.Collections.Generic;

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
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        

        //constructions
        public Store()
        {
            complaints = new List<Complaint>();
            announcements = new List<Announcement>();
            employees = new List<Employee>();
            products = new List<Product>();
        }


        //methods
        //ANNOUNCEMENT
        public void AddAnnouncement(Announcement a)
        {
            announcements.Add(a);
        }
        public Announcement GetAnnouncement(int id)
        {
            foreach (Announcement announcement in announcements)
            {
                if (announcement.AnnouncementID == id)
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

        //COMPLAINTS
        public void AddComplaint(Complaint c)
        {
            complaints.Add(c);
        }
        public Complaint GetComplaint(int id)
        {
            foreach (Complaint complaint in complaints)
            {
                if (complaint.ComplaintID == id)
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

        //PRODUCTS
        public void AddProduct(Product p)
        {
            products.Add(p);
        }
        public Product GetProduct(int id)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == id)
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
        public void AddAmountofProduct(int productID, int amount)
        {
            if (GetProduct(productID) != null)
            {
                GetProduct(productID).Amount += amount;
            }
        }
        public void DecreaseAmountofProduct(int productID, int amount)
        {
            if (GetProduct(productID) != null)
            {
                if (GetProduct(productID).Amount > 0)
                {
                    GetProduct(productID).Amount -= amount;
                }
            }
        }

        //EMPLOYEE
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
        public Employee GetEmployee(string firstName, string lastName) // check if employee exists
        {
            foreach (Employee e in this.Employees)
            {
                if (firstName == e.Firstname && lastName == e.Lastname)
                {
                    return e; // employee exists
                }
            }
            return null; // employee doesn't exist
        }
        public void RemoveEmployee(int selectedIndex)
        {
            employees.RemoveAt(selectedIndex);
        }
        public bool AddEmployees(string firstName, string lastName, string gender, string email, int phoneNumber, string address, string dateOfBirth, int bsn, string username, string password)
        {
            Employee e = GetEmployee(firstName, lastName);

            if (e != null)
            {
                return false; // employee already exists
            }
            else
            {
                Employee newEmployee = new Employee(lastName, firstName, gender, phoneNumber, email, address, dateOfBirth, bsn, username, password); // create new employee
                Employees.Add(newEmployee); // add employee to list of all employees
                return true;
            }
        }
    }
}

namespace ClassLibraryProject.Class
{
    public class Supplier
    {
        private int supplierID;
        private string name;
        private string country;
        private int buildingNumber;
        private string postalCode;
        private string email;
        private int phoneNumber;
        private string bankNumber;

        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public int BuildingNumber
        {
            get { return buildingNumber; }
            set { buildingNumber = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string BankNumber
        {
            get { return bankNumber; }
            set { bankNumber = value; }
        }
        public Supplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber)
        {
            SupplierID = id;
            Name = name;
            Country = country;
            BuildingNumber = buildingNumber;
            PostalCode = postalCode;
            Email = email;
            PhoneNumber = phoneNumber;
            BankNumber = bankNumber;
        }
    }
}


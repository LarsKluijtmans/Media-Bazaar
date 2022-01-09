
namespace CardReader
{
    class Ckecks
    {
        private int employeeID;
        private string checkIn;
        private string checkOut;
        private string date;

        public int EmployeeID
        { get { return employeeID; } }

        public string CheckIn
        { get { return checkIn; } }
        public string CheckOut
        { get { return checkOut; } }
        public string Date
        { get { return date; } }

        public Ckecks(int EmployeeID, string CheckIn, string CheckOut, string Date)
        {
            employeeID = EmployeeID;
            checkIn = CheckIn;
            checkOut = CheckOut;
            date = Date;
        }

        public override string ToString()
        {
            return $"EmployeeID: {EmployeeID} Checkin: {CheckIn}  Checkout: {CheckOut}";
        }
    }
}

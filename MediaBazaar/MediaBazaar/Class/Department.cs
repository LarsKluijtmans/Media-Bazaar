namespace MediaBazaar.Class
{
    public class Department
    {
        //fields
        private string head;
        private string name;

        //properties
        public string Head
        {
            get { return head; }
            set { head = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //constructor
        public Department(string Head, string Name)
        {
            head = Head;
            name = Name;
        }


        //methods
        public override string ToString()
        {
            return "Head department: " + head + "Name: " + name;
        }
    }
}

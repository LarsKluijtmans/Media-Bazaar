using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class Form1 : Form
    {
        Employee e;
        Store s;
        private string productN;
        private ProductType productType;
        private int productA;
        private string firstN;
        private string lastN;
        private int phoneN;
        private int bsn;
        private string username;
        private string email;
        private string password;

        public Form1(Employee employee, Store store)
        {
            InitializeComponent();
            store = s;
            employee = e;

        }

        public Form1(string productN, ProductType productType, int productA)
        {
            this.productN = productN;
            this.productType = productType;
            this.productA = productA;
        }

        public Form1(string firstN, string lastN, int phoneN, int bsn, string username, string email, string password)
        {
            this.firstN = firstN;
            this.lastN = lastN;
            this.phoneN = phoneN;
            this.bsn = bsn;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public static implicit operator Form1(FormDepotManager v)
        {
            throw new NotImplementedException();
        }
    }
}

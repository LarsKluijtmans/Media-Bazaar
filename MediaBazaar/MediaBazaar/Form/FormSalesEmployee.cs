using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormSalesEmployee : Form,INterface1
    {
        Employee e;
        Store s;
        public FormSalesEmployee(Employee employee, Store store)
        {
            InitializeComponent();
            store = s;
            employee = e;

        }

        public void RequestRestock()
        {
            throw new NotImplementedException();
        }

        private void btnRequestReplenishment_Click(object sender, EventArgs e)
        {
            int Amount = Convert.ToInt32(tbxAmount.Text);
            int ProductID = Convert.ToInt32(tbProductID);
        }
    }
}

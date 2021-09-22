using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormDepotEmployee : Form
    {
        Employee e;
        Store s;
        public FormDepotEmployee(Employee employee, Store store)
        {
            InitializeComponent();
            store = s;
            employee = e;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormOfficeEmployee : Form
    {
        Employee e;
        Store s;
        public FormOfficeEmployee(Employee employee, Store store)
        {
            InitializeComponent();
            store = s;
            employee = e;

        }
    }
}

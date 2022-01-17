using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IDepotManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormOrderRestock : Form
    {
        int id;
        IDepotManagerControl c;
        public FormOrderRestock(int id, IDepotManagerControl control)
        {
            InitializeComponent();

            this.id = id;
            c = control;
        }

        private void btnOrderRestock_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(txtAmount.Text);
                if(c.OrderRestock(id, ))
            }
        }
    }
}

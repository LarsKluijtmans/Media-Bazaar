using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode_scaner
{
    public partial class Form1 : Form
    {
        ReshelfManament RM;
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            tbAmount.Visible = false;
            timer1.Start();
            timer1.Interval = 10;

             RM = new ReshelfManament();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbBarcode.Text) > 0)
                {
                    label2.Visible = true;
                    tbAmount.Visible = true;
                    tbAmount.Text = "10";
                }
                else
                {
                    label2.Visible = false;
                    tbAmount.Visible = false;
                }
            }
            catch { }
        }

        private void btnReShelf_Click(object sender, EventArgs e)
        {

            RM.RequestReshelf(RM.GetID(tbBarcode.Text), tbBarcode.Text, tbAmount.Text);
            label2.Visible = false;
            tbAmount.Visible = false;

        }
    }
}

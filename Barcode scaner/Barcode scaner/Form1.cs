using System;
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
            btnAddToAmount.Visible = false;
            tbDecreaseAmount.Visible = false;
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
                    btnAddToAmount.Visible = true;
                    tbDecreaseAmount.Visible = true;

                    int a = RM.GetRecomendedAmount(tbBarcode.Text, Convert.ToInt32(tbAmount.Text));
                    tbAmount.Text = a.ToString();


                }
                else
                {
                    label2.Visible = false;
                    tbAmount.Visible = false;
                    btnAddToAmount.Visible = false;
                    tbDecreaseAmount.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void btnReShelf_Click(object sender, EventArgs e)
        {
            RM.RequestReshelf(RM.GetID(tbBarcode.Text), tbBarcode.Text, tbAmount.Text);
            label2.Visible = false;
            tbAmount.Visible = false;
        }

        private void btnAddToAmount_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tbAmount.Text);
            amount += RM.IncreaseAmount(tbBarcode.Text, Convert.ToInt32(tbAmount.Text));
        }

        private void tbDecreaseAmount_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tbAmount.Text);
            amount -= RM.DecreaseAmount(tbBarcode.Text, Convert.ToInt32(tbAmount.Text));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

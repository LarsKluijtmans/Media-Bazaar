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

            txtRestockID.Text = id.ToString();
        }


        private void btnOrderRestock_Click(object sender, EventArgs e)
        {
            Object orderinfoObject = lstOrderInfo.SelectedItem;
            if (!(orderinfoObject is OrderInfo))
            {
                MessageBox.Show("Select a order info!");
            }
            try
            {
                int amount = Convert.ToInt32(txtAmount.Text);
                OrderInfo orderInfo = (OrderInfo)orderinfoObject;
                if (c.OrderRestock(id, orderInfo, amount))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void lstOrderInfo_Click(object sender, EventArgs e)
        {
            Object orderinfoObject = lstOrderInfo.SelectedItem;
            if (!(orderinfoObject is OrderInfo))
            {
                return;
            }
            else
            {
                OrderInfo orderInfo = (OrderInfo)orderinfoObject;

                txtOrderInfoID.Text = orderInfo.ID.ToString();
                txtSupplier.Text = orderInfo.Supplier.Name;
                txtMax.Text = orderInfo.MaxAmount.ToString();
                txtMin.Text = orderInfo.MinAmount.ToString();
                txtMultiples.Text = orderInfo.Multiples.ToString();
            }
        }
    }
}

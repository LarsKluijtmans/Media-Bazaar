using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormSalesEmployee : Form
    {
        Store s;
        Employee em;
        private List<IReplenishment> childForms;
        public FormSalesEmployee(Store store, Employee employee)
        {
            InitializeComponent();
            s = store;
            em = employee;
            childForms = new List<IReplenishment>();

            FormDepotEmployee depot = new FormDepotEmployee(s,em);
            childForms.Add(depot);

            UpdateProductList();
            UpdateAnnouncementList();
        }
        public void UpdateProductList()
        {
            lstOverviewProduct.Items.Clear();
            lstProduct.Items.Clear();
            foreach (Product product in s.Products)
            {
                lstProduct.Items.Add(product);
                lstOverviewProduct.Items.Add(product.GetInfo());
            }
        }
        public void UpdateAnnouncementList()
        {
            lstOverviewAnnoucement.Items.Clear();
            foreach (Announcement a in s.Announcements)
            {
                lstOverviewProduct.Items.Add(a);
            }
        }
        private void btnRequestReplenishment_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(txtProductIDReplenishment.Text);
            int amountRequested = Convert.ToInt32(txtAmountReplenishment.Text);
            Product pr = s.GetProduct(productID);
            if (pr.Amount == pr.ShelfSpace)
            {
                MessageBox.Show("Shelf is full. This product doesnt need replenishment");
            }
            else
            {
                pr.AmountRequested = amountRequested;
                foreach (IReplenishment childForm in childForms)
                {
                    childForm.Requested(pr);
                }
            }
        }
        private void btnRemoveAmount_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(txtProductIDSales.Text);
            int amount = Convert.ToInt32(txtAmountSales.Text);
            if (s.DecreaseAmountofProduct(productID, amount) == true)
            {
                s.DecreaseAmountofProduct(productID, amount);
                Product pr = s.GetProduct(productID);
                if (pr.Amount < 10)
                {
                    foreach (IReplenishment childForm in childForms)
                    {
                        childForm.Requested(pr);
                    }
                }
            }
            else
            {
                MessageBox.Show("Not enough product left in shelf");
            }
            UpdateProductList();
        }
        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            string message = txtComplaint.Text;
            Complaint complaint = new Complaint(message);
            s.AddComplaint(complaint);
        }
        private void btnSubmitAnnouncement_Click(object sender, EventArgs e)
        {
            string message = txtAnnouncement.Text;
            Announcement announcement = new Announcement(message);
            s.AddAnnouncement(announcement);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormEditEmployeeData editEmployeeData = new FormEditEmployeeData(s, em);
            editEmployeeData.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}

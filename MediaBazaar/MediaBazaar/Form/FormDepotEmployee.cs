using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class FormDepotEmployee : Form, IReplenishment
    {
        Store s;
        Employee em;
        private static int counter = 1;
        public FormDepotEmployee(Store store, Employee employee)
        {
            InitializeComponent();
            s = store;
            em = employee;

            UpdateHistoryList();
            UpdateWarehouseProductList();
            UpdateAnnouncementList();
        }
        public void UpdateWarehouseProductList()
        {
            lstProduct.Items.Clear();
            foreach (Product product in s.Products)
            {
                lstProduct.Items.Add(product.WarehouseInfo());
            }
        }
        public void UpdateHistoryList()
        {
            lstHistory.Items.Clear();
            lstOverviewHistory.Items.Clear();
            foreach (Product product in s.History)
            {             
                lstHistory.Items.Add("[Restocked]: " + product.ToString());
                lstOverviewHistory.Items.Add("[Restocked]: " + product.ToString());
            }
        }
        public void UpdateAnnouncementList()
        {
            lstOverviewAnnouncement.Items.Clear();
            lstAnnouncement.Items.Clear();
            foreach (Announcement a in s.Announcements)
            {
                lstAnnouncement.Items.Add(a);
                lstOverviewAnnouncement.Items.Add(a);
            }
        }
        public void Requested(Product p)
        {
            p.RequestID = counter;
            counter++;
            s.AddRequestedProduct(p);
            lstRequest.Items.Add("[Requested]: " + p.RequestInfo());
            lstOverviewPending.Items.Add("[Requested]: " + p.RequestInfo());
            foreach (Product product in s.History)
            {
                lstOverviewHistory.Items.Add("[Requested]: " + product.RequestInfo());
                lstHistory.Items.Add("[Requested]: " + product.RequestInfo());
            }
        }
        public void Replenish(Product p)
        {
            s.AddHistory(p);
            UpdateHistoryList();
            UpdateWarehouseProductList();
        }

        private void btnReplenishment_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(txtRequestID.Text);
            int amount = Convert.ToInt32(txtAmount.Text);


            foreach (Product p in s.PendingRequestedProducts)
            {
                if (p.ProductID == productID)
                {
                    if (s.AddAmountofProduct(productID, amount) == true)
                    {
                        s.AddAmountofProduct(productID, amount);
                        Replenish(s.GetProduct(productID));
                    }
                    else
                    {
                        MessageBox.Show("No space left in shelf");
                    }
                }
                else
                {
                    MessageBox.Show("Product is either restocked or never been requested to restock or wrong product name.");
                }
            }
            s.PendingRequestedProducts.Remove(s.GetProduct(productID));
        }

        private void btnFullyReplenish_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(txtRequestID.Text);
            foreach (Product p in s.PendingRequestedProducts)
            {
                if (p.ProductID == productID)
                {
                    s.Refill(productID);
                    Replenish(s.GetProduct(productID));
                }
            }
            s.PendingRequestedProducts.Remove(s.GetProduct(productID));
        }

        private void btnSubmitAnnouncement_Click(object sender, EventArgs e)
        {
            string message = txtAnnouncement.Text;
            Announcement announcement = new Announcement(message);
            s.AddAnnouncement(announcement);
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            string message = txtComplaint.Text;
            Complaint complaint = new Complaint(message);
            s.AddComplaint(complaint);
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

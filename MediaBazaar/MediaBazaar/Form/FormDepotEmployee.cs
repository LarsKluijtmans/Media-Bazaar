using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AdminBackups
{
    public partial class FormDepotEmployee : Form
    {
        DepotEmployee e;
        Store s;
        IDepotEmployeeControl c;
        List<Reshelf> reshelves;

        public FormDepotEmployee(DepotEmployee employee, Store store)
        {
            InitializeComponent();

            e = employee;
            s = store;
            c = e.Control;
            PendingReshelfRequests();
            dgReshelve.DataSource = reshelves;
            UpdateOrders();
        }

        //Overview
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Reshelves
        public void PendingReshelfRequests()
        {
            reshelves = new List<Reshelf>();
            foreach(Reshelf reshelf in c.GetReshelfRequest())
            {
                if(reshelf.Status == "Pending")
                {
                    reshelves.Add(reshelf);
                }
            }

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Status", typeof(string));

            foreach(Reshelf r in reshelves)
            {
                table.Rows.Add(r.ID, r.Product.Barcode, r.AmountRequested, r.Status);
            }
            dgReshelve.DataSource = table;
        }
        public void FulfilledReshelfRequests()
        {
            reshelves = new List<Reshelf>();
            foreach (Reshelf reshelf in c.GetReshelfRequest())
            {
                if (reshelf.Status == "Fulfilled")
                {
                    reshelves.Add(reshelf);
                }
            }

            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Barcode", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Status", typeof(string));

            foreach (Reshelf r in reshelves)
            {
                table.Rows.Add(r.ID, r.Product.Barcode, r.AmountRequested, r.Status);
            }
            dgReshelve.DataSource = table;
        }
        private void rbPending_Click(object sender, EventArgs e)
        {
            PendingReshelfRequests();
            dgReshelve.DataSource = reshelves;
        }

        private void rbHistory_Click(object sender, EventArgs e)
        {
            FulfilledReshelfRequests();
            dgReshelve.DataSource = reshelves;
        }
        private void btnFufillReshelveRequest_Click(object sender, EventArgs e)
        {
            
            try
            {
                int reshelfID = Convert.ToInt32(txtReshelfID.Text);
                string barcode = txtBarcode.Text;
                c.CompleteReshelf(reshelfID);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to fulfill");
            }

            PendingReshelfRequests();
        }
        private void btnDeleteReshelveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int reshelfID = Convert.ToInt32(txtReshelfID.Text);
                c.DeleteReshelf(reshelfID);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a reshelf request you want to reject");
            }
            PendingReshelfRequests();
        }
        private void dgReshelve_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgReshelve.Rows[e.RowIndex];
                txtReshelfID.Text = row.Cells["ID"].Value.ToString();
                txtBarcode.Text = row.Cells["Barcode"].Value.ToString();
                txtAmountRequested.Text = row.Cells["AmountRequested"].Value.ToString();
            }
        }

        //Receive Product
        public void UpdateOrders()
        {
            //dgOrder.DataSource = store.restockManagment.ViewOrderedRestockRequests();
        }
        private void dgOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgOrder.Rows[e.RowIndex];
                txtRestockID.Text = row.Cells["RestockReplenishmentID"].Value.ToString();
                txtProductIDRestock.Text = row.Cells["ProductID"].Value.ToString();
                txtBarcodeRestock.Text = row.Cells["Barcode"].Value.ToString();
            }
        }
        private void btnReceiveProduct_Click(object sender, EventArgs e)
        {
            string restockID = txtRestockID.Text;
            string amountReceived = txtAmountReceived.Text;
            try
            {
                //store.restockManagment.RestockReplenishment(Convert.ToInt32(restockID), Convert.ToInt32(amountReceived));
                //store.restockManagment.AddToDepot(Convert.ToInt32(restockID));
            }
            catch (Exception)
            {
                MessageBox.Show("Select restock request and input the amount supplied");
            }
            UpdateOrders();
        }
    }
}

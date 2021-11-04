using System;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
namespace MediaBazaar
{
    public partial class FormOrderInfo : Form
    {
        int supplierID;
        OrderInfoManagment infoManagment;
        public FormOrderInfo(int ID)
        {
            InitializeComponent();
            infoManagment = new OrderInfoManagment();
            supplierID = ID;
            txtSupplierID.Text = supplierID.ToString();
            UpdateOrder();
        }
        public void UpdateOrder()
        {
            infoManagment.GetAllOrderInfo();         

            foreach(OrderInfo info in infoManagment.OrderInfos)
            {
                if (info.SupplierID == supplierID)
                {
                    txtProductID.Text = info.ProductID.ToString();
                    lblOrderID.Text = info.OrderInfoID.ToString();
                    txtSupplierID.Text = supplierID.ToString();
                    txtMultiples.Text = info.Multiples.ToString();
                    txtMaxAmount.Text = info.MaxAmount.ToString();
                    txtMinAmount.Text = info.MinAmount.ToString();
                }
            }  
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            int supplierID = Convert.ToInt32(txtSupplierID.Text);
            int productID = Convert.ToInt32(txtProductID.Text);
            int multiples = Convert.ToInt32(txtMultiples.Text);
            int maxAmount = Convert.ToInt32(txtMaxAmount.Text);
            int minAmount = Convert.ToInt32(txtMinAmount.Text);
            infoManagment.EditOrderInfo(supplierID, productID, minAmount, maxAmount, multiples);
            UpdateOrder();
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            infoManagment.DeleteOrderInfo(Convert.ToInt32(lblOrderID.Text));
            txtMultiples.Clear();
            txtMaxAmount.Clear();
            txtMinAmount.Clear();
        }

        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(txtSupplierID.Text);
            int productID = Convert.ToInt32(txtProductID.Text);
            int multiples = Convert.ToInt32(txtMultiples.Text);
            int maxAmount = Convert.ToInt32(txtMaxAmount.Text);
            int minAmount = Convert.ToInt32(txtMinAmount.Text);
            infoManagment.AddOrderInfo(supplierID, productID, minAmount, maxAmount, multiples);
            UpdateOrder();
        }

        private void txtProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }
    }
}

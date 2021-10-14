using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class SalesManager : Form
    {
        int ID;
        Store store;
        public SalesManager(int UserID, Store s)
        {
            InitializeComponent();
            ID = UserID;
            store = s;

            ViewAllProducts();
            ViewAllSchedule();
            ViewSalesPlan();
        }
        //Products

        public void ViewAllProducts()
        {
            store.productManagment.ViewAllProducts();

            lstProduct.Items.Clear();

            foreach (Product product in store.productManagment.products)
            {
                lstProduct.Items.Add(product);
            }
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedIndex < 0)
            {
                return;
            }

            Object ProductObject = lstProduct.SelectedItem;
            if (!(ProductObject is Product))
            {
                return;
            }

            Product product = (Product)ProductObject;
            tbID.Text = product.ProductID.ToString();
            tbName.Text = product.Name;
            tbBarcode.Text = product.Barcode;
            lbProductType.Text = product.ProductType;
            tbmountInStore.Text = product.AmountInStore.ToString();
            tbAmountInDepot.Text = product.AmountInDepot.ToString();
        }

        private void btnRequestReplenishment_Click(object sender, EventArgs e)
        {

            string ID = tbID.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("'ID' field is required.");
                return;
            }

            string Amount = tbAmount.Text;
            if (string.IsNullOrEmpty(Amount))
            {
                MessageBox.Show("'Amount' field is required.");
                return;
            }

            store.reshelfManagment.RequestReshelf(ID, Amount);
            ViewAllProducts();
        }

        private void btnViewPorducts_Click(object sender, EventArgs e)
        {
            ViewAllProducts();
        }

        // schedule

        public void ViewAllSchedule()
        {
            dgvSchedule.DataSource = store.scheduleManagment.ViewSalesSchedule();
        }

        private void btViewSchedule_Click(object sender, EventArgs e)
        {
            ViewAllSchedule();
        }

        private void btnEditschedule_Click(object sender, EventArgs e)
        {

            string Morning = lbScheduleMorning.Text;
            if (string.IsNullOrEmpty(Morning))
            {
                MessageBox.Show("'Morning' field is required.");
                return;
            }

            string Afternoon = lbScheduleAfternoon.Text;
            if (string.IsNullOrEmpty(Afternoon))
            {
                MessageBox.Show("'Afternoon' field is required.");
                return;
            }

            string Evening = lbScheduleEvening.Text;
            if (string.IsNullOrEmpty(Evening))
            {
                MessageBox.Show("'Evening' field is required.");
                return;
            }
            string day = lbScheduleDay.Text;
            if (string.IsNullOrEmpty(day))
            {
                MessageBox.Show("Please select a time");
                return;
            }

            store.scheduleManagment.Editschedule(day, Morning, Afternoon, Evening);

            ViewAllSchedule();
        }


        //Planing

        public void ViewSalesPlan()
        {
            store.planingManagment.ViewSalesPlaning();

            lbPlaning.Items.Clear();

            foreach (Planing planing in store.planingManagment.planings)
            {
                lbPlaning.Items.Add(planing);
            }


            lbEmployee.Items.Clear();

            foreach (BasicEmployeeInfo employee in store.planingManagment.employees)
            {
                lbEmployee.Items.Add(employee);
            }
        }

        private void lbPlaning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPlaning.SelectedIndex < 0)
            {
                return;
            }

            Object planObject = lbPlaning.SelectedItem;
            if (!(planObject is Planing))
            {
                return;
            }

            Planing planing = (Planing)planObject;

            tbWorkId.Text = planing.WorkID.ToString();
            tbNewEmployeeId.Text = planing.EmployeeID.ToString();
            tbDep.Text = planing.Department;
            tbDay.Text = planing.Day.ToString();
            tbTime.Text = planing.Time.ToString();
        }

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEmployee.SelectedIndex < 0)
            {
                return;
            }

            Object employeeObject = lbEmployee.SelectedItem;
            if (!(employeeObject is BasicEmployeeInfo))
            {
                return;
            }

            BasicEmployeeInfo EmployeeInfo = (BasicEmployeeInfo)employeeObject;

            tbNewEmployeeId.Text = EmployeeInfo.EmployeeID.ToString();
            tbNewEmployeeId.BackColor = Color.LightBlue;
        }

        private void btnEditPlaning_Click(object sender, EventArgs e)
        {

            string WorkID = tbWorkId.Text;
            if (string.IsNullOrEmpty(WorkID))
            {
                MessageBox.Show("'WorkID' field is required.");
                return;
            }

            string NewEmployeeId = tbNewEmployeeId.Text;
            if (string.IsNullOrEmpty(NewEmployeeId))
            {
                MessageBox.Show("'NewEmployeeId' field is required.");
                return;
            }

            string Department = tbDep.Text;
            if (string.IsNullOrEmpty(Department))
            {
                MessageBox.Show("'Department' field is required.");
                return;
            }

            string Day = tbDay.Text;
            if (string.IsNullOrEmpty(Day))
            {
                MessageBox.Show("'Day' field is required.");
                return;
            }

            string Time = tbTime.Text;
            if (string.IsNullOrEmpty(Time))
            {
                MessageBox.Show("'Time' field is required.");
                return;
            }
            store.planingManagment.EditPlaning(WorkID, NewEmployeeId, Department, Day, Time);

            ViewSalesPlan();

            tbNewEmployeeId.Text = "";
            tbWorkId.Text = "";
            tbNewEmployeeId.Text = "";
            tbDep.Text = "";
            tbDay.Text = "";
            tbTime.Text = "";
            tbNewEmployeeId.BackColor = Color.LightGray;
        }

        private void btnViewSalesPlan_Click(object sender, EventArgs e)
        {
            ViewSalesPlan();
        }

        // other
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

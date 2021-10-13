using MediaBazaar.Class;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class FormLogin : Form
    {
        Store store = new Store();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = tbxUsername.Text;
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("'id' field is required.");
                return;
            }

            string Password = tbxPassword.Text;
            if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("'password' field is required.");
                return;
            }

            switch (store.loginManagment.checkLogin(ID, Password))
            {
                case "OWNER": Form1 form1 = new Form1(Convert.ToInt32(ID), store); Hide(); form1.Show(); break;
                case "SALES MANAGER": FormSalesManager formSalesManager = new FormSalesManager(Convert.ToInt32(ID), store); Hide(); formSalesManager.Show(); break;
                case "SALES EMPLOYEE": FormSalesEmployee formSalesEmployee = new FormSalesEmployee(Convert.ToInt32(ID), store); Hide(); formSalesEmployee.Show(); break;
                case "OFFICE MANAGER": FormOfficeManager formOfficeManager = new FormOfficeManager(Convert.ToInt32(ID), store); Hide(); formOfficeManager.Show(); break;
                case "OFFICE EMPLOYEE": FormOfficeEmployee formOfficeEmployee = new FormOfficeEmployee(Convert.ToInt32(ID), store); Hide(); formOfficeEmployee.Show(); break;
                case "DEPOT MANAGER": FormDepotManager formDepotManager = new FormDepotManager(Convert.ToInt32(ID), store); Hide(); formDepotManager.Show(); break;
                case "DEPOT EMPLOYEE": FormDepotEmployee formDepotEmployee = new FormDepotEmployee(Convert.ToInt32(ID), store); Hide(); formDepotEmployee.Show(); break;
                case "Wrong info!": MessageBox.Show(store.loginManagment.checkLogin(ID, Password)); break;
            }
        }
    }
}

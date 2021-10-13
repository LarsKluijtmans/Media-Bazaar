﻿using MediaBazaar.Class;
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
                case "CEO": DepotEmployee formDepotEmployee = new DepotEmployee(Convert.ToInt32(ID), store); Hide(); formDepotEmployee.Show(); break;
                case "ADMIN": Admin admin = new Admin(Convert.ToInt32(ID), store); Hide(); admin.Show(); break;
                case "SALES MANAGER": SalesManager salesManager = new SalesManager(Convert.ToInt32(ID), store); Hide(); salesManager.Show(); break;
                case "SALES REPRESENTATIVE": SalesRepresentative salesEmployee = new SalesRepresentative(Convert.ToInt32(ID), store); Hide(); salesEmployee.Show(); break;
                case "OFFICE MANAGER": OfficeManager officeManager = new OfficeManager(Convert.ToInt32(ID), store); Hide(); officeManager.Show(); break;
                case "PRODUCT MANAGER": ProductManager officeEmployee = new ProductManager(Convert.ToInt32(ID), store); Hide(); officeEmployee.Show(); break;
                case "DEPOT MANAGER": DepotManager depotManager = new DepotManager(Convert.ToInt32(ID), store); Hide(); depotManager.Show(); break;
                case "DEPOT EMPLOYEE": DepotEmployee depotEmployee = new DepotEmployee(Convert.ToInt32(ID), store); Hide(); depotEmployee.Show(); break;
                case "Wrong info!": MessageBox.Show("Wrong info!"); break;
            }
        }
    }
}

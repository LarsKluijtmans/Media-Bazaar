using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryProject;
using ClassLibraryProject.Class;
using System.ComponentModel;

namespace MediaBazaar
{
    public partial class Admin : Form
    {
        int ID;
        Store store;

        public Admin(int userID, Store s)
        {
            InitializeComponent();
            ID = userID;
            store = s;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

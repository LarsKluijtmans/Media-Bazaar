using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryProject.Class;

namespace MediaBazaar
{
    public partial class CEO : Form
    {

        public CEO(int UserID, Store s)
        {
            InitializeComponent();
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

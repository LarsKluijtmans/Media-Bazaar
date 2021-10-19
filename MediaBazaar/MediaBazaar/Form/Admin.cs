using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibraryProject;
using ClassLibraryProject.Class;

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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Class;
using MySql.Data.MySqlClient;

namespace MediaBazaar
{
    public partial class CEO : Form
    {

        public CEO(int UserID, Store s)
        {
            InitializeComponent();
        }
    }
}

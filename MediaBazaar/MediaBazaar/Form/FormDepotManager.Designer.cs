
namespace MediaBazaar
{
    partial class FormDepotManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteEmployees = new System.Windows.Forms.Button();
            this.btnUpdateEmployees = new System.Windows.Forms.Button();
            this.btnReadEmployees = new System.Windows.Forms.Button();
            this.btnCreateNewEmployee = new System.Windows.Forms.Button();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.rbnDepotEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.rbnKitchenHome = new System.Windows.Forms.RadioButton();
            this.rbnAllProducts = new System.Windows.Forms.RadioButton();
            this.rbnGamingMusicComputers = new System.Windows.Forms.RadioButton();
            this.rbnSmartHome = new System.Windows.Forms.RadioButton();
            this.rbnPhotoVideoNav = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee overview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxEmployeeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeleteEmployees);
            this.groupBox1.Controls.Add(this.btnUpdateEmployees);
            this.groupBox1.Controls.Add(this.btnReadEmployees);
            this.groupBox1.Controls.Add(this.btnCreateNewEmployee);
            this.groupBox1.Controls.Add(this.lbxEmployees);
            this.groupBox1.Controls.Add(this.rbnDepotEmployees);
            this.groupBox1.Controls.Add(this.rbnAllEmployees);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Employees";
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Location = new System.Drawing.Point(597, 110);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(192, 27);
            this.tbxEmployeeID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected Employee ID:";
            // 
            // btnDeleteEmployees
            // 
            this.btnDeleteEmployees.Location = new System.Drawing.Point(597, 296);
            this.btnDeleteEmployees.Name = "btnDeleteEmployees";
            this.btnDeleteEmployees.Size = new System.Drawing.Size(192, 41);
            this.btnDeleteEmployees.TabIndex = 7;
            this.btnDeleteEmployees.Text = "Delete Employees";
            this.btnDeleteEmployees.UseVisualStyleBackColor = true;
            this.btnDeleteEmployees.Click += new System.EventHandler(this.btnDeleteEmployees_Click);
            // 
            // btnUpdateEmployees
            // 
            this.btnUpdateEmployees.Location = new System.Drawing.Point(597, 249);
            this.btnUpdateEmployees.Name = "btnUpdateEmployees";
            this.btnUpdateEmployees.Size = new System.Drawing.Size(192, 41);
            this.btnUpdateEmployees.TabIndex = 6;
            this.btnUpdateEmployees.Text = "Update Employees";
            this.btnUpdateEmployees.UseVisualStyleBackColor = true;
            this.btnUpdateEmployees.Click += new System.EventHandler(this.btnUpdateEmployees_Click);
            // 
            // btnReadEmployees
            // 
            this.btnReadEmployees.Location = new System.Drawing.Point(597, 202);
            this.btnReadEmployees.Name = "btnReadEmployees";
            this.btnReadEmployees.Size = new System.Drawing.Size(192, 41);
            this.btnReadEmployees.TabIndex = 5;
            this.btnReadEmployees.Text = "Read Employees";
            this.btnReadEmployees.UseVisualStyleBackColor = true;
            this.btnReadEmployees.Click += new System.EventHandler(this.btnReadEmployees_Click);
            // 
            // btnCreateNewEmployee
            // 
            this.btnCreateNewEmployee.Location = new System.Drawing.Point(597, 155);
            this.btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            this.btnCreateNewEmployee.Size = new System.Drawing.Size(192, 41);
            this.btnCreateNewEmployee.TabIndex = 1;
            this.btnCreateNewEmployee.Text = "Create New Employee";
            this.btnCreateNewEmployee.UseVisualStyleBackColor = true;
            this.btnCreateNewEmployee.Click += new System.EventHandler(this.btnCreateNewEmployee_Click);
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 20;
            this.lbxEmployees.Location = new System.Drawing.Point(19, 78);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(543, 364);
            this.lbxEmployees.TabIndex = 4;
            this.lbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lbxEmployees_SelectedIndexChanged);
            // 
            // rbnDepotEmployees
            // 
            this.rbnDepotEmployees.AutoSize = true;
            this.rbnDepotEmployees.Checked = true;
            this.rbnDepotEmployees.Location = new System.Drawing.Point(165, 37);
            this.rbnDepotEmployees.Name = "rbnDepotEmployees";
            this.rbnDepotEmployees.Size = new System.Drawing.Size(148, 24);
            this.rbnDepotEmployees.TabIndex = 2;
            this.rbnDepotEmployees.TabStop = true;
            this.rbnDepotEmployees.Text = "Depot employees";
            this.rbnDepotEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnAllEmployees
            // 
            this.rbnAllEmployees.AutoSize = true;
            this.rbnAllEmployees.Location = new System.Drawing.Point(19, 36);
            this.rbnAllEmployees.Name = "rbnAllEmployees";
            this.rbnAllEmployees.Size = new System.Drawing.Size(124, 24);
            this.rbnAllEmployees.TabIndex = 0;
            this.rbnAllEmployees.Text = "All employees";
            this.rbnAllEmployees.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(833, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(914, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Announcements";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(914, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Products";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnPhotoVideoNav);
            this.groupBox2.Controls.Add(this.rbnGamingMusicComputers);
            this.groupBox2.Controls.Add(this.rbnSmartHome);
            this.groupBox2.Controls.Add(this.tbxProductID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnRemoveProduct);
            this.groupBox2.Controls.Add(this.btnEditProducts);
            this.groupBox2.Controls.Add(this.btnViewProducts);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Controls.Add(this.lbxProducts);
            this.groupBox2.Controls.Add(this.rbnKitchenHome);
            this.groupBox2.Controls.Add(this.rbnAllProducts);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Products";
            // 
            // tbxProductID
            // 
            this.tbxProductID.Location = new System.Drawing.Point(597, 110);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ReadOnly = true;
            this.tbxProductID.Size = new System.Drawing.Size(192, 27);
            this.tbxProductID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Product ID:";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(597, 296);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(192, 41);
            this.btnRemoveProduct.TabIndex = 7;
            this.btnRemoveProduct.Text = "Delete Products";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.Location = new System.Drawing.Point(597, 249);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(192, 41);
            this.btnEditProducts.TabIndex = 6;
            this.btnEditProducts.Text = "Update Products";
            this.btnEditProducts.UseVisualStyleBackColor = true;
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(597, 202);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(192, 41);
            this.btnViewProducts.TabIndex = 5;
            this.btnViewProducts.Text = "Read Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(597, 155);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(192, 41);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Create New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lbxProducts
            // 
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 20;
            this.lbxProducts.Location = new System.Drawing.Point(19, 118);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(543, 324);
            this.lbxProducts.TabIndex = 4;
            this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
            // 
            // rbnKitchenHome
            // 
            this.rbnKitchenHome.AutoSize = true;
            this.rbnKitchenHome.Location = new System.Drawing.Point(218, 66);
            this.rbnKitchenHome.Name = "rbnKitchenHome";
            this.rbnKitchenHome.Size = new System.Drawing.Size(126, 24);
            this.rbnKitchenHome.TabIndex = 2;
            this.rbnKitchenHome.Text = "Kitchen/Home";
            this.rbnKitchenHome.UseVisualStyleBackColor = true;
            // 
            // rbnAllProducts
            // 
            this.rbnAllProducts.AutoSize = true;
            this.rbnAllProducts.Checked = true;
            this.rbnAllProducts.Location = new System.Drawing.Point(453, 66);
            this.rbnAllProducts.Name = "rbnAllProducts";
            this.rbnAllProducts.Size = new System.Drawing.Size(109, 24);
            this.rbnAllProducts.TabIndex = 0;
            this.rbnAllProducts.TabStop = true;
            this.rbnAllProducts.Text = "All Products";
            this.rbnAllProducts.UseVisualStyleBackColor = true;
            // 
            // rbnGamingMusicComputers
            // 
            this.rbnGamingMusicComputers.AutoSize = true;
            this.rbnGamingMusicComputers.Location = new System.Drawing.Point(218, 36);
            this.rbnGamingMusicComputers.Name = "rbnGamingMusicComputers";
            this.rbnGamingMusicComputers.Size = new System.Drawing.Size(204, 24);
            this.rbnGamingMusicComputers.TabIndex = 11;
            this.rbnGamingMusicComputers.Text = "Gaming/Music/Computers";
            this.rbnGamingMusicComputers.UseVisualStyleBackColor = true;
            // 
            // rbnSmartHome
            // 
            this.rbnSmartHome.AutoSize = true;
            this.rbnSmartHome.Location = new System.Drawing.Point(19, 66);
            this.rbnSmartHome.Name = "rbnSmartHome";
            this.rbnSmartHome.Size = new System.Drawing.Size(191, 24);
            this.rbnSmartHome.TabIndex = 10;
            this.rbnSmartHome.Text = "Smart Home Appliances";
            this.rbnSmartHome.UseVisualStyleBackColor = true;
            // 
            // rbnPhotoVideoNav
            // 
            this.rbnPhotoVideoNav.AutoSize = true;
            this.rbnPhotoVideoNav.Location = new System.Drawing.Point(19, 36);
            this.rbnPhotoVideoNav.Name = "rbnPhotoVideoNav";
            this.rbnPhotoVideoNav.Size = new System.Drawing.Size(193, 24);
            this.rbnPhotoVideoNav.TabIndex = 12;
            this.rbnPhotoVideoNav.Text = "Photo/Video/Navigation";
            this.rbnPhotoVideoNav.UseVisualStyleBackColor = true;
            // 
            // FormDepotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 541);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDepotManager";
            this.Text = "FormDepotManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateNewEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.RadioButton rbnDepotEmployees;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmployees;
        private System.Windows.Forms.Button btnUpdateEmployees;
        private System.Windows.Forms.Button btnReadEmployees;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnPhotoVideoNav;
        private System.Windows.Forms.RadioButton rbnGamingMusicComputers;
        private System.Windows.Forms.RadioButton rbnSmartHome;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.RadioButton rbnKitchenHome;
        private System.Windows.Forms.RadioButton rbnAllProducts;
    }
}
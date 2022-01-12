﻿
namespace AdminBackups
{
    partial class FormProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbxSelectedProduct = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.labProductSearch = new System.Windows.Forms.Label();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSupplierSearch = new System.Windows.Forms.TextBox();
            this.cbxSupplierType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.btnOrderInfo = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxBuildingNumber = new System.Windows.Forms.TextBox();
            this.tbxBankNumber = new System.Windows.Forms.TextBox();
            this.tbxSupplierName = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 529);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbxSelectedProduct);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.labProductSearch);
            this.tabPage3.Controls.Add(this.tbProductSearch);
            this.tabPage3.Controls.Add(this.dgvProducts);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1130, 499);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbxSelectedProduct
            // 
            this.tbxSelectedProduct.Location = new System.Drawing.Point(904, 21);
            this.tbxSelectedProduct.Name = "tbxSelectedProduct";
            this.tbxSelectedProduct.PlaceholderText = "Selected Product";
            this.tbxSelectedProduct.ReadOnly = true;
            this.tbxSelectedProduct.Size = new System.Drawing.Size(169, 29);
            this.tbxSelectedProduct.TabIndex = 103;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntUpdateProduct);
            this.groupBox4.Controls.Add(this.btnDeleteProduct);
            this.groupBox4.Controls.Add(this.btnCreateProduct);
            this.groupBox4.Location = new System.Drawing.Point(899, 57);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(182, 133);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Products";
            // 
            // bntUpdateProduct
            // 
            this.bntUpdateProduct.Location = new System.Drawing.Point(6, 56);
            this.bntUpdateProduct.Name = "bntUpdateProduct";
            this.bntUpdateProduct.Size = new System.Drawing.Size(167, 31);
            this.bntUpdateProduct.TabIndex = 9;
            this.bntUpdateProduct.Text = "Update Product";
            this.bntUpdateProduct.UseVisualStyleBackColor = true;
            this.bntUpdateProduct.Click += new System.EventHandler(this.bntUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(5, 92);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(168, 31);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(6, 20);
            this.btnCreateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(168, 31);
            this.btnCreateProduct.TabIndex = 1;
            this.btnCreateProduct.Text = "Add New Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // labProductSearch
            // 
            this.labProductSearch.AutoSize = true;
            this.labProductSearch.Location = new System.Drawing.Point(394, 21);
            this.labProductSearch.Name = "labProductSearch";
            this.labProductSearch.Size = new System.Drawing.Size(118, 21);
            this.labProductSearch.TabIndex = 101;
            this.labProductSearch.Text = "Search Product:";
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Location = new System.Drawing.Point(518, 18);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.PlaceholderText = "Product Name or Barcode";
            this.tbProductSearch.Size = new System.Drawing.Size(268, 29);
            this.tbProductSearch.TabIndex = 100;
            this.tbProductSearch.TextChanged += new System.EventHandler(this.tbProductSearch_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(31, 57);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(862, 392);
            this.dgvProducts.TabIndex = 44;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product List:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.cbxSupplierType);
            this.tabPage1.Controls.Add(this.tbxSupplierSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvSuppliers);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1130, 499);
            this.tabPage1.TabIndex = 11;
            this.tabPage1.Text = "Supplier";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1130, 499);
            this.tabPage2.TabIndex = 12;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1064, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 33);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(16, 49);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowTemplate.Height = 25;
            this.dgvSuppliers.Size = new System.Drawing.Size(721, 388);
            this.dgvSuppliers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suppliers:";
            // 
            // tbxSupplierSearch
            // 
            this.tbxSupplierSearch.Location = new System.Drawing.Point(555, 19);
            this.tbxSupplierSearch.Name = "tbxSupplierSearch";
            this.tbxSupplierSearch.PlaceholderText = "Search supplier name";
            this.tbxSupplierSearch.Size = new System.Drawing.Size(182, 25);
            this.tbxSupplierSearch.TabIndex = 2;
            // 
            // cbxSupplierType
            // 
            this.cbxSupplierType.FormattingEnabled = true;
            this.cbxSupplierType.Items.AddRange(new object[] {
            "All suppliers",
            "KITCHEN_HOME",
            "PHOTO_VIDEO_NAVIGATION",
            "SMART_HOME_APPLIANCES",
            "GAMING_MUSIC_COMPUTERS"});
            this.cbxSupplierType.Location = new System.Drawing.Point(117, 19);
            this.cbxSupplierType.Name = "cbxSupplierType";
            this.cbxSupplierType.Size = new System.Drawing.Size(163, 25);
            this.cbxSupplierType.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddNewOrder);
            this.groupBox3.Controls.Add(this.btnOrderInfo);
            this.groupBox3.Controls.Add(this.btnAddSupplier);
            this.groupBox3.Controls.Add(this.tbxPostalCode);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.tbxCountry);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.tbxPhoneNumber);
            this.groupBox3.Controls.Add(this.tbxEmail);
            this.groupBox3.Controls.Add(this.tbxBuildingNumber);
            this.groupBox3.Controls.Add(this.tbxBankNumber);
            this.groupBox3.Controls.Add(this.tbxSupplierName);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.btnEditSupplier);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.btnRemoveSupplier);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(761, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 383);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier Management";
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewOrder.Location = new System.Drawing.Point(220, 337);
            this.btnAddNewOrder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(126, 30);
            this.btnAddNewOrder.TabIndex = 110;
            this.btnAddNewOrder.Text = "Add New Order";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            // 
            // btnOrderInfo
            // 
            this.btnOrderInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrderInfo.Location = new System.Drawing.Point(90, 337);
            this.btnOrderInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnOrderInfo.Name = "btnOrderInfo";
            this.btnOrderInfo.Size = new System.Drawing.Size(126, 30);
            this.btnOrderInfo.TabIndex = 109;
            this.btnOrderInfo.Text = "Order Info";
            this.btnOrderInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSupplier.Location = new System.Drawing.Point(208, 228);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(127, 30);
            this.btnAddSupplier.TabIndex = 108;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPostalCode.Location = new System.Drawing.Point(264, 126);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(71, 25);
            this.tbxPostalCode.TabIndex = 107;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(195, 129);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 106;
            this.label17.Text = "Zip Code:";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxCountry.Location = new System.Drawing.Point(137, 95);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(198, 25);
            this.tbxCountry.TabIndex = 105;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(76, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 104;
            this.label16.Text = "Country:";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPhoneNumber.Location = new System.Drawing.Point(137, 189);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(198, 25);
            this.tbxPhoneNumber.TabIndex = 102;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxEmail.Location = new System.Drawing.Point(137, 158);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(198, 25);
            this.tbxEmail.TabIndex = 101;
            // 
            // tbxBuildingNumber
            // 
            this.tbxBuildingNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBuildingNumber.Location = new System.Drawing.Point(137, 126);
            this.tbxBuildingNumber.Name = "tbxBuildingNumber";
            this.tbxBuildingNumber.Size = new System.Drawing.Size(53, 25);
            this.tbxBuildingNumber.TabIndex = 100;
            // 
            // tbxBankNumber
            // 
            this.tbxBankNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxBankNumber.Location = new System.Drawing.Point(137, 64);
            this.tbxBankNumber.Name = "tbxBankNumber";
            this.tbxBankNumber.Size = new System.Drawing.Size(198, 25);
            this.tbxBankNumber.TabIndex = 99;
            // 
            // tbxSupplierName
            // 
            this.tbxSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSupplierName.Location = new System.Drawing.Point(137, 33);
            this.tbxSupplierName.Name = "tbxSupplierName";
            this.tbxSupplierName.Size = new System.Drawing.Size(198, 25);
            this.tbxSupplierName.TabIndex = 98;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(33, 192);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(99, 17);
            this.label31.TabIndex = 96;
            this.label31.Text = "Phone Number:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(90, 161);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 17);
            this.label29.TabIndex = 94;
            this.label29.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(86, 36);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 17);
            this.label20.TabIndex = 89;
            this.label20.Text = "Name:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(42, 67);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 17);
            this.label25.TabIndex = 87;
            this.label25.Text = "Bank Number:";
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSupplier.Location = new System.Drawing.Point(220, 273);
            this.btnEditSupplier.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(127, 30);
            this.btnEditSupplier.TabIndex = 70;
            this.btnEditSupplier.Text = "Update Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(23, 129);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 17);
            this.label26.TabIndex = 79;
            this.label26.Text = "Building Number:";
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSupplier.Location = new System.Drawing.Point(158, 305);
            this.btnRemoveSupplier.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(127, 30);
            this.btnRemoveSupplier.TabIndex = 84;
            this.btnRemoveSupplier.Text = "Remove Supplier";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            // 
            // FormProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProductManager";
            this.Text = "ProductManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox lbProductType;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.TextBox cbProductType;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label labProductSearch;
        private System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bntUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.TextBox tbxSelectedProduct;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbxSupplierType;
        private System.Windows.Forms.TextBox tbxSupplierSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.Button btnOrderInfo;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxBuildingNumber;
        private System.Windows.Forms.TextBox tbxBankNumber;
        private System.Windows.Forms.TextBox tbxSupplierName;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnRemoveSupplier;
    }
}
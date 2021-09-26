
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
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbAmountInDepot = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPorduct = new System.Windows.Forms.Button();
            this.tbmountInStore = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbRestockID = new System.Windows.Forms.TextBox();
            this.tbRestockName = new System.Windows.Forms.TextBox();
            this.tbRestockAmountSales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRestockAmount = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnViewAllRestockRequests = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFufillRestockRequest = new System.Windows.Forms.Button();
            this.RestockAmountDepot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbRestock = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.tbRName = new System.Windows.Forms.TextBox();
            this.tbRamountInStore = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbReshelfReqAmount = new System.Windows.Forms.TextBox();
            this.tbRID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnViewAllReShelftReq = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnFufillReshelftRequest = new System.Windows.Forms.Button();
            this.tbRAmountInDepot = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbReshelfRequest = new System.Windows.Forms.ListBox();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(729, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 22);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1130, 473);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1122, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Employees";
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Location = new System.Drawing.Point(522, 82);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(168, 23);
            this.tbxEmployeeID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected Employee ID:";
            // 
            // btnDeleteEmployees
            // 
            this.btnDeleteEmployees.Location = new System.Drawing.Point(522, 222);
            this.btnDeleteEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployees.Name = "btnDeleteEmployees";
            this.btnDeleteEmployees.Size = new System.Drawing.Size(168, 31);
            this.btnDeleteEmployees.TabIndex = 7;
            this.btnDeleteEmployees.Text = "Delete Employees";
            this.btnDeleteEmployees.UseVisualStyleBackColor = true;
            this.btnDeleteEmployees.Click += new System.EventHandler(this.btnDeleteEmployees_Click);
            // 
            // btnUpdateEmployees
            // 
            this.btnUpdateEmployees.Location = new System.Drawing.Point(522, 187);
            this.btnUpdateEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployees.Name = "btnUpdateEmployees";
            this.btnUpdateEmployees.Size = new System.Drawing.Size(168, 31);
            this.btnUpdateEmployees.TabIndex = 6;
            this.btnUpdateEmployees.Text = "Update Employees";
            this.btnUpdateEmployees.UseVisualStyleBackColor = true;
            this.btnUpdateEmployees.Click += new System.EventHandler(this.btnUpdateEmployees_Click);
            // 
            // btnReadEmployees
            // 
            this.btnReadEmployees.Location = new System.Drawing.Point(522, 152);
            this.btnReadEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadEmployees.Name = "btnReadEmployees";
            this.btnReadEmployees.Size = new System.Drawing.Size(168, 31);
            this.btnReadEmployees.TabIndex = 5;
            this.btnReadEmployees.Text = "Read Employees";
            this.btnReadEmployees.UseVisualStyleBackColor = true;
            this.btnReadEmployees.Click += new System.EventHandler(this.btnReadEmployees_Click);
            // 
            // btnCreateNewEmployee
            // 
            this.btnCreateNewEmployee.Location = new System.Drawing.Point(522, 116);
            this.btnCreateNewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            this.btnCreateNewEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnCreateNewEmployee.TabIndex = 1;
            this.btnCreateNewEmployee.Text = "Create New Employee";
            this.btnCreateNewEmployee.UseVisualStyleBackColor = true;
            this.btnCreateNewEmployee.Click += new System.EventHandler(this.btnCreateNewEmployee_Click);
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 15;
            this.lbxEmployees.Location = new System.Drawing.Point(17, 58);
            this.lbxEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(476, 274);
            this.lbxEmployees.TabIndex = 4;
            this.lbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lbxEmployees_SelectedIndexChanged);
            // 
            // rbnDepotEmployees
            // 
            this.rbnDepotEmployees.AutoSize = true;
            this.rbnDepotEmployees.Checked = true;
            this.rbnDepotEmployees.Location = new System.Drawing.Point(144, 28);
            this.rbnDepotEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnDepotEmployees.Name = "rbnDepotEmployees";
            this.rbnDepotEmployees.Size = new System.Drawing.Size(117, 19);
            this.rbnDepotEmployees.TabIndex = 2;
            this.rbnDepotEmployees.TabStop = true;
            this.rbnDepotEmployees.Text = "Depot employees";
            this.rbnDepotEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnAllEmployees
            // 
            this.rbnAllEmployees.AutoSize = true;
            this.rbnAllEmployees.Location = new System.Drawing.Point(17, 27);
            this.rbnAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnAllEmployees.Name = "rbnAllEmployees";
            this.rbnAllEmployees.Size = new System.Drawing.Size(99, 19);
            this.rbnAllEmployees.TabIndex = 0;
            this.rbnAllEmployees.Text = "All employees";
            this.rbnAllEmployees.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1130, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(10, 22);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbProducts);
            this.tabPage3.Controls.Add(this.cbProductType);
            this.tabPage3.Controls.Add(this.tbName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblName);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbBarcode);
            this.tabPage3.Controls.Add(this.tbAmountInDepot);
            this.tabPage3.Controls.Add(this.lblEmail);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnAddPorduct);
            this.tabPage3.Controls.Add(this.tbmountInStore);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnGet);
            this.tabPage3.Controls.Add(this.btnEdit);
            this.tabPage3.Controls.Add(this.lblId);
            this.tabPage3.Controls.Add(this.tbID);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1130, 473);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 21;
            this.lbProducts.Location = new System.Drawing.Point(28, 44);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(736, 403);
            this.lbProducts.TabIndex = 45;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // cbProductType
            // 
            this.cbProductType.AllowDrop = true;
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(921, 182);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(161, 29);
            this.cbProductType.TabIndex = 44;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(920, 97);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(162, 29);
            this.tbName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Product type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(850, 103);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 21);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Amount in depot:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(920, 140);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(162, 29);
            this.tbBarcode.TabIndex = 31;
            // 
            // tbAmountInDepot
            // 
            this.tbAmountInDepot.Location = new System.Drawing.Point(921, 267);
            this.tbAmountInDepot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAmountInDepot.Name = "tbAmountInDepot";
            this.tbAmountInDepot.Size = new System.Drawing.Size(162, 29);
            this.tbAmountInDepot.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(836, 146);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 21);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Barcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(793, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Amount in store:";
            // 
            // btnAddPorduct
            // 
            this.btnAddPorduct.Location = new System.Drawing.Point(833, 355);
            this.btnAddPorduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddPorduct.Name = "btnAddPorduct";
            this.btnAddPorduct.Size = new System.Drawing.Size(236, 30);
            this.btnAddPorduct.TabIndex = 33;
            this.btnAddPorduct.Text = "Add Product";
            this.btnAddPorduct.UseVisualStyleBackColor = true;
            this.btnAddPorduct.Click += new System.EventHandler(this.btnAddPorduct_Click);
            // 
            // tbmountInStore
            // 
            this.tbmountInStore.Location = new System.Drawing.Point(921, 223);
            this.tbmountInStore.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbmountInStore.Name = "tbmountInStore";
            this.tbmountInStore.Size = new System.Drawing.Size(162, 29);
            this.tbmountInStore.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(832, 419);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(236, 30);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Remove Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(833, 323);
            this.btnGet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(236, 30);
            this.btnGet.TabIndex = 38;
            this.btnGet.Text = "ViewAllProducts";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(832, 387);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(236, 30);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit Product";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(877, 63);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 37;
            this.lblId.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(920, 57);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(162, 29);
            this.tbID.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Product List:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbRestockID);
            this.tabPage4.Controls.Add(this.tbRestockName);
            this.tabPage4.Controls.Add(this.tbRestockAmountSales);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.tbRestockAmount);
            this.tabPage4.Controls.Add(this.tbProductID);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnViewAllRestockRequests);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.btnFufillRestockRequest);
            this.tabPage4.Controls.Add(this.RestockAmountDepot);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.lbRestock);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1130, 473);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Restock";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbRestockID
            // 
            this.tbRestockID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockID.Location = new System.Drawing.Point(936, 127);
            this.tbRestockID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockID.Name = "tbRestockID";
            this.tbRestockID.ReadOnly = true;
            this.tbRestockID.Size = new System.Drawing.Size(162, 29);
            this.tbRestockID.TabIndex = 82;
            // 
            // tbRestockName
            // 
            this.tbRestockName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockName.Location = new System.Drawing.Point(936, 175);
            this.tbRestockName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockName.Name = "tbRestockName";
            this.tbRestockName.ReadOnly = true;
            this.tbRestockName.Size = new System.Drawing.Size(162, 29);
            this.tbRestockName.TabIndex = 81;
            // 
            // tbRestockAmountSales
            // 
            this.tbRestockAmountSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockAmountSales.Location = new System.Drawing.Point(936, 216);
            this.tbRestockAmountSales.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockAmountSales.Name = "tbRestockAmountSales";
            this.tbRestockAmountSales.ReadOnly = true;
            this.tbRestockAmountSales.Size = new System.Drawing.Size(162, 29);
            this.tbRestockAmountSales.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(866, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 79;
            this.label9.Text = "Amount:";
            // 
            // tbRestockAmount
            // 
            this.tbRestockAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockAmount.Location = new System.Drawing.Point(936, 295);
            this.tbRestockAmount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockAmount.Name = "tbRestockAmount";
            this.tbRestockAmount.ReadOnly = true;
            this.tbRestockAmount.Size = new System.Drawing.Size(162, 29);
            this.tbRestockAmount.TabIndex = 78;
            // 
            // tbProductID
            // 
            this.tbProductID.Enabled = false;
            this.tbProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProductID.Location = new System.Drawing.Point(936, 85);
            this.tbProductID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(162, 29);
            this.tbProductID.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(908, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 21);
            this.label10.TabIndex = 73;
            this.label10.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(885, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 21);
            this.label11.TabIndex = 68;
            this.label11.Text = "Name:";
            // 
            // btnViewAllRestockRequests
            // 
            this.btnViewAllRestockRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAllRestockRequests.Location = new System.Drawing.Point(878, 343);
            this.btnViewAllRestockRequests.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewAllRestockRequests.Name = "btnViewAllRestockRequests";
            this.btnViewAllRestockRequests.Size = new System.Drawing.Size(208, 30);
            this.btnViewAllRestockRequests.TabIndex = 74;
            this.btnViewAllRestockRequests.Text = "View all restock requests";
            this.btnViewAllRestockRequests.UseVisualStyleBackColor = true;
            this.btnViewAllRestockRequests.Click += new System.EventHandler(this.btnViewAllRestockRequests_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(806, 261);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 21);
            this.label12.TabIndex = 77;
            this.label12.Text = "Amount in depot:";
            // 
            // btnFufillRestockRequest
            // 
            this.btnFufillRestockRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFufillRestockRequest.Location = new System.Drawing.Point(878, 385);
            this.btnFufillRestockRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFufillRestockRequest.Name = "btnFufillRestockRequest";
            this.btnFufillRestockRequest.Size = new System.Drawing.Size(208, 30);
            this.btnFufillRestockRequest.TabIndex = 70;
            this.btnFufillRestockRequest.Text = "Fufill restock request";
            this.btnFufillRestockRequest.UseVisualStyleBackColor = true;
            this.btnFufillRestockRequest.Click += new System.EventHandler(this.btnFufillRestockRequest_Click);
            // 
            // RestockAmountDepot
            // 
            this.RestockAmountDepot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestockAmountDepot.Location = new System.Drawing.Point(936, 255);
            this.RestockAmountDepot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RestockAmountDepot.Name = "RestockAmountDepot";
            this.RestockAmountDepot.ReadOnly = true;
            this.RestockAmountDepot.Size = new System.Drawing.Size(162, 29);
            this.RestockAmountDepot.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(811, 222);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 21);
            this.label13.TabIndex = 75;
            this.label13.Text = "Amount in store:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(855, 134);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 21);
            this.label14.TabIndex = 69;
            this.label14.Text = "RequestID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(21, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 21);
            this.label15.TabIndex = 57;
            this.label15.Text = "Restock Requests List:";
            // 
            // lbRestock
            // 
            this.lbRestock.FormattingEnabled = true;
            this.lbRestock.ItemHeight = 15;
            this.lbRestock.Location = new System.Drawing.Point(18, 48);
            this.lbRestock.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbRestock.Name = "lbRestock";
            this.lbRestock.Size = new System.Drawing.Size(784, 409);
            this.lbRestock.TabIndex = 56;
            this.lbRestock.SelectedIndexChanged += new System.EventHandler(this.lbRestock_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbRequestID);
            this.tabPage5.Controls.Add(this.tbRName);
            this.tabPage5.Controls.Add(this.tbRamountInStore);
            this.tabPage5.Controls.Add(this.lbAmount);
            this.tabPage5.Controls.Add(this.tbReshelfReqAmount);
            this.tabPage5.Controls.Add(this.tbRID);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.btnDeleteRequest);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.btnViewAllReShelftReq);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.btnFufillReshelftRequest);
            this.tabPage5.Controls.Add(this.tbRAmountInDepot);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.lbReshelfRequest);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1130, 473);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Reshelf";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbRequestID
            // 
            this.tbRequestID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRequestID.Location = new System.Drawing.Point(927, 123);
            this.tbRequestID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(162, 29);
            this.tbRequestID.TabIndex = 73;
            // 
            // tbRName
            // 
            this.tbRName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRName.Location = new System.Drawing.Point(927, 165);
            this.tbRName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRName.Name = "tbRName";
            this.tbRName.ReadOnly = true;
            this.tbRName.Size = new System.Drawing.Size(162, 29);
            this.tbRName.TabIndex = 72;
            // 
            // tbRamountInStore
            // 
            this.tbRamountInStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRamountInStore.Location = new System.Drawing.Point(927, 208);
            this.tbRamountInStore.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRamountInStore.Name = "tbRamountInStore";
            this.tbRamountInStore.ReadOnly = true;
            this.tbRamountInStore.Size = new System.Drawing.Size(162, 29);
            this.tbRamountInStore.TabIndex = 71;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAmount.Location = new System.Drawing.Point(849, 298);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(69, 21);
            this.lbAmount.TabIndex = 70;
            this.lbAmount.Text = "Amount:";
            // 
            // tbReshelfReqAmount
            // 
            this.tbReshelfReqAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReshelfReqAmount.Location = new System.Drawing.Point(927, 292);
            this.tbReshelfReqAmount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbReshelfReqAmount.Name = "tbReshelfReqAmount";
            this.tbReshelfReqAmount.ReadOnly = true;
            this.tbReshelfReqAmount.Size = new System.Drawing.Size(162, 29);
            this.tbReshelfReqAmount.TabIndex = 69;
            // 
            // tbRID
            // 
            this.tbRID.Enabled = false;
            this.tbRID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRID.Location = new System.Drawing.Point(927, 79);
            this.tbRID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRID.Name = "tbRID";
            this.tbRID.ReadOnly = true;
            this.tbRID.Size = new System.Drawing.Size(162, 29);
            this.tbRID.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(890, 85);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 21);
            this.label17.TabIndex = 64;
            this.label17.Text = "ID:";
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRequest.Location = new System.Drawing.Point(848, 435);
            this.btnDeleteRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(207, 30);
            this.btnDeleteRequest.TabIndex = 62;
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            this.btnDeleteRequest.Click += new System.EventHandler(this.btnDeleteRequest_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(863, 171);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 21);
            this.label18.TabIndex = 59;
            this.label18.Text = "Name:";
            // 
            // btnViewAllReShelftReq
            // 
            this.btnViewAllReShelftReq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAllReShelftReq.Location = new System.Drawing.Point(848, 348);
            this.btnViewAllReShelftReq.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewAllReShelftReq.Name = "btnViewAllReShelftReq";
            this.btnViewAllReShelftReq.Size = new System.Drawing.Size(207, 30);
            this.btnViewAllReShelftReq.TabIndex = 65;
            this.btnViewAllReShelftReq.Text = "View all reshelf requests";
            this.btnViewAllReShelftReq.UseVisualStyleBackColor = true;
            this.btnViewAllReShelftReq.Click += new System.EventHandler(this.btnViewAllReShelftReq_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(788, 257);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 21);
            this.label19.TabIndex = 68;
            this.label19.Text = "Amount in depot:";
            // 
            // btnFufillReshelftRequest
            // 
            this.btnFufillReshelftRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFufillReshelftRequest.Location = new System.Drawing.Point(848, 393);
            this.btnFufillReshelftRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFufillReshelftRequest.Name = "btnFufillReshelftRequest";
            this.btnFufillReshelftRequest.Size = new System.Drawing.Size(207, 30);
            this.btnFufillReshelftRequest.TabIndex = 61;
            this.btnFufillReshelftRequest.Text = "Fufill reshelf Request";
            this.btnFufillReshelftRequest.UseVisualStyleBackColor = true;
            this.btnFufillReshelftRequest.Click += new System.EventHandler(this.btnFufillReshelftRequest_Click);
            // 
            // tbRAmountInDepot
            // 
            this.tbRAmountInDepot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRAmountInDepot.Location = new System.Drawing.Point(927, 251);
            this.tbRAmountInDepot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRAmountInDepot.Name = "tbRAmountInDepot";
            this.tbRAmountInDepot.ReadOnly = true;
            this.tbRAmountInDepot.Size = new System.Drawing.Size(162, 29);
            this.tbRAmountInDepot.TabIndex = 67;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(793, 214);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 21);
            this.label20.TabIndex = 66;
            this.label20.Text = "Amount in store:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(837, 129);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 21);
            this.label21.TabIndex = 60;
            this.label21.Text = "RequestID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(23, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 21);
            this.label16.TabIndex = 58;
            this.label16.Text = "ReshelfRequests List:";
            // 
            // lbReshelfRequest
            // 
            this.lbReshelfRequest.FormattingEnabled = true;
            this.lbReshelfRequest.ItemHeight = 15;
            this.lbReshelfRequest.Location = new System.Drawing.Point(20, 43);
            this.lbReshelfRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbReshelfRequest.Name = "lbReshelfRequest";
            this.lbReshelfRequest.Size = new System.Drawing.Size(731, 409);
            this.lbReshelfRequest.TabIndex = 36;
            this.lbReshelfRequest.SelectedIndexChanged += new System.EventHandler(this.lbReshelfRequest_SelectedIndexChanged);
            // 
            // FormDepotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 560);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDepotManager";
            this.Text = "FormDepotManager";
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmployees;
        private System.Windows.Forms.Button btnUpdateEmployees;
        private System.Windows.Forms.Button btnReadEmployees;
        private System.Windows.Forms.Button btnCreateNewEmployee;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.RadioButton rbnDepotEmployees;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbAmountInDepot;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddPorduct;
        private System.Windows.Forms.TextBox tbmountInStore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbRestockID;
        private System.Windows.Forms.TextBox tbRestockName;
        private System.Windows.Forms.TextBox tbRestockAmountSales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRestockAmount;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnViewAllRestockRequests;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFufillRestockRequest;
        private System.Windows.Forms.TextBox RestockAmountDepot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbRestock;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.TextBox tbRName;
        private System.Windows.Forms.TextBox tbRamountInStore;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbReshelfReqAmount;
        private System.Windows.Forms.TextBox tbRID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnViewAllReShelftReq;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnFufillReshelftRequest;
        private System.Windows.Forms.TextBox tbRAmountInDepot;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lbReshelfRequest;
    }
}
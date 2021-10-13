﻿
namespace MediaBazaar
{
    partial class SalesManager
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.btnReadEmployee = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.rbnSalesEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.sdfds = new System.Windows.Forms.GroupBox();
            this.btnViewPorducts = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
            this.btnRequestReplenishment = new System.Windows.Forms.Button();
            this.lbProductType = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbAmountInDepot = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmountInStore = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbScheduleEvening = new System.Windows.Forms.TextBox();
            this.lbScheduleAfternoon = new System.Windows.Forms.TextBox();
            this.lbScheduleMorning = new System.Windows.Forms.TextBox();
            this.lbScheduleDay = new System.Windows.Forms.TextBox();
            this.lbScheduleDepartment = new System.Windows.Forms.TextBox();
            this.lbScheduleID = new System.Windows.Forms.TextBox();
            this.btnEditschedule = new System.Windows.Forms.Button();
            this.btViewSchedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbSchedule = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.label31 = new System.Windows.Forms.Label();
            this.lbPlaning = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbWorkId = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnEditPlaning = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbDep = new System.Windows.Forms.TextBox();
            this.tbNewEmployeeId = new System.Windows.Forms.TextBox();
            this.btnViewSalesPlan = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.sdfds.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tpSchedule);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(11, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1113, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee overview";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteEmployee);
            this.groupBox4.Controls.Add(this.tbxEmployeeID);
            this.groupBox4.Controls.Add(this.btnReadEmployee);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnUpdateEmployee);
            this.groupBox4.Controls.Add(this.btnCreateEmployee);
            this.groupBox4.Location = new System.Drawing.Point(863, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(244, 501);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Employees";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(34, 180);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.Text = "Delete Employees";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Location = new System.Drawing.Point(34, 50);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(168, 23);
            this.tbxEmployeeID.TabIndex = 9;
            // 
            // btnReadEmployee
            // 
            this.btnReadEmployee.Location = new System.Drawing.Point(34, 110);
            this.btnReadEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadEmployee.Name = "btnReadEmployee";
            this.btnReadEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnReadEmployee.TabIndex = 5;
            this.btnReadEmployee.Text = "Read Employees";
            this.btnReadEmployee.UseVisualStyleBackColor = true;
            this.btnReadEmployee.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Selected Employee ID:";
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(34, 145);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnUpdateEmployee.TabIndex = 6;
            this.btnUpdateEmployee.Text = "Update Employees";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(34, 74);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnCreateEmployee.TabIndex = 1;
            this.btnCreateEmployee.Text = "Create New Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxEmployees);
            this.groupBox1.Controls.Add(this.rbnSalesEmployees);
            this.groupBox1.Controls.Add(this.rbnAllEmployees);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(851, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Employees";
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 15;
            this.lbxEmployees.Location = new System.Drawing.Point(17, 58);
            this.lbxEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(828, 439);
            this.lbxEmployees.TabIndex = 4;
            this.lbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lbxEmployees_SelectedIndexChanged);
            // 
            // rbnSalesEmployees
            // 
            this.rbnSalesEmployees.AutoSize = true;
            this.rbnSalesEmployees.Checked = true;
            this.rbnSalesEmployees.Location = new System.Drawing.Point(145, 26);
            this.rbnSalesEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnSalesEmployees.Name = "rbnSalesEmployees";
            this.rbnSalesEmployees.Size = new System.Drawing.Size(111, 19);
            this.rbnSalesEmployees.TabIndex = 2;
            this.rbnSalesEmployees.TabStop = true;
            this.rbnSalesEmployees.Text = "Sales employees";
            this.rbnSalesEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnAllEmployees
            // 
            this.rbnAllEmployees.AutoSize = true;
            this.rbnAllEmployees.Location = new System.Drawing.Point(17, 26);
            this.rbnAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnAllEmployees.Name = "rbnAllEmployees";
            this.rbnAllEmployees.Size = new System.Drawing.Size(99, 19);
            this.rbnAllEmployees.TabIndex = 0;
            this.rbnAllEmployees.Text = "All employees";
            this.rbnAllEmployees.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.lstProduct);
            this.tabPage4.Controls.Add(this.sdfds);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1113, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Products ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product List:";
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 17;
            this.lstProduct.Location = new System.Drawing.Point(22, 39);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(700, 429);
            this.lstProduct.TabIndex = 15;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // sdfds
            // 
            this.sdfds.Controls.Add(this.btnViewPorducts);
            this.sdfds.Controls.Add(this.tbAmount);
            this.sdfds.Controls.Add(this.Amount);
            this.sdfds.Controls.Add(this.btnRequestReplenishment);
            this.sdfds.Controls.Add(this.lbProductType);
            this.sdfds.Controls.Add(this.tbName);
            this.sdfds.Controls.Add(this.label4);
            this.sdfds.Controls.Add(this.lblName);
            this.sdfds.Controls.Add(this.label6);
            this.sdfds.Controls.Add(this.tbBarcode);
            this.sdfds.Controls.Add(this.tbAmountInDepot);
            this.sdfds.Controls.Add(this.lblEmail);
            this.sdfds.Controls.Add(this.label5);
            this.sdfds.Controls.Add(this.tbmountInStore);
            this.sdfds.Controls.Add(this.lblId);
            this.sdfds.Controls.Add(this.tbID);
            this.sdfds.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sdfds.Location = new System.Drawing.Point(748, 39);
            this.sdfds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdfds.Name = "sdfds";
            this.sdfds.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdfds.Size = new System.Drawing.Size(326, 429);
            this.sdfds.TabIndex = 3;
            this.sdfds.TabStop = false;
            this.sdfds.Text = "Replenishment";
            // 
            // btnViewPorducts
            // 
            this.btnViewPorducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewPorducts.Location = new System.Drawing.Point(33, 384);
            this.btnViewPorducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPorducts.Name = "btnViewPorducts";
            this.btnViewPorducts.Size = new System.Drawing.Size(265, 31);
            this.btnViewPorducts.TabIndex = 5;
            this.btnViewPorducts.Text = "View all products";
            this.btnViewPorducts.UseVisualStyleBackColor = true;
            this.btnViewPorducts.Click += new System.EventHandler(this.btnViewPorducts_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmount.Location = new System.Drawing.Point(148, 292);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(162, 26);
            this.tbAmount.TabIndex = 58;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amount.Location = new System.Drawing.Point(54, 291);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(73, 20);
            this.Amount.TabIndex = 57;
            this.Amount.Text = "Amount: ";
            // 
            // btnRequestReplenishment
            // 
            this.btnRequestReplenishment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRequestReplenishment.Location = new System.Drawing.Point(33, 335);
            this.btnRequestReplenishment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequestReplenishment.Name = "btnRequestReplenishment";
            this.btnRequestReplenishment.Size = new System.Drawing.Size(265, 34);
            this.btnRequestReplenishment.TabIndex = 2;
            this.btnRequestReplenishment.Text = "Request reshelf";
            this.btnRequestReplenishment.UseVisualStyleBackColor = true;
            this.btnRequestReplenishment.Click += new System.EventHandler(this.btnRequestReplenishment_Click);
            // 
            // lbProductType
            // 
            this.lbProductType.Enabled = false;
            this.lbProductType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductType.Location = new System.Drawing.Point(148, 165);
            this.lbProductType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbProductType.Name = "lbProductType";
            this.lbProductType.ReadOnly = true;
            this.lbProductType.Size = new System.Drawing.Size(162, 29);
            this.lbProductType.TabIndex = 56;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(149, 78);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(162, 29);
            this.tbName.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 55;
            this.label4.Text = "Product type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(79, 80);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 21);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Amount in depot:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBarcode.Location = new System.Drawing.Point(148, 120);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.ReadOnly = true;
            this.tbBarcode.Size = new System.Drawing.Size(162, 29);
            this.tbBarcode.TabIndex = 47;
            // 
            // tbAmountInDepot
            // 
            this.tbAmountInDepot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmountInDepot.Location = new System.Drawing.Point(149, 247);
            this.tbAmountInDepot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAmountInDepot.Name = "tbAmountInDepot";
            this.tbAmountInDepot.ReadOnly = true;
            this.tbAmountInDepot.Size = new System.Drawing.Size(162, 29);
            this.tbAmountInDepot.TabIndex = 53;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(65, 122);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 21);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Barcode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Amount in store:";
            // 
            // tbmountInStore
            // 
            this.tbmountInStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbmountInStore.Location = new System.Drawing.Point(148, 209);
            this.tbmountInStore.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbmountInStore.Name = "tbmountInStore";
            this.tbmountInStore.ReadOnly = true;
            this.tbmountInStore.Size = new System.Drawing.Size(162, 29);
            this.tbmountInStore.TabIndex = 51;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(105, 35);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(148, 33);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(162, 29);
            this.tbID.TabIndex = 49;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.groupBox2);
            this.tpSchedule.Controls.Add(this.lbSchedule);
            this.tpSchedule.Location = new System.Drawing.Point(4, 24);
            this.tpSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedule.Size = new System.Drawing.Size(1113, 508);
            this.tpSchedule.TabIndex = 4;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbScheduleEvening);
            this.groupBox2.Controls.Add(this.lbScheduleAfternoon);
            this.groupBox2.Controls.Add(this.lbScheduleMorning);
            this.groupBox2.Controls.Add(this.lbScheduleDay);
            this.groupBox2.Controls.Add(this.lbScheduleDepartment);
            this.groupBox2.Controls.Add(this.lbScheduleID);
            this.groupBox2.Controls.Add(this.btnEditschedule);
            this.groupBox2.Controls.Add(this.btViewSchedule);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(744, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 414);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbScheduleEvening
            // 
            this.lbScheduleEvening.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleEvening.Location = new System.Drawing.Point(153, 228);
            this.lbScheduleEvening.Name = "lbScheduleEvening";
            this.lbScheduleEvening.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleEvening.TabIndex = 20;
            // 
            // lbScheduleAfternoon
            // 
            this.lbScheduleAfternoon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleAfternoon.Location = new System.Drawing.Point(153, 190);
            this.lbScheduleAfternoon.Name = "lbScheduleAfternoon";
            this.lbScheduleAfternoon.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleAfternoon.TabIndex = 19;
            // 
            // lbScheduleMorning
            // 
            this.lbScheduleMorning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleMorning.Location = new System.Drawing.Point(153, 151);
            this.lbScheduleMorning.Name = "lbScheduleMorning";
            this.lbScheduleMorning.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleMorning.TabIndex = 18;
            // 
            // lbScheduleDay
            // 
            this.lbScheduleDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDay.Location = new System.Drawing.Point(153, 112);
            this.lbScheduleDay.Name = "lbScheduleDay";
            this.lbScheduleDay.ReadOnly = true;
            this.lbScheduleDay.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleDay.TabIndex = 17;
            // 
            // lbScheduleDepartment
            // 
            this.lbScheduleDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDepartment.Location = new System.Drawing.Point(153, 74);
            this.lbScheduleDepartment.Name = "lbScheduleDepartment";
            this.lbScheduleDepartment.ReadOnly = true;
            this.lbScheduleDepartment.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleDepartment.TabIndex = 16;
            // 
            // lbScheduleID
            // 
            this.lbScheduleID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleID.Location = new System.Drawing.Point(153, 35);
            this.lbScheduleID.Name = "lbScheduleID";
            this.lbScheduleID.ReadOnly = true;
            this.lbScheduleID.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleID.TabIndex = 15;
            // 
            // btnEditschedule
            // 
            this.btnEditschedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditschedule.Location = new System.Drawing.Point(79, 353);
            this.btnEditschedule.Name = "btnEditschedule";
            this.btnEditschedule.Size = new System.Drawing.Size(215, 34);
            this.btnEditschedule.TabIndex = 14;
            this.btnEditschedule.Text = "Edit schedule";
            this.btnEditschedule.UseVisualStyleBackColor = true;
            this.btnEditschedule.Click += new System.EventHandler(this.btnEditschedule_Click);
            // 
            // btViewSchedule
            // 
            this.btViewSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btViewSchedule.Location = new System.Drawing.Point(79, 301);
            this.btViewSchedule.Name = "btViewSchedule";
            this.btViewSchedule.Size = new System.Drawing.Size(215, 34);
            this.btViewSchedule.TabIndex = 13;
            this.btViewSchedule.Text = "View schedule";
            this.btViewSchedule.UseVisualStyleBackColor = true;
            this.btViewSchedule.Click += new System.EventHandler(this.btViewSchedule_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(79, 231);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 21);
            this.label24.TabIndex = 12;
            this.label24.Text = "Evening:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(64, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 21);
            this.label23.TabIndex = 11;
            this.label23.Text = "Afternoon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(77, 154);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 21);
            this.label22.TabIndex = 10;
            this.label22.Text = "Monday:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Day:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(54, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Schedule id:";
            // 
            // lbSchedule
            // 
            this.lbSchedule.FormattingEnabled = true;
            this.lbSchedule.ItemHeight = 15;
            this.lbSchedule.Location = new System.Drawing.Point(24, 40);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(668, 409);
            this.lbSchedule.TabIndex = 0;
            this.lbSchedule.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lbEmployee);
            this.tabPage7.Controls.Add(this.label31);
            this.tabPage7.Controls.Add(this.lbPlaning);
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1113, 508);
            this.tabPage7.TabIndex = 11;
            this.tabPage7.Text = "Planing";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lbEmployee
            // 
            this.lbEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmployee.FormattingEnabled = true;
            this.lbEmployee.ItemHeight = 15;
            this.lbEmployee.Location = new System.Drawing.Point(373, 60);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(347, 424);
            this.lbEmployee.TabIndex = 62;
            this.lbEmployee.SelectedIndexChanged += new System.EventHandler(this.lbEmployee_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(31, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 21);
            this.label31.TabIndex = 61;
            this.label31.Text = "Planing list:";
            // 
            // lbPlaning
            // 
            this.lbPlaning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPlaning.FormattingEnabled = true;
            this.lbPlaning.ItemHeight = 15;
            this.lbPlaning.Location = new System.Drawing.Point(25, 60);
            this.lbPlaning.Name = "lbPlaning";
            this.lbPlaning.Size = new System.Drawing.Size(342, 424);
            this.lbPlaning.TabIndex = 60;
            this.lbPlaning.SelectedIndexChanged += new System.EventHandler(this.lbPlaning_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbWorkId);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.btnEditPlaning);
            this.groupBox3.Controls.Add(this.tbTime);
            this.groupBox3.Controls.Add(this.tbDay);
            this.groupBox3.Controls.Add(this.tbDep);
            this.groupBox3.Controls.Add(this.tbNewEmployeeId);
            this.groupBox3.Controls.Add(this.btnViewSalesPlan);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Location = new System.Drawing.Point(743, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 382);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tbWorkId
            // 
            this.tbWorkId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWorkId.Location = new System.Drawing.Point(153, 45);
            this.tbWorkId.Name = "tbWorkId";
            this.tbWorkId.ReadOnly = true;
            this.tbWorkId.Size = new System.Drawing.Size(164, 29);
            this.tbWorkId.TabIndex = 25;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(45, 45);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 21);
            this.label34.TabIndex = 24;
            this.label34.Text = "Work id:";
            // 
            // btnEditPlaning
            // 
            this.btnEditPlaning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditPlaning.Location = new System.Drawing.Point(69, 264);
            this.btnEditPlaning.Name = "btnEditPlaning";
            this.btnEditPlaning.Size = new System.Drawing.Size(215, 34);
            this.btnEditPlaning.TabIndex = 23;
            this.btnEditPlaning.Text = "EditPlaning";
            this.btnEditPlaning.UseVisualStyleBackColor = true;
            this.btnEditPlaning.Click += new System.EventHandler(this.btnEditPlaning_Click);
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTime.Location = new System.Drawing.Point(153, 196);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(164, 29);
            this.tbTime.TabIndex = 18;
            // 
            // tbDay
            // 
            this.tbDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDay.Location = new System.Drawing.Point(153, 157);
            this.tbDay.Name = "tbDay";
            this.tbDay.ReadOnly = true;
            this.tbDay.Size = new System.Drawing.Size(164, 29);
            this.tbDay.TabIndex = 17;
            // 
            // tbDep
            // 
            this.tbDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDep.Location = new System.Drawing.Point(153, 119);
            this.tbDep.Name = "tbDep";
            this.tbDep.ReadOnly = true;
            this.tbDep.Size = new System.Drawing.Size(164, 29);
            this.tbDep.TabIndex = 16;
            // 
            // tbNewEmployeeId
            // 
            this.tbNewEmployeeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNewEmployeeId.Location = new System.Drawing.Point(153, 80);
            this.tbNewEmployeeId.Name = "tbNewEmployeeId";
            this.tbNewEmployeeId.ReadOnly = true;
            this.tbNewEmployeeId.Size = new System.Drawing.Size(164, 29);
            this.tbNewEmployeeId.TabIndex = 15;
            // 
            // btnViewSalesPlan
            // 
            this.btnViewSalesPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewSalesPlan.Location = new System.Drawing.Point(69, 317);
            this.btnViewSalesPlan.Name = "btnViewSalesPlan";
            this.btnViewSalesPlan.Size = new System.Drawing.Size(215, 34);
            this.btnViewSalesPlan.TabIndex = 13;
            this.btnViewSalesPlan.Text = "View sales planing";
            this.btnViewSalesPlan.UseVisualStyleBackColor = true;
            this.btnViewSalesPlan.Click += new System.EventHandler(this.btnViewSalesPlan_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(93, 199);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 21);
            this.label32.TabIndex = 10;
            this.label32.Text = "Shift:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(98, 157);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 21);
            this.label33.TabIndex = 9;
            this.label33.Text = "Day:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label38.Location = new System.Drawing.Point(42, 119);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(96, 21);
            this.label38.TabIndex = 8;
            this.label38.Text = "Department:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label39.Location = new System.Drawing.Point(45, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(98, 21);
            this.label39.TabIndex = 7;
            this.label39.Text = "Employee id:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(737, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 22);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(912, 2);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(79, 28);
            this.btnCheck.TabIndex = 22;
            this.btnCheck.Text = "Check In";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // FormSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 587);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSalesManager";
            this.Text = "FormSalesManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.sdfds.ResumeLayout(false);
            this.sdfds.PerformLayout();
            this.tpSchedule.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.RadioButton rbnSalesEmployees;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnViewPorducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRequestReplenishment;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.GroupBox sdfds;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox lbProductType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbAmountInDepot;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmountInStore;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditschedule;
        private System.Windows.Forms.Button btViewSchedule;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbSchedule;
        private System.Windows.Forms.TextBox lbScheduleEvening;
        private System.Windows.Forms.TextBox lbScheduleAfternoon;
        private System.Windows.Forms.TextBox lbScheduleMorning;
        private System.Windows.Forms.TextBox lbScheduleDay;
        private System.Windows.Forms.TextBox lbScheduleDepartment;
        private System.Windows.Forms.TextBox lbScheduleID;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListBox lbEmployee;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox lbPlaning;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbWorkId;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnEditPlaning;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbDep;
        private System.Windows.Forms.TextBox tbNewEmployeeId;
        private System.Windows.Forms.Button btnViewSalesPlan;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Button btnReadEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnCheck;
    }
}
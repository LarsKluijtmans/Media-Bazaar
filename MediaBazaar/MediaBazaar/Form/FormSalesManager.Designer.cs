
namespace MediaBazaar
{
    partial class FormSalesManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteEmployees = new System.Windows.Forms.Button();
            this.btnUpdateEmployees = new System.Windows.Forms.Button();
            this.btnReadEmployees = new System.Windows.Forms.Button();
            this.btnCreateNewEmployee = new System.Windows.Forms.Button();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.rbnSalesEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnViewPorducts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRequestReplenishment = new System.Windows.Forms.Button();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.sdfds = new System.Windows.Forms.GroupBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.Label();
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
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.sdfds.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(800, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee overview";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxEmployeeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDeleteEmployees);
            this.groupBox1.Controls.Add(this.btnUpdateEmployees);
            this.groupBox1.Controls.Add(this.btnReadEmployees);
            this.groupBox1.Controls.Add(this.btnCreateNewEmployee);
            this.groupBox1.Controls.Add(this.lbxEmployees);
            this.groupBox1.Controls.Add(this.rbnSalesEmployees);
            this.groupBox1.Controls.Add(this.rbnAllEmployees);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(789, 342);
            this.groupBox1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selected Employee ID:";
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
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(737, 2);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 22);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnViewPorducts);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.btnRequestReplenishment);
            this.tabPage4.Controls.Add(this.lstProduct);
            this.tabPage4.Controls.Add(this.sdfds);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(1073, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Products ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnViewPorducts
            // 
            this.btnViewPorducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewPorducts.Location = new System.Drawing.Point(748, 423);
            this.btnViewPorducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPorducts.Name = "btnViewPorducts";
            this.btnViewPorducts.Size = new System.Drawing.Size(265, 31);
            this.btnViewPorducts.TabIndex = 5;
            this.btnViewPorducts.Text = "View all products";
            this.btnViewPorducts.UseVisualStyleBackColor = true;
            this.btnViewPorducts.Click += new System.EventHandler(this.btnViewPorducts_Click);
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
            // btnRequestReplenishment
            // 
            this.btnRequestReplenishment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRequestReplenishment.Location = new System.Drawing.Point(748, 375);
            this.btnRequestReplenishment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRequestReplenishment.Name = "btnRequestReplenishment";
            this.btnRequestReplenishment.Size = new System.Drawing.Size(265, 34);
            this.btnRequestReplenishment.TabIndex = 2;
            this.btnRequestReplenishment.Text = "Request reshelf";
            this.btnRequestReplenishment.UseVisualStyleBackColor = true;
            this.btnRequestReplenishment.Click += new System.EventHandler(this.btnRequestReplenishment_Click);
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 17;
            this.lstProduct.Location = new System.Drawing.Point(22, 39);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(664, 429);
            this.lstProduct.TabIndex = 15;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // sdfds
            // 
            this.sdfds.Controls.Add(this.tbAmount);
            this.sdfds.Controls.Add(this.Amount);
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
            this.sdfds.Location = new System.Drawing.Point(710, 39);
            this.sdfds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdfds.Name = "sdfds";
            this.sdfds.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sdfds.Size = new System.Drawing.Size(326, 429);
            this.sdfds.TabIndex = 3;
            this.sdfds.TabStop = false;
            this.sdfds.Text = "Replenishment";
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
            // FormSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 587);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSalesManager";
            this.Text = "FormSalesManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.sdfds.ResumeLayout(false);
            this.sdfds.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteEmployees;
        private System.Windows.Forms.Button btnUpdateEmployees;
        private System.Windows.Forms.Button btnReadEmployees;
        private System.Windows.Forms.Button btnCreateNewEmployee;
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
    }
}
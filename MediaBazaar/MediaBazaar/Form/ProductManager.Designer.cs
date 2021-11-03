
namespace MediaBazaar
{
    partial class ProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstOverviewSchedule = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbAmountInDepot = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPorduct = new System.Windows.Forms.Button();
            this.tbmountInStore = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(14, 65);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1301, 684);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnProfile);
            this.tabPage1.Controls.Add(this.btnCheck);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lstOverviewSchedule);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1293, 650);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(890, 27);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(111, 73);
            this.btnProfile.TabIndex = 21;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(890, 493);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 73);
            this.btnCheck.TabIndex = 20;
            this.btnCheck.Text = "Check In";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Schedule:";
            // 
            // lstOverviewSchedule
            // 
            this.lstOverviewSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewSchedule.FormattingEnabled = true;
            this.lstOverviewSchedule.ItemHeight = 21;
            this.lstOverviewSchedule.Location = new System.Drawing.Point(22, 63);
            this.lstOverviewSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOverviewSchedule.Name = "lstOverviewSchedule";
            this.lstOverviewSchedule.Size = new System.Drawing.Size(751, 487);
            this.lstOverviewSchedule.TabIndex = 18;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgProducts);
            this.tabPage3.Controls.Add(this.tbName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblName);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbBarcode);
            this.tabPage3.Controls.Add(this.tbAmountInDepot);
            this.tabPage3.Controls.Add(this.lblEmail);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnAddPorduct);
            this.tabPage3.Controls.Add(this.tbmountInStore);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnGet);
            this.tabPage3.Controls.Add(this.btnEdit);
            this.tabPage3.Controls.Add(this.lblId);
            this.tabPage3.Controls.Add(this.tbID);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1293, 650);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(35, 55);
            this.dgProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 25;
            this.dgProducts.Size = new System.Drawing.Size(863, 544);
            this.dgProducts.TabIndex = 44;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(1051, 129);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 34);
            this.tbName.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Product type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(975, 141);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 28);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(904, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Amount in depot:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(1051, 187);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(185, 34);
            this.tbBarcode.TabIndex = 31;
            // 
            // tbAmountInDepot
            // 
            this.tbAmountInDepot.Location = new System.Drawing.Point(1053, 356);
            this.tbAmountInDepot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAmountInDepot.Name = "tbAmountInDepot";
            this.tbAmountInDepot.Size = new System.Drawing.Size(185, 34);
            this.tbAmountInDepot.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(959, 199);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 28);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Barcode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 309);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Amount in store:";
            // 
            // btnAddPorduct
            // 
            this.btnAddPorduct.Location = new System.Drawing.Point(952, 473);
            this.btnAddPorduct.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddPorduct.Name = "btnAddPorduct";
            this.btnAddPorduct.Size = new System.Drawing.Size(270, 40);
            this.btnAddPorduct.TabIndex = 33;
            this.btnAddPorduct.Text = "Add Product";
            this.btnAddPorduct.UseVisualStyleBackColor = true;
            // 
            // tbmountInStore
            // 
            this.tbmountInStore.Location = new System.Drawing.Point(1053, 297);
            this.tbmountInStore.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbmountInStore.Name = "tbmountInStore";
            this.tbmountInStore.Size = new System.Drawing.Size(185, 34);
            this.tbmountInStore.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(951, 559);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(270, 40);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Remove Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(952, 431);
            this.btnGet.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(270, 40);
            this.btnGet.TabIndex = 38;
            this.btnGet.Text = "ViewAllProducts";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(951, 516);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(270, 40);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit Product";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1006, 88);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 28);
            this.lblId.TabIndex = 37;
            this.lblId.Text = "ID:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(1051, 76);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(185, 34);
            this.tbID.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product List:";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1216, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 44);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 777);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstOverviewSchedule;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox lbProductType;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.TextBox cbProductType;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbAmountInDepot;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPorduct;
        private System.Windows.Forms.TextBox tbmountInStore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button button1;
    }
}
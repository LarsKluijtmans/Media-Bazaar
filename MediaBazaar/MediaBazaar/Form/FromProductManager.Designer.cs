
namespace AdminBackups
{
    partial class FromProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromProductManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labProductSearch = new System.Windows.Forms.Label();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAddPorduct = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 529);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labProductSearch);
            this.tabPage3.Controls.Add(this.tbProductSearch);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tbxPrice);
            this.tabPage3.Controls.Add(this.cbxProductType);
            this.tabPage3.Controls.Add(this.dgProducts);
            this.tabPage3.Controls.Add(this.tbName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblName);
            this.tabPage3.Controls.Add(this.tbBarcode);
            this.tabPage3.Controls.Add(this.lblEmail);
            this.tabPage3.Controls.Add(this.btnAddPorduct);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnEdit);
            this.tabPage3.Controls.Add(this.lblId);
            this.tabPage3.Controls.Add(this.tbID);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1130, 499);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labProductSearch
            // 
            this.labProductSearch.AutoSize = true;
            this.labProductSearch.Location = new System.Drawing.Point(440, 21);
            this.labProductSearch.Name = "labProductSearch";
            this.labProductSearch.Size = new System.Drawing.Size(60, 21);
            this.labProductSearch.TabIndex = 101;
            this.labProductSearch.Text = "Search:";
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Location = new System.Drawing.Point(518, 18);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.Size = new System.Drawing.Size(268, 29);
            this.tbProductSearch.TabIndex = 100;
            this.tbProductSearch.TextChanged += new System.EventHandler(this.tbProductSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Price (advice):";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(920, 226);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(161, 29);
            this.tbxPrice.TabIndex = 46;
            // 
            // cbxProductType
            // 
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Items.AddRange(new object[] {
            "KITCHEN_HOME",
            "PHOTO_VIDEO_NAVIGATION",
            "SMART_HOME_APPLIANCES",
            "GAMING_MUSIC_COMPUTERS"});
            this.cbxProductType.Location = new System.Drawing.Point(920, 185);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(161, 29);
            this.cbxProductType.TabIndex = 45;
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(31, 57);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.RowHeadersWidth = 51;
            this.dgProducts.RowTemplate.Height = 25;
            this.dgProducts.Size = new System.Drawing.Size(755, 392);
            this.dgProducts.TabIndex = 44;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
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
            this.label4.Location = new System.Drawing.Point(808, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Product type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(853, 106);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 21);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(920, 140);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(162, 29);
            this.tbBarcode.TabIndex = 31;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(839, 149);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 21);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Barcode:";
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
            this.lblId.Location = new System.Drawing.Point(880, 66);
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
            // FromProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FromProductManager";
            this.Text = "ProductManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox lbProductType;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.TextBox cbProductType;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAddPorduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.ComboBox cbxProductType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label labProductSearch;
        private System.Windows.Forms.TextBox tbProductSearch;
    }
}
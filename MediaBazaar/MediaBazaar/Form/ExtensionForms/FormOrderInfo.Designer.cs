
namespace AdminBackups
{
    partial class FormOrderInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMinAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaxAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMultiples = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddNewOrder = new System.Windows.Forms.Button();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.tbxPurchasePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbxSupplier = new System.Windows.Forms.ListBox();
            this.tbxSearchSupplier = new System.Windows.Forms.TextBox();
            this.tbxSupplier = new System.Windows.Forms.TextBox();
            this.btnUpdateOrderInfo = new System.Windows.Forms.Button();
            this.btnDeleteOrderInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(549, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            // 
            // tbxMinAmount
            // 
            this.tbxMinAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMinAmount.Location = new System.Drawing.Point(408, 129);
            this.tbxMinAmount.Name = "tbxMinAmount";
            this.tbxMinAmount.Size = new System.Drawing.Size(135, 29);
            this.tbxMinAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(300, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Amount:";
            // 
            // tbxMaxAmount
            // 
            this.tbxMaxAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMaxAmount.Location = new System.Drawing.Point(408, 165);
            this.tbxMaxAmount.Name = "tbxMaxAmount";
            this.tbxMaxAmount.Size = new System.Drawing.Size(135, 29);
            this.tbxMaxAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(302, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min Amount:";
            // 
            // tbxMultiples
            // 
            this.tbxMultiples.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxMultiples.Location = new System.Drawing.Point(624, 129);
            this.tbxMultiples.Name = "tbxMultiples";
            this.tbxMultiples.Size = new System.Drawing.Size(164, 29);
            this.tbxMultiples.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(549, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Multiples:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(17, 9);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(203, 30);
            this.lblProductName.TabIndex = 10;
            this.lblProductName.Text = "<<Product Name>>";
            // 
            // btnAddNewOrder
            // 
            this.btnAddNewOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewOrder.Location = new System.Drawing.Point(637, 243);
            this.btnAddNewOrder.Name = "btnAddNewOrder";
            this.btnAddNewOrder.Size = new System.Drawing.Size(151, 32);
            this.btnAddNewOrder.TabIndex = 14;
            this.btnAddNewOrder.Text = "Add New Order Info";
            this.btnAddNewOrder.UseVisualStyleBackColor = true;
            this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(624, 100);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.ReadOnly = true;
            this.tbxBarcode.Size = new System.Drawing.Size(164, 23);
            this.tbxBarcode.TabIndex = 18;
            // 
            // tbxPurchasePrice
            // 
            this.tbxPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPurchasePrice.Location = new System.Drawing.Point(669, 165);
            this.tbxPurchasePrice.Name = "tbxPurchasePrice";
            this.tbxPurchasePrice.Size = new System.Drawing.Size(119, 29);
            this.tbxPurchasePrice.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(549, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Purchase Price:";
            // 
            // lbxSupplier
            // 
            this.lbxSupplier.FormattingEnabled = true;
            this.lbxSupplier.ItemHeight = 15;
            this.lbxSupplier.Location = new System.Drawing.Point(17, 98);
            this.lbxSupplier.Name = "lbxSupplier";
            this.lbxSupplier.Size = new System.Drawing.Size(274, 214);
            this.lbxSupplier.TabIndex = 21;
            this.lbxSupplier.SelectedIndexChanged += new System.EventHandler(this.lbxSupplier_SelectedIndexChanged);
            this.lbxSupplier.DoubleClick += new System.EventHandler(this.lbxSupplier_DoubleClick);
            // 
            // tbxSearchSupplier
            // 
            this.tbxSearchSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSearchSupplier.Location = new System.Drawing.Point(17, 61);
            this.tbxSearchSupplier.Name = "tbxSearchSupplier";
            this.tbxSearchSupplier.PlaceholderText = "Search supplier name";
            this.tbxSearchSupplier.Size = new System.Drawing.Size(179, 29);
            this.tbxSearchSupplier.TabIndex = 22;
            this.tbxSearchSupplier.TextChanged += new System.EventHandler(this.tbxSearchSupplier_TextChanged);
            // 
            // tbxSupplier
            // 
            this.tbxSupplier.Location = new System.Drawing.Point(408, 100);
            this.tbxSupplier.Name = "tbxSupplier";
            this.tbxSupplier.ReadOnly = true;
            this.tbxSupplier.Size = new System.Drawing.Size(135, 23);
            this.tbxSupplier.TabIndex = 23;
            // 
            // btnUpdateOrderInfo
            // 
            this.btnUpdateOrderInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrderInfo.Location = new System.Drawing.Point(637, 281);
            this.btnUpdateOrderInfo.Name = "btnUpdateOrderInfo";
            this.btnUpdateOrderInfo.Size = new System.Drawing.Size(151, 31);
            this.btnUpdateOrderInfo.TabIndex = 24;
            this.btnUpdateOrderInfo.Text = "Update Order Info";
            this.btnUpdateOrderInfo.UseVisualStyleBackColor = true;
            this.btnUpdateOrderInfo.Click += new System.EventHandler(this.btnUpdateOrderInfo_Click);
            // 
            // btnDeleteOrderInfo
            // 
            this.btnDeleteOrderInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOrderInfo.Location = new System.Drawing.Point(480, 281);
            this.btnDeleteOrderInfo.Name = "btnDeleteOrderInfo";
            this.btnDeleteOrderInfo.Size = new System.Drawing.Size(151, 31);
            this.btnDeleteOrderInfo.TabIndex = 25;
            this.btnDeleteOrderInfo.Text = "Delete Order Info";
            this.btnDeleteOrderInfo.UseVisualStyleBackColor = true;
            this.btnDeleteOrderInfo.Click += new System.EventHandler(this.btnDeleteOrderInfo_Click);
            // 
            // FormOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 332);
            this.Controls.Add(this.btnDeleteOrderInfo);
            this.Controls.Add(this.btnUpdateOrderInfo);
            this.Controls.Add(this.tbxSupplier);
            this.Controls.Add(this.tbxSearchSupplier);
            this.Controls.Add(this.lbxSupplier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPurchasePrice);
            this.Controls.Add(this.tbxBarcode);
            this.Controls.Add(this.btnAddNewOrder);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tbxMultiples);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxMaxAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMinAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderInfo";
            this.Text = "FormOrderInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMinAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaxAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMultiples;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAddNewOrder;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.TextBox tbxPurchasePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbxSupplier;
        private System.Windows.Forms.TextBox tbxSearchSupplier;
        private System.Windows.Forms.TextBox tbxSupplier;
        private System.Windows.Forms.Button btnUpdateOrderInfo;
        private System.Windows.Forms.Button btnDeleteOrderInfo;
    }
}
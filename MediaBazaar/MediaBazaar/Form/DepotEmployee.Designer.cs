
namespace MediaBazaar
{
    partial class DepotEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepotEmployee));
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstAnnouncement = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReshelves = new System.Windows.Forms.TabPage();
            this.tabReceivingGood = new System.Windows.Forms.TabPage();
            this.dgReshelve = new System.Windows.Forms.DataGridView();
            this.rbHistory = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFufillReshelveRequest = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteReshelveRequest = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtReshelfID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.Label();
            this.txtAmountRequested = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabReshelves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReshelve)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(845, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 33);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lstAnnouncement
            // 
            this.lstAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstAnnouncement.FormattingEnabled = true;
            this.lstAnnouncement.ItemHeight = 17;
            this.lstAnnouncement.Location = new System.Drawing.Point(21, 47);
            this.lstAnnouncement.Name = "lstAnnouncement";
            this.lstAnnouncement.Size = new System.Drawing.Size(764, 208);
            this.lstAnnouncement.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReshelves);
            this.tabControl1.Controls.Add(this.tabReceivingGood);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 522);
            this.tabControl1.TabIndex = 3;
            // 
            // tabReshelves
            // 
            this.tabReshelves.Controls.Add(this.dgReshelve);
            this.tabReshelves.Controls.Add(this.rbHistory);
            this.tabReshelves.Controls.Add(this.rbPending);
            this.tabReshelves.Controls.Add(this.groupBox1);
            this.tabReshelves.Controls.Add(this.label15);
            this.tabReshelves.Location = new System.Drawing.Point(4, 30);
            this.tabReshelves.Name = "tabReshelves";
            this.tabReshelves.Padding = new System.Windows.Forms.Padding(3);
            this.tabReshelves.Size = new System.Drawing.Size(980, 488);
            this.tabReshelves.TabIndex = 0;
            this.tabReshelves.Text = "Reshelve";
            this.tabReshelves.UseVisualStyleBackColor = true;
            // 
            // tabReceivingGood
            // 
            this.tabReceivingGood.Location = new System.Drawing.Point(4, 30);
            this.tabReceivingGood.Name = "tabReceivingGood";
            this.tabReceivingGood.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceivingGood.Size = new System.Drawing.Size(980, 488);
            this.tabReceivingGood.TabIndex = 1;
            this.tabReceivingGood.Text = "ReceivingGoods";
            this.tabReceivingGood.UseVisualStyleBackColor = true;
            // 
            // dgReshelve
            // 
            this.dgReshelve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReshelve.Location = new System.Drawing.Point(17, 51);
            this.dgReshelve.Name = "dgReshelve";
            this.dgReshelve.RowHeadersWidth = 51;
            this.dgReshelve.RowTemplate.Height = 25;
            this.dgReshelve.Size = new System.Drawing.Size(603, 386);
            this.dgReshelve.TabIndex = 96;
            // 
            // rbHistory
            // 
            this.rbHistory.AutoSize = true;
            this.rbHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbHistory.Location = new System.Drawing.Point(408, 24);
            this.rbHistory.Name = "rbHistory";
            this.rbHistory.Size = new System.Drawing.Size(120, 21);
            this.rbHistory.TabIndex = 95;
            this.rbHistory.Text = "Previous History";
            this.rbHistory.UseVisualStyleBackColor = true;
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Checked = true;
            this.rbPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPending.Location = new System.Drawing.Point(318, 24);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(73, 21);
            this.rbPending.TabIndex = 94;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmountRequested);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.txtReshelfID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFufillReshelveRequest);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDeleteReshelveRequest);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(658, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 292);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restock Management";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(67, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "Product ID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(70, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 69;
            this.label14.Text = "Reshelf ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "Barcode:";
            // 
            // btnFufillReshelveRequest
            // 
            this.btnFufillReshelveRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFufillReshelveRequest.Location = new System.Drawing.Point(17, 194);
            this.btnFufillReshelveRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFufillReshelveRequest.Name = "btnFufillReshelveRequest";
            this.btnFufillReshelveRequest.Size = new System.Drawing.Size(176, 30);
            this.btnFufillReshelveRequest.TabIndex = 70;
            this.btnFufillReshelveRequest.Text = "Fufill reshelve request";
            this.btnFufillReshelveRequest.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(17, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Amount Requested:";
            // 
            // btnDeleteReshelveRequest
            // 
            this.btnDeleteReshelveRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteReshelveRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteReshelveRequest.Location = new System.Drawing.Point(17, 236);
            this.btnDeleteReshelveRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteReshelveRequest.Name = "btnDeleteReshelveRequest";
            this.btnDeleteReshelveRequest.Size = new System.Drawing.Size(176, 30);
            this.btnDeleteReshelveRequest.TabIndex = 84;
            this.btnDeleteReshelveRequest.Text = "Delete reshelve request";
            this.btnDeleteReshelveRequest.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(17, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 21);
            this.label15.TabIndex = 92;
            this.label15.Text = "Reshelve Requests:";
            // 
            // txtReshelfID
            // 
            this.txtReshelfID.AutoSize = true;
            this.txtReshelfID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReshelfID.Location = new System.Drawing.Point(140, 35);
            this.txtReshelfID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtReshelfID.Name = "txtReshelfID";
            this.txtReshelfID.Size = new System.Drawing.Size(62, 17);
            this.txtReshelfID.TabIndex = 90;
            this.txtReshelfID.Text = "ReshelfID";
            // 
            // txtProductID
            // 
            this.txtProductID.AutoSize = true;
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductID.Location = new System.Drawing.Point(140, 75);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(65, 17);
            this.txtProductID.TabIndex = 91;
            this.txtProductID.Text = "ProductID";
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoSize = true;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(140, 115);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(56, 17);
            this.txtBarcode.TabIndex = 92;
            this.txtBarcode.Text = "Barcode";
            // 
            // txtAmountRequested
            // 
            this.txtAmountRequested.AutoSize = true;
            this.txtAmountRequested.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmountRequested.Location = new System.Drawing.Point(140, 157);
            this.txtAmountRequested.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAmountRequested.Name = "txtAmountRequested";
            this.txtAmountRequested.Size = new System.Drawing.Size(53, 17);
            this.txtAmountRequested.TabIndex = 93;
            this.txtAmountRequested.Text = "Amount";
            // 
            // DepotEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 588);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepotEmployee";
            this.Text = "FormDepotEmployee";
            this.tabControl1.ResumeLayout(false);
            this.tabReshelves.ResumeLayout(false);
            this.tabReshelves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReshelve)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lstAnnouncement;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReshelves;
        private System.Windows.Forms.TabPage tabReceivingGood;
        private System.Windows.Forms.DataGridView dgReshelve;
        private System.Windows.Forms.RadioButton rbHistory;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFufillReshelveRequest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteReshelveRequest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtAmountRequested;
        private System.Windows.Forms.Label txtBarcode;
        private System.Windows.Forms.Label txtProductID;
        private System.Windows.Forms.Label txtReshelfID;
    }
}
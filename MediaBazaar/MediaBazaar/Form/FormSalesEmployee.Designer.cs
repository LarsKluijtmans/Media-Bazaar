
namespace MediaBazaar
{
    partial class FormSalesEmployee
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
            this.btnViewPorducts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbmountInStore = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstOverviewSchedule = new System.Windows.Forms.ListBox();
            this.lstOverviewAnnoucement = new System.Windows.Forms.ListBox();
            this.lstOverviewProduct = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.sdfds.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(980, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnViewPorducts);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRequestReplenishment);
            this.tabPage2.Controls.Add(this.lstProduct);
            this.tabPage2.Controls.Add(this.sdfds);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1056, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products ";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product List:";
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
            this.sdfds.Controls.Add(this.label2);
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
            this.Amount.Location = new System.Drawing.Point(54, 292);
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
            this.label4.Location = new System.Drawing.Point(33, 168);
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
            this.lblName.Location = new System.Drawing.Point(79, 81);
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
            this.label6.Location = new System.Drawing.Point(16, 253);
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
            this.lblEmail.Location = new System.Drawing.Point(65, 123);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 21);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Amount in store:";
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
            this.lblId.Location = new System.Drawing.Point(105, 36);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnProfile);
            this.tabPage1.Controls.Add(this.btnCheck);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lstOverviewSchedule);
            this.tabPage1.Controls.Add(this.lstOverviewAnnoucement);
            this.tabPage1.Controls.Add(this.lstOverviewProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1056, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(936, 16);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(97, 55);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(936, 391);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(97, 55);
            this.btnCheck.TabIndex = 18;
            this.btnCheck.Text = "Check In";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(255, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Schedule:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(255, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Announcements:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Product List:";
            // 
            // lstOverviewSchedule
            // 
            this.lstOverviewSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewSchedule.FormattingEnabled = true;
            this.lstOverviewSchedule.ItemHeight = 17;
            this.lstOverviewSchedule.Location = new System.Drawing.Point(255, 221);
            this.lstOverviewSchedule.Name = "lstOverviewSchedule";
            this.lstOverviewSchedule.Size = new System.Drawing.Size(632, 225);
            this.lstOverviewSchedule.TabIndex = 13;
            // 
            // lstOverviewAnnoucement
            // 
            this.lstOverviewAnnoucement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewAnnoucement.FormattingEnabled = true;
            this.lstOverviewAnnoucement.ItemHeight = 17;
            this.lstOverviewAnnoucement.Location = new System.Drawing.Point(255, 27);
            this.lstOverviewAnnoucement.Name = "lstOverviewAnnoucement";
            this.lstOverviewAnnoucement.Size = new System.Drawing.Size(632, 157);
            this.lstOverviewAnnoucement.TabIndex = 11;
            // 
            // lstOverviewProduct
            // 
            this.lstOverviewProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewProduct.FormattingEnabled = true;
            this.lstOverviewProduct.ItemHeight = 17;
            this.lstOverviewProduct.Location = new System.Drawing.Point(19, 27);
            this.lstOverviewProduct.Name = "lstOverviewProduct";
            this.lstOverviewProduct.Size = new System.Drawing.Size(218, 429);
            this.lstOverviewProduct.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1056, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormSalesEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 563);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSalesEmployee";
            this.Text = "FormSalesEmployee";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.sdfds.ResumeLayout(false);
            this.sdfds.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label u;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.GroupBox sdfds;
        private System.Windows.Forms.Button btnRequestReplenishment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstOverviewSchedule;
        private System.Windows.Forms.ListBox lstOverviewAnnoucement;
        private System.Windows.Forms.ListBox lstOverviewProduct;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnViewPorducts;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbAmountInDepot;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbmountInStore;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.TextBox lbProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
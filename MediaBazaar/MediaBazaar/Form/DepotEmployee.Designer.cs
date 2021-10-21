
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lstAnnouncement = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReplenishment = new System.Windows.Forms.TabPage();
            this.gbReplenishment = new System.Windows.Forms.GroupBox();
            this.btnFufillRequest = new System.Windows.Forms.Button();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.tbReplenishmentAmount = new System.Windows.Forms.TextBox();
            this.labAmount = new System.Windows.Forms.Label();
            this.tbReplenishmentAmountInDepot = new System.Windows.Forms.TextBox();
            this.labAmountInDepot = new System.Windows.Forms.Label();
            this.tbReplenishmentProsuctName = new System.Windows.Forms.TextBox();
            this.labReplenishmentID = new System.Windows.Forms.Label();
            this.tbReplenishmentProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReplenishmentID = new System.Windows.Forms.TextBox();
            this.laProductID = new System.Windows.Forms.Label();
            this.lbReplenishment = new System.Windows.Forms.ListBox();
            this.tbSearchReplenishment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabReceivingGood = new System.Windows.Forms.TabPage();
            this.gbRecievedGoods = new System.Windows.Forms.GroupBox();
            this.btnAddToDepot = new System.Windows.Forms.Button();
            this.tbAmountRecieved = new System.Windows.Forms.TextBox();
            this.labAmountRecieve = new System.Windows.Forms.Label();
            this.tbAmountInDepot = new System.Windows.Forms.TextBox();
            this.labAmoutnInDepot = new System.Windows.Forms.Label();
            this.tbProductType = new System.Windows.Forms.TextBox();
            this.labProductType = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.labProductName = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.labProductID = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.tbProductSearch = new System.Windows.Forms.TextBox();
            this.labSearchBar = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabReplenishment.SuspendLayout();
            this.gbReplenishment.SuspendLayout();
            this.tabReceivingGood.SuspendLayout();
            this.gbRecievedGoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1061, 4);
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
            this.tabControl1.Controls.Add(this.tabReplenishment);
            this.tabControl1.Controls.Add(this.tabReceivingGood);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1171, 522);
            this.tabControl1.TabIndex = 3;
            // 
            // tabReplenishment
            // 
            this.tabReplenishment.Controls.Add(this.gbReplenishment);
            this.tabReplenishment.Controls.Add(this.lbReplenishment);
            this.tabReplenishment.Controls.Add(this.tbSearchReplenishment);
            this.tabReplenishment.Controls.Add(this.label6);
            this.tabReplenishment.Location = new System.Drawing.Point(4, 24);
            this.tabReplenishment.Name = "tabReplenishment";
            this.tabReplenishment.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplenishment.Size = new System.Drawing.Size(1163, 494);
            this.tabReplenishment.TabIndex = 0;
            this.tabReplenishment.Text = "Replenishment";
            this.tabReplenishment.UseVisualStyleBackColor = true;
            // 
            // gbReplenishment
            // 
            this.gbReplenishment.Controls.Add(this.btnFufillRequest);
            this.gbReplenishment.Controls.Add(this.btnDeleteRequest);
            this.gbReplenishment.Controls.Add(this.tbReplenishmentAmount);
            this.gbReplenishment.Controls.Add(this.labAmount);
            this.gbReplenishment.Controls.Add(this.tbReplenishmentAmountInDepot);
            this.gbReplenishment.Controls.Add(this.labAmountInDepot);
            this.gbReplenishment.Controls.Add(this.tbReplenishmentProsuctName);
            this.gbReplenishment.Controls.Add(this.labReplenishmentID);
            this.gbReplenishment.Controls.Add(this.tbReplenishmentProductID);
            this.gbReplenishment.Controls.Add(this.label4);
            this.gbReplenishment.Controls.Add(this.tbReplenishmentID);
            this.gbReplenishment.Controls.Add(this.laProductID);
            this.gbReplenishment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbReplenishment.Location = new System.Drawing.Point(680, 36);
            this.gbReplenishment.Name = "gbReplenishment";
            this.gbReplenishment.Size = new System.Drawing.Size(462, 439);
            this.gbReplenishment.TabIndex = 7;
            this.gbReplenishment.TabStop = false;
            this.gbReplenishment.Text = "Replenishment";
            // 
            // btnFufillRequest
            // 
            this.btnFufillRequest.Location = new System.Drawing.Point(100, 320);
            this.btnFufillRequest.Name = "btnFufillRequest";
            this.btnFufillRequest.Size = new System.Drawing.Size(269, 44);
            this.btnFufillRequest.TabIndex = 15;
            this.btnFufillRequest.Text = "Fufill request";
            this.btnFufillRequest.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Location = new System.Drawing.Point(100, 382);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(269, 41);
            this.btnDeleteRequest.TabIndex = 14;
            this.btnDeleteRequest.Text = "Delete request";
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            // 
            // tbReplenishmentAmount
            // 
            this.tbReplenishmentAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReplenishmentAmount.Location = new System.Drawing.Point(195, 255);
            this.tbReplenishmentAmount.Name = "tbReplenishmentAmount";
            this.tbReplenishmentAmount.Size = new System.Drawing.Size(240, 33);
            this.tbReplenishmentAmount.TabIndex = 13;
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAmount.Location = new System.Drawing.Point(100, 258);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(83, 25);
            this.labAmount.TabIndex = 12;
            this.labAmount.Text = "Amount:";
            // 
            // tbReplenishmentAmountInDepot
            // 
            this.tbReplenishmentAmountInDepot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReplenishmentAmountInDepot.Location = new System.Drawing.Point(195, 204);
            this.tbReplenishmentAmountInDepot.Name = "tbReplenishmentAmountInDepot";
            this.tbReplenishmentAmountInDepot.ReadOnly = true;
            this.tbReplenishmentAmountInDepot.Size = new System.Drawing.Size(240, 33);
            this.tbReplenishmentAmountInDepot.TabIndex = 11;
            // 
            // labAmountInDepot
            // 
            this.labAmountInDepot.AutoSize = true;
            this.labAmountInDepot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAmountInDepot.Location = new System.Drawing.Point(18, 207);
            this.labAmountInDepot.Name = "labAmountInDepot";
            this.labAmountInDepot.Size = new System.Drawing.Size(160, 25);
            this.labAmountInDepot.TabIndex = 10;
            this.labAmountInDepot.Text = "Amount In Depot:";
            // 
            // tbReplenishmentProsuctName
            // 
            this.tbReplenishmentProsuctName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReplenishmentProsuctName.Location = new System.Drawing.Point(195, 152);
            this.tbReplenishmentProsuctName.Name = "tbReplenishmentProsuctName";
            this.tbReplenishmentProsuctName.ReadOnly = true;
            this.tbReplenishmentProsuctName.Size = new System.Drawing.Size(240, 33);
            this.tbReplenishmentProsuctName.TabIndex = 9;
            // 
            // labReplenishmentID
            // 
            this.labReplenishmentID.AutoSize = true;
            this.labReplenishmentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labReplenishmentID.Location = new System.Drawing.Point(15, 54);
            this.labReplenishmentID.Name = "labReplenishmentID";
            this.labReplenishmentID.Size = new System.Drawing.Size(163, 25);
            this.labReplenishmentID.TabIndex = 8;
            this.labReplenishmentID.Text = "Replenishment ID:";
            // 
            // tbReplenishmentProductID
            // 
            this.tbReplenishmentProductID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReplenishmentProductID.Location = new System.Drawing.Point(195, 99);
            this.tbReplenishmentProductID.Name = "tbReplenishmentProductID";
            this.tbReplenishmentProductID.ReadOnly = true;
            this.tbReplenishmentProductID.Size = new System.Drawing.Size(240, 33);
            this.tbReplenishmentProductID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name:";
            // 
            // tbReplenishmentID
            // 
            this.tbReplenishmentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReplenishmentID.Location = new System.Drawing.Point(195, 51);
            this.tbReplenishmentID.Name = "tbReplenishmentID";
            this.tbReplenishmentID.ReadOnly = true;
            this.tbReplenishmentID.Size = new System.Drawing.Size(240, 33);
            this.tbReplenishmentID.TabIndex = 5;
            // 
            // laProductID
            // 
            this.laProductID.AutoSize = true;
            this.laProductID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laProductID.Location = new System.Drawing.Point(73, 102);
            this.laProductID.Name = "laProductID";
            this.laProductID.Size = new System.Drawing.Size(105, 25);
            this.laProductID.TabIndex = 4;
            this.laProductID.Text = "Product ID:";
            // 
            // lbReplenishment
            // 
            this.lbReplenishment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbReplenishment.FormattingEnabled = true;
            this.lbReplenishment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbReplenishment.ItemHeight = 20;
            this.lbReplenishment.Location = new System.Drawing.Point(28, 71);
            this.lbReplenishment.Name = "lbReplenishment";
            this.lbReplenishment.Size = new System.Drawing.Size(630, 404);
            this.lbReplenishment.TabIndex = 6;
            this.lbReplenishment.SelectedIndexChanged += new System.EventHandler(this.lbReplenishment_SelectedIndexChanged);
            // 
            // tbSearchReplenishment
            // 
            this.tbSearchReplenishment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearchReplenishment.Location = new System.Drawing.Point(107, 20);
            this.tbSearchReplenishment.Name = "tbSearchReplenishment";
            this.tbSearchReplenishment.Size = new System.Drawing.Size(407, 35);
            this.tbSearchReplenishment.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Search:";
            // 
            // tabReceivingGood
            // 
            this.tabReceivingGood.Controls.Add(this.gbRecievedGoods);
            this.tabReceivingGood.Controls.Add(this.lbProducts);
            this.tabReceivingGood.Controls.Add(this.tbProductSearch);
            this.tabReceivingGood.Controls.Add(this.labSearchBar);
            this.tabReceivingGood.Location = new System.Drawing.Point(4, 24);
            this.tabReceivingGood.Name = "tabReceivingGood";
            this.tabReceivingGood.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceivingGood.Size = new System.Drawing.Size(1163, 494);
            this.tabReceivingGood.TabIndex = 1;
            this.tabReceivingGood.Text = "ReceivingGoods";
            this.tabReceivingGood.UseVisualStyleBackColor = true;
            // 
            // gbRecievedGoods
            // 
            this.gbRecievedGoods.Controls.Add(this.btnAddToDepot);
            this.gbRecievedGoods.Controls.Add(this.tbAmountRecieved);
            this.gbRecievedGoods.Controls.Add(this.labAmountRecieve);
            this.gbRecievedGoods.Controls.Add(this.tbAmountInDepot);
            this.gbRecievedGoods.Controls.Add(this.labAmoutnInDepot);
            this.gbRecievedGoods.Controls.Add(this.tbProductType);
            this.gbRecievedGoods.Controls.Add(this.labProductType);
            this.gbRecievedGoods.Controls.Add(this.tbProductName);
            this.gbRecievedGoods.Controls.Add(this.labProductName);
            this.gbRecievedGoods.Controls.Add(this.tbProductID);
            this.gbRecievedGoods.Controls.Add(this.labProductID);
            this.gbRecievedGoods.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRecievedGoods.Location = new System.Drawing.Point(684, 35);
            this.gbRecievedGoods.Name = "gbRecievedGoods";
            this.gbRecievedGoods.Size = new System.Drawing.Size(462, 439);
            this.gbRecievedGoods.TabIndex = 3;
            this.gbRecievedGoods.TabStop = false;
            this.gbRecievedGoods.Text = "RecievedGoods";
            // 
            // btnAddToDepot
            // 
            this.btnAddToDepot.Location = new System.Drawing.Point(110, 362);
            this.btnAddToDepot.Name = "btnAddToDepot";
            this.btnAddToDepot.Size = new System.Drawing.Size(269, 44);
            this.btnAddToDepot.TabIndex = 14;
            this.btnAddToDepot.Text = "Goods Recieved";
            this.btnAddToDepot.UseVisualStyleBackColor = true;
            // 
            // tbAmountRecieved
            // 
            this.tbAmountRecieved.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmountRecieved.Location = new System.Drawing.Point(195, 293);
            this.tbAmountRecieved.Name = "tbAmountRecieved";
            this.tbAmountRecieved.Size = new System.Drawing.Size(240, 33);
            this.tbAmountRecieved.TabIndex = 13;
            // 
            // labAmountRecieve
            // 
            this.labAmountRecieve.AutoSize = true;
            this.labAmountRecieve.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAmountRecieve.Location = new System.Drawing.Point(18, 296);
            this.labAmountRecieve.Name = "labAmountRecieve";
            this.labAmountRecieve.Size = new System.Drawing.Size(162, 25);
            this.labAmountRecieve.TabIndex = 12;
            this.labAmountRecieve.Text = "Amount Recieved:";
            // 
            // tbAmountInDepot
            // 
            this.tbAmountInDepot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAmountInDepot.Location = new System.Drawing.Point(195, 230);
            this.tbAmountInDepot.Name = "tbAmountInDepot";
            this.tbAmountInDepot.ReadOnly = true;
            this.tbAmountInDepot.Size = new System.Drawing.Size(240, 33);
            this.tbAmountInDepot.TabIndex = 11;
            // 
            // labAmoutnInDepot
            // 
            this.labAmoutnInDepot.AutoSize = true;
            this.labAmoutnInDepot.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labAmoutnInDepot.Location = new System.Drawing.Point(18, 233);
            this.labAmoutnInDepot.Name = "labAmoutnInDepot";
            this.labAmoutnInDepot.Size = new System.Drawing.Size(160, 25);
            this.labAmoutnInDepot.TabIndex = 10;
            this.labAmoutnInDepot.Text = "Amount In Depot:";
            // 
            // tbProductType
            // 
            this.tbProductType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProductType.Location = new System.Drawing.Point(195, 168);
            this.tbProductType.Name = "tbProductType";
            this.tbProductType.ReadOnly = true;
            this.tbProductType.Size = new System.Drawing.Size(240, 33);
            this.tbProductType.TabIndex = 9;
            // 
            // labProductType
            // 
            this.labProductType.AutoSize = true;
            this.labProductType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labProductType.Location = new System.Drawing.Point(57, 171);
            this.labProductType.Name = "labProductType";
            this.labProductType.Size = new System.Drawing.Size(126, 25);
            this.labProductType.TabIndex = 8;
            this.labProductType.Text = "Product Type:";
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProductName.Location = new System.Drawing.Point(195, 109);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(240, 33);
            this.tbProductName.TabIndex = 7;
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labProductName.Location = new System.Drawing.Point(46, 112);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(137, 25);
            this.labProductName.TabIndex = 6;
            this.labProductName.Text = "Product Name:";
            // 
            // tbProductID
            // 
            this.tbProductID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProductID.Location = new System.Drawing.Point(195, 51);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(240, 33);
            this.tbProductID.TabIndex = 5;
            // 
            // labProductID
            // 
            this.labProductID.AutoSize = true;
            this.labProductID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labProductID.Location = new System.Drawing.Point(78, 54);
            this.labProductID.Name = "labProductID";
            this.labProductID.Size = new System.Drawing.Size(105, 25);
            this.labProductID.TabIndex = 4;
            this.labProductID.Text = "Product ID:";
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbProducts.ItemHeight = 20;
            this.lbProducts.Location = new System.Drawing.Point(32, 70);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(630, 404);
            this.lbProducts.TabIndex = 2;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // tbProductSearch
            // 
            this.tbProductSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProductSearch.Location = new System.Drawing.Point(111, 19);
            this.tbProductSearch.Name = "tbProductSearch";
            this.tbProductSearch.Size = new System.Drawing.Size(407, 35);
            this.tbProductSearch.TabIndex = 1;
            // 
            // labSearchBar
            // 
            this.labSearchBar.AutoSize = true;
            this.labSearchBar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labSearchBar.Location = new System.Drawing.Point(25, 22);
            this.labSearchBar.Name = "labSearchBar";
            this.labSearchBar.Size = new System.Drawing.Size(80, 30);
            this.labSearchBar.TabIndex = 0;
            this.labSearchBar.Text = "Search:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // DepotEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepotEmployee";
            this.Text = "FormDepotEmployee";
            this.tabControl1.ResumeLayout(false);
            this.tabReplenishment.ResumeLayout(false);
            this.tabReplenishment.PerformLayout();
            this.gbReplenishment.ResumeLayout(false);
            this.gbReplenishment.PerformLayout();
            this.tabReceivingGood.ResumeLayout(false);
            this.tabReceivingGood.PerformLayout();
            this.gbRecievedGoods.ResumeLayout(false);
            this.gbRecievedGoods.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox lstAnnouncement;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReplenishment;
        private System.Windows.Forms.TabPage tabReceivingGood;
        private System.Windows.Forms.GroupBox gbRecievedGoods;
        private System.Windows.Forms.TextBox tbAmountInDepot;
        private System.Windows.Forms.Label labAmoutnInDepot;
        private System.Windows.Forms.TextBox tbProductType;
        private System.Windows.Forms.Label labProductType;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label labProductID;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.TextBox tbProductSearch;
        private System.Windows.Forms.Label labSearchBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddToDepot;
        private System.Windows.Forms.TextBox tbAmountRecieved;
        private System.Windows.Forms.Label labAmountRecieve;
        private System.Windows.Forms.GroupBox gbReplenishment;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.TextBox tbReplenishmentAmount;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.TextBox tbReplenishmentAmountInDepot;
        private System.Windows.Forms.Label labAmountInDepot;
        private System.Windows.Forms.TextBox tbReplenishmentProsuctName;
        private System.Windows.Forms.Label labReplenishmentID;
        private System.Windows.Forms.TextBox tbReplenishmentProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReplenishmentID;
        private System.Windows.Forms.Label laProductID;
        private System.Windows.Forms.ListBox lbReplenishment;
        private System.Windows.Forms.TextBox tbSearchReplenishment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFufillRequest;
        private System.Windows.Forms.Timer timer2;
    }
}
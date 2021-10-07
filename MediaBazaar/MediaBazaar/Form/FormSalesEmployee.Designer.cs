
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbmountInStore = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstOverviewSchedule = new System.Windows.Forms.ListBox();
            this.lstOverviewProduct = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnEveningLeastPrefered = new System.Windows.Forms.RadioButton();
            this.rbnAfternoonLeastPrefered = new System.Windows.Forms.RadioButton();
            this.rbnMorningLeastPrefered = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxLeastPreferedDay = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbnEveningPrefered = new System.Windows.Forms.RadioButton();
            this.rbnAfternoonPrefered = new System.Windows.Forms.RadioButton();
            this.rbnMorningPrefered = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxPreferedDay = new System.Windows.Forms.ComboBox();
            this.tabPage2.SuspendLayout();
            this.sdfds.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(770, 13);
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
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lstProduct);
            this.tabPage2.Controls.Add(this.sdfds);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(876, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product List:";
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.HorizontalScrollbar = true;
            this.lstProduct.ItemHeight = 17;
            this.lstProduct.Location = new System.Drawing.Point(22, 39);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(484, 429);
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
            this.sdfds.Controls.Add(this.label2);
            this.sdfds.Controls.Add(this.tbmountInStore);
            this.sdfds.Controls.Add(this.lblId);
            this.sdfds.Controls.Add(this.tbID);
            this.sdfds.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sdfds.Location = new System.Drawing.Point(530, 39);
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
            this.btnViewPorducts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewPorducts.Location = new System.Drawing.Point(45, 382);
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
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Amount.Location = new System.Drawing.Point(70, 292);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(69, 20);
            this.Amount.TabIndex = 57;
            this.Amount.Text = "Amount: ";
            // 
            // btnRequestReplenishment
            // 
            this.btnRequestReplenishment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRequestReplenishment.Location = new System.Drawing.Point(45, 344);
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
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Product type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(87, 82);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
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
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(72, 124);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 20);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
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
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(112, 37);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
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
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lstOverviewSchedule);
            this.tabPage1.Controls.Add(this.lstOverviewProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(876, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(776, 4);
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
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(773, 466);
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
            this.label5.Location = new System.Drawing.Point(510, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Schedule:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(34, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Product List:";
            // 
            // lstOverviewSchedule
            // 
            this.lstOverviewSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewSchedule.FormattingEnabled = true;
            this.lstOverviewSchedule.HorizontalScrollbar = true;
            this.lstOverviewSchedule.ItemHeight = 17;
            this.lstOverviewSchedule.Location = new System.Drawing.Point(510, 42);
            this.lstOverviewSchedule.Name = "lstOverviewSchedule";
            this.lstOverviewSchedule.Size = new System.Drawing.Size(248, 429);
            this.lstOverviewSchedule.TabIndex = 13;
            // 
            // lstOverviewProduct
            // 
            this.lstOverviewProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewProduct.FormattingEnabled = true;
            this.lstOverviewProduct.HorizontalScrollbar = true;
            this.lstOverviewProduct.ItemHeight = 17;
            this.lstOverviewProduct.Location = new System.Drawing.Point(34, 42);
            this.lstOverviewProduct.Name = "lstOverviewProduct";
            this.lstOverviewProduct.Size = new System.Drawing.Size(436, 429);
            this.lstOverviewProduct.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(32, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSubmit);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Availability";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(508, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rbnEveningLeastPrefered);
            this.groupBox2.Controls.Add(this.rbnAfternoonLeastPrefered);
            this.groupBox2.Controls.Add(this.rbnMorningLeastPrefered);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbxLeastPreferedDay);
            this.groupBox2.Location = new System.Drawing.Point(201, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 152);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Least prefered work time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select shift:";
            // 
            // rbnEveningLeastPrefered
            // 
            this.rbnEveningLeastPrefered.AutoSize = true;
            this.rbnEveningLeastPrefered.Location = new System.Drawing.Point(297, 78);
            this.rbnEveningLeastPrefered.Name = "rbnEveningLeastPrefered";
            this.rbnEveningLeastPrefered.Size = new System.Drawing.Size(79, 24);
            this.rbnEveningLeastPrefered.TabIndex = 5;
            this.rbnEveningLeastPrefered.TabStop = true;
            this.rbnEveningLeastPrefered.Text = "Evening";
            this.rbnEveningLeastPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnAfternoonLeastPrefered
            // 
            this.rbnAfternoonLeastPrefered.AutoSize = true;
            this.rbnAfternoonLeastPrefered.Location = new System.Drawing.Point(197, 78);
            this.rbnAfternoonLeastPrefered.Name = "rbnAfternoonLeastPrefered";
            this.rbnAfternoonLeastPrefered.Size = new System.Drawing.Size(94, 24);
            this.rbnAfternoonLeastPrefered.TabIndex = 4;
            this.rbnAfternoonLeastPrefered.TabStop = true;
            this.rbnAfternoonLeastPrefered.Text = "Afternoon";
            this.rbnAfternoonLeastPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnMorningLeastPrefered
            // 
            this.rbnMorningLeastPrefered.AutoSize = true;
            this.rbnMorningLeastPrefered.Location = new System.Drawing.Point(108, 78);
            this.rbnMorningLeastPrefered.Name = "rbnMorningLeastPrefered";
            this.rbnMorningLeastPrefered.Size = new System.Drawing.Size(83, 24);
            this.rbnMorningLeastPrefered.TabIndex = 3;
            this.rbnMorningLeastPrefered.TabStop = true;
            this.rbnMorningLeastPrefered.Text = "Morning";
            this.rbnMorningLeastPrefered.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Day of the week:";
            // 
            // cbxLeastPreferedDay
            // 
            this.cbxLeastPreferedDay.FormattingEnabled = true;
            this.cbxLeastPreferedDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbxLeastPreferedDay.Location = new System.Drawing.Point(131, 30);
            this.cbxLeastPreferedDay.Name = "cbxLeastPreferedDay";
            this.cbxLeastPreferedDay.Size = new System.Drawing.Size(121, 28);
            this.cbxLeastPreferedDay.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbnEveningPrefered);
            this.groupBox1.Controls.Add(this.rbnAfternoonPrefered);
            this.groupBox1.Controls.Add(this.rbnMorningPrefered);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbxPreferedDay);
            this.groupBox1.Location = new System.Drawing.Point(201, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prefered work time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Select shift:";
            // 
            // rbnEveningPrefered
            // 
            this.rbnEveningPrefered.AutoSize = true;
            this.rbnEveningPrefered.Location = new System.Drawing.Point(297, 78);
            this.rbnEveningPrefered.Name = "rbnEveningPrefered";
            this.rbnEveningPrefered.Size = new System.Drawing.Size(79, 24);
            this.rbnEveningPrefered.TabIndex = 5;
            this.rbnEveningPrefered.TabStop = true;
            this.rbnEveningPrefered.Text = "Evening";
            this.rbnEveningPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnAfternoonPrefered
            // 
            this.rbnAfternoonPrefered.AutoSize = true;
            this.rbnAfternoonPrefered.Location = new System.Drawing.Point(197, 78);
            this.rbnAfternoonPrefered.Name = "rbnAfternoonPrefered";
            this.rbnAfternoonPrefered.Size = new System.Drawing.Size(94, 24);
            this.rbnAfternoonPrefered.TabIndex = 4;
            this.rbnAfternoonPrefered.TabStop = true;
            this.rbnAfternoonPrefered.Text = "Afternoon";
            this.rbnAfternoonPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnMorningPrefered
            // 
            this.rbnMorningPrefered.AutoSize = true;
            this.rbnMorningPrefered.Location = new System.Drawing.Point(108, 76);
            this.rbnMorningPrefered.Name = "rbnMorningPrefered";
            this.rbnMorningPrefered.Size = new System.Drawing.Size(83, 24);
            this.rbnMorningPrefered.TabIndex = 3;
            this.rbnMorningPrefered.TabStop = true;
            this.rbnMorningPrefered.Text = "Morning";
            this.rbnMorningPrefered.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Day of the week:";
            // 
            // cbxPreferedDay
            // 
            this.cbxPreferedDay.FormattingEnabled = true;
            this.cbxPreferedDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbxPreferedDay.Location = new System.Drawing.Point(131, 33);
            this.cbxPreferedDay.Name = "cbxPreferedDay";
            this.cbxPreferedDay.Size = new System.Drawing.Size(121, 28);
            this.cbxPreferedDay.TabIndex = 2;
            // 
            // FormSalesEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 619);
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
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstOverviewSchedule;
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
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnEveningLeastPrefered;
        private System.Windows.Forms.RadioButton rbnAfternoonLeastPrefered;
        private System.Windows.Forms.RadioButton rbnMorningLeastPrefered;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxLeastPreferedDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbnEveningPrefered;
        private System.Windows.Forms.RadioButton rbnAfternoonPrefered;
        private System.Windows.Forms.RadioButton rbnMorningPrefered;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxPreferedDay;
    }
}
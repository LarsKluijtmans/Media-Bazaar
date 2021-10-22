
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPreferedDay = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbProducts = new System.Windows.Forms.ListBox();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 513);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1130, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(779, 20);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(97, 55);
            this.btnProfile.TabIndex = 21;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(779, 370);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(97, 55);
            this.btnCheck.TabIndex = 20;
            this.btnCheck.Text = "Check In";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Schedule:";
            // 
            // lstOverviewSchedule
            // 
            this.lstOverviewSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewSchedule.FormattingEnabled = true;
            this.lstOverviewSchedule.ItemHeight = 17;
            this.lstOverviewSchedule.Location = new System.Drawing.Point(19, 47);
            this.lstOverviewSchedule.Name = "lstOverviewSchedule";
            this.lstOverviewSchedule.Size = new System.Drawing.Size(658, 378);
            this.lstOverviewSchedule.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSubmit);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1130, 483);
            this.tabPage2.TabIndex = 9;
            this.tabPage2.Text = "Availability";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(271, 304);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rbnEveningLeastPrefered);
            this.groupBox2.Controls.Add(this.rbnAfternoonLeastPrefered);
            this.groupBox2.Controls.Add(this.rbnMorningLeastPrefered);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbxLeastPreferedDay);
            this.groupBox2.Location = new System.Drawing.Point(17, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Least prefered work time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Select shift:";
            // 
            // rbnEveningLeastPrefered
            // 
            this.rbnEveningLeastPrefered.AutoSize = true;
            this.rbnEveningLeastPrefered.Location = new System.Drawing.Point(258, 78);
            this.rbnEveningLeastPrefered.Name = "rbnEveningLeastPrefered";
            this.rbnEveningLeastPrefered.Size = new System.Drawing.Size(71, 21);
            this.rbnEveningLeastPrefered.TabIndex = 5;
            this.rbnEveningLeastPrefered.TabStop = true;
            this.rbnEveningLeastPrefered.Text = "Evening";
            this.rbnEveningLeastPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnAfternoonLeastPrefered
            // 
            this.rbnAfternoonLeastPrefered.AutoSize = true;
            this.rbnAfternoonLeastPrefered.Location = new System.Drawing.Point(168, 78);
            this.rbnAfternoonLeastPrefered.Name = "rbnAfternoonLeastPrefered";
            this.rbnAfternoonLeastPrefered.Size = new System.Drawing.Size(84, 21);
            this.rbnAfternoonLeastPrefered.TabIndex = 4;
            this.rbnAfternoonLeastPrefered.TabStop = true;
            this.rbnAfternoonLeastPrefered.Text = "Afternoon";
            this.rbnAfternoonLeastPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnMorningLeastPrefered
            // 
            this.rbnMorningLeastPrefered.AutoSize = true;
            this.rbnMorningLeastPrefered.Location = new System.Drawing.Point(86, 78);
            this.rbnMorningLeastPrefered.Name = "rbnMorningLeastPrefered";
            this.rbnMorningLeastPrefered.Size = new System.Drawing.Size(76, 21);
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
            this.label10.Size = new System.Drawing.Size(104, 17);
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
            this.cbxLeastPreferedDay.Location = new System.Drawing.Point(116, 33);
            this.cbxLeastPreferedDay.Name = "cbxLeastPreferedDay";
            this.cbxLeastPreferedDay.Size = new System.Drawing.Size(121, 25);
            this.cbxLeastPreferedDay.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbnEveningPrefered);
            this.groupBox1.Controls.Add(this.rbnAfternoonPrefered);
            this.groupBox1.Controls.Add(this.rbnMorningPrefered);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxPreferedDay);
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prefered work time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Select shift:";
            // 
            // rbnEveningPrefered
            // 
            this.rbnEveningPrefered.AutoSize = true;
            this.rbnEveningPrefered.Location = new System.Drawing.Point(258, 78);
            this.rbnEveningPrefered.Name = "rbnEveningPrefered";
            this.rbnEveningPrefered.Size = new System.Drawing.Size(71, 21);
            this.rbnEveningPrefered.TabIndex = 5;
            this.rbnEveningPrefered.TabStop = true;
            this.rbnEveningPrefered.Text = "Evening";
            this.rbnEveningPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnAfternoonPrefered
            // 
            this.rbnAfternoonPrefered.AutoSize = true;
            this.rbnAfternoonPrefered.Location = new System.Drawing.Point(168, 78);
            this.rbnAfternoonPrefered.Name = "rbnAfternoonPrefered";
            this.rbnAfternoonPrefered.Size = new System.Drawing.Size(84, 21);
            this.rbnAfternoonPrefered.TabIndex = 4;
            this.rbnAfternoonPrefered.TabStop = true;
            this.rbnAfternoonPrefered.Text = "Afternoon";
            this.rbnAfternoonPrefered.UseVisualStyleBackColor = true;
            // 
            // rbnMorningPrefered
            // 
            this.rbnMorningPrefered.AutoSize = true;
            this.rbnMorningPrefered.Location = new System.Drawing.Point(86, 78);
            this.rbnMorningPrefered.Name = "rbnMorningPrefered";
            this.rbnMorningPrefered.Size = new System.Drawing.Size(76, 21);
            this.rbnMorningPrefered.TabIndex = 3;
            this.rbnMorningPrefered.TabStop = true;
            this.rbnMorningPrefered.Text = "Morning";
            this.rbnMorningPrefered.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Day of the week:";
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
            this.cbxPreferedDay.Location = new System.Drawing.Point(116, 33);
            this.cbxPreferedDay.Name = "cbxPreferedDay";
            this.cbxPreferedDay.Size = new System.Drawing.Size(121, 25);
            this.cbxPreferedDay.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbProducts);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1130, 483);
            this.tabPage3.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(791, 276);
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
            this.lblEmail.Location = new System.Drawing.Point(839, 149);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 21);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Barcode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Amount in store:";
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
            this.label2.Location = new System.Drawing.Point(31, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Product List:";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(920, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 33);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxPreferedDay;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbProducts;
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
    }
}
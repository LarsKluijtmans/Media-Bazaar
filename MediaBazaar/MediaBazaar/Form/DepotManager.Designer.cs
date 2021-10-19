
namespace MediaBazaar
{
    partial class DepotManager
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
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditschedule = new System.Windows.Forms.Button();
            this.btViewSchedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbScheduleEvening = new System.Windows.Forms.TextBox();
            this.lbScheduleAfternoon = new System.Windows.Forms.TextBox();
            this.lbScheduleMorning = new System.Windows.Forms.TextBox();
            this.lbScheduleDay = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbAmountInDepot = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPorduct = new System.Windows.Forms.Button();
            this.tbmountInStore = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbRestockID = new System.Windows.Forms.TextBox();
            this.tbRestockName = new System.Windows.Forms.TextBox();
            this.tbRestockAmountSales = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRestockAmount = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnViewAllRestockRequests = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFufillRestockRequest = new System.Windows.Forms.Button();
            this.RestockAmountDepot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbRestock = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbRequestID = new System.Windows.Forms.TextBox();
            this.tbRName = new System.Windows.Forms.TextBox();
            this.tbRamountInStore = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbReshelfReqAmount = new System.Windows.Forms.TextBox();
            this.tbRID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnViewAllReShelftReq = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnFufillReshelftRequest = new System.Windows.Forms.Button();
            this.tbRAmountInDepot = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbReshelfRequest = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnRemoveFromSchedule = new System.Windows.Forms.Button();
            this.btnAddToSchedule = new System.Windows.Forms.Button();
            this.lstEmpCanWork = new System.Windows.Forms.ListBox();
            this.lstEmpEnlisted = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(833, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.dgvSchedule);
            this.tpSchedule.Controls.Add(this.groupBox2);
            this.tpSchedule.Location = new System.Drawing.Point(4, 29);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSchedule.Size = new System.Drawing.Size(1293, 644);
            this.tpSchedule.TabIndex = 0;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(30, 41);
            this.dgvSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.RowHeadersWidth = 51;
            this.dgvSchedule.RowTemplate.Height = 25;
            this.dgvSchedule.Size = new System.Drawing.Size(819, 557);
            this.dgvSchedule.TabIndex = 5;
            this.dgvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditschedule);
            this.groupBox2.Controls.Add(this.btViewSchedule);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbScheduleEvening);
            this.groupBox2.Controls.Add(this.lbScheduleAfternoon);
            this.groupBox2.Controls.Add(this.lbScheduleMorning);
            this.groupBox2.Controls.Add(this.lbScheduleDay);
            this.groupBox2.Location = new System.Drawing.Point(885, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(386, 476);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Schedule";
            // 
            // btnEditschedule
            // 
            this.btnEditschedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditschedule.Location = new System.Drawing.Point(90, 395);
            this.btnEditschedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditschedule.Name = "btnEditschedule";
            this.btnEditschedule.Size = new System.Drawing.Size(246, 45);
            this.btnEditschedule.TabIndex = 14;
            this.btnEditschedule.Text = "Edit schedule";
            this.btnEditschedule.UseVisualStyleBackColor = true;
            this.btnEditschedule.Click += new System.EventHandler(this.btnEditschedule_Click);
            // 
            // btViewSchedule
            // 
            this.btViewSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btViewSchedule.Location = new System.Drawing.Point(90, 307);
            this.btViewSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btViewSchedule.Name = "btViewSchedule";
            this.btViewSchedule.Size = new System.Drawing.Size(246, 45);
            this.btViewSchedule.TabIndex = 13;
            this.btViewSchedule.Text = "View schedule";
            this.btViewSchedule.UseVisualStyleBackColor = true;
            this.btViewSchedule.Click += new System.EventHandler(this.btViewSchedule_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(77, 219);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 28);
            this.label24.TabIndex = 12;
            this.label24.Text = "Evening:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(59, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 28);
            this.label23.TabIndex = 11;
            this.label23.Text = "Afternoon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(74, 116);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 28);
            this.label22.TabIndex = 10;
            this.label22.Text = "Monday:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(109, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Day:";
            // 
            // lbScheduleEvening
            // 
            this.lbScheduleEvening.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleEvening.Location = new System.Drawing.Point(161, 215);
            this.lbScheduleEvening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbScheduleEvening.Name = "lbScheduleEvening";
            this.lbScheduleEvening.Size = new System.Drawing.Size(187, 34);
            this.lbScheduleEvening.TabIndex = 6;
            // 
            // lbScheduleAfternoon
            // 
            this.lbScheduleAfternoon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleAfternoon.Location = new System.Drawing.Point(161, 164);
            this.lbScheduleAfternoon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbScheduleAfternoon.Name = "lbScheduleAfternoon";
            this.lbScheduleAfternoon.Size = new System.Drawing.Size(187, 34);
            this.lbScheduleAfternoon.TabIndex = 5;
            // 
            // lbScheduleMorning
            // 
            this.lbScheduleMorning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleMorning.Location = new System.Drawing.Point(161, 112);
            this.lbScheduleMorning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbScheduleMorning.Name = "lbScheduleMorning";
            this.lbScheduleMorning.Size = new System.Drawing.Size(187, 34);
            this.lbScheduleMorning.TabIndex = 4;
            // 
            // lbScheduleDay
            // 
            this.lbScheduleDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDay.Location = new System.Drawing.Point(161, 60);
            this.lbScheduleDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbScheduleDay.Name = "lbScheduleDay";
            this.lbScheduleDay.ReadOnly = true;
            this.lbScheduleDay.Size = new System.Drawing.Size(187, 34);
            this.lbScheduleDay.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tpSchedule);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(16, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1301, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbProducts);
            this.tabPage3.Controls.Add(this.cbProductType);
            this.tabPage3.Controls.Add(this.tbName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblName);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbBarcode);
            this.tabPage3.Controls.Add(this.tbAmountInDepot);
            this.tabPage3.Controls.Add(this.lblEmail);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnAddPorduct);
            this.tabPage3.Controls.Add(this.tbmountInStore);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnGet);
            this.tabPage3.Controls.Add(this.btnEdit);
            this.tabPage3.Controls.Add(this.lblId);
            this.tabPage3.Controls.Add(this.tbID);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1293, 644);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 28;
            this.lbProducts.Location = new System.Drawing.Point(32, 59);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(841, 536);
            this.lbProducts.TabIndex = 45;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // cbProductType
            // 
            this.cbProductType.AllowDrop = true;
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(1053, 243);
            this.cbProductType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(183, 36);
            this.cbProductType.TabIndex = 44;
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
            this.label4.Location = new System.Drawing.Point(920, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Product type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(971, 137);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 28);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(901, 364);
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
            this.lblEmail.Location = new System.Drawing.Point(955, 195);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 28);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Barcode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(906, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 28);
            this.label8.TabIndex = 40;
            this.label8.Text = "Amount in store:";
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
            this.btnAddPorduct.Click += new System.EventHandler(this.btnAddPorduct_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1002, 84);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Product List:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.tbRestockID);
            this.tabPage4.Controls.Add(this.tbRestockName);
            this.tabPage4.Controls.Add(this.tbRestockAmountSales);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.tbRestockAmount);
            this.tabPage4.Controls.Add(this.tbProductID);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnViewAllRestockRequests);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.btnFufillRestockRequest);
            this.tabPage4.Controls.Add(this.RestockAmountDepot);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.lbRestock);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(1293, 644);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Restock";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1003, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 40);
            this.button1.TabIndex = 84;
            this.button1.Text = "Delete restock request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRestockID
            // 
            this.tbRestockID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockID.Location = new System.Drawing.Point(1070, 169);
            this.tbRestockID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockID.Name = "tbRestockID";
            this.tbRestockID.ReadOnly = true;
            this.tbRestockID.Size = new System.Drawing.Size(185, 34);
            this.tbRestockID.TabIndex = 82;
            // 
            // tbRestockName
            // 
            this.tbRestockName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockName.Location = new System.Drawing.Point(1070, 233);
            this.tbRestockName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockName.Name = "tbRestockName";
            this.tbRestockName.ReadOnly = true;
            this.tbRestockName.Size = new System.Drawing.Size(185, 34);
            this.tbRestockName.TabIndex = 81;
            // 
            // tbRestockAmountSales
            // 
            this.tbRestockAmountSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockAmountSales.Location = new System.Drawing.Point(1070, 288);
            this.tbRestockAmountSales.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockAmountSales.Name = "tbRestockAmountSales";
            this.tbRestockAmountSales.ReadOnly = true;
            this.tbRestockAmountSales.Size = new System.Drawing.Size(185, 34);
            this.tbRestockAmountSales.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(990, 401);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 28);
            this.label9.TabIndex = 79;
            this.label9.Text = "Amount:";
            // 
            // tbRestockAmount
            // 
            this.tbRestockAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRestockAmount.Location = new System.Drawing.Point(1070, 393);
            this.tbRestockAmount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRestockAmount.Name = "tbRestockAmount";
            this.tbRestockAmount.ReadOnly = true;
            this.tbRestockAmount.Size = new System.Drawing.Size(185, 34);
            this.tbRestockAmount.TabIndex = 78;
            // 
            // tbProductID
            // 
            this.tbProductID.Enabled = false;
            this.tbProductID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProductID.Location = new System.Drawing.Point(1070, 113);
            this.tbProductID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(185, 34);
            this.tbProductID.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1038, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 28);
            this.label10.TabIndex = 73;
            this.label10.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1011, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 28);
            this.label11.TabIndex = 68;
            this.label11.Text = "Name:";
            // 
            // btnViewAllRestockRequests
            // 
            this.btnViewAllRestockRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAllRestockRequests.Location = new System.Drawing.Point(1003, 457);
            this.btnViewAllRestockRequests.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewAllRestockRequests.Name = "btnViewAllRestockRequests";
            this.btnViewAllRestockRequests.Size = new System.Drawing.Size(238, 40);
            this.btnViewAllRestockRequests.TabIndex = 74;
            this.btnViewAllRestockRequests.Text = "View all restock requests";
            this.btnViewAllRestockRequests.UseVisualStyleBackColor = true;
            this.btnViewAllRestockRequests.Click += new System.EventHandler(this.btnViewAllRestockRequests_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(921, 348);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 28);
            this.label12.TabIndex = 77;
            this.label12.Text = "Amount in depot:";
            // 
            // btnFufillRestockRequest
            // 
            this.btnFufillRestockRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFufillRestockRequest.Location = new System.Drawing.Point(1003, 513);
            this.btnFufillRestockRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFufillRestockRequest.Name = "btnFufillRestockRequest";
            this.btnFufillRestockRequest.Size = new System.Drawing.Size(238, 40);
            this.btnFufillRestockRequest.TabIndex = 70;
            this.btnFufillRestockRequest.Text = "Fufill restock request";
            this.btnFufillRestockRequest.UseVisualStyleBackColor = true;
            this.btnFufillRestockRequest.Click += new System.EventHandler(this.btnFufillRestockRequest_Click);
            // 
            // RestockAmountDepot
            // 
            this.RestockAmountDepot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RestockAmountDepot.Location = new System.Drawing.Point(1070, 340);
            this.RestockAmountDepot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.RestockAmountDepot.Name = "RestockAmountDepot";
            this.RestockAmountDepot.ReadOnly = true;
            this.RestockAmountDepot.Size = new System.Drawing.Size(185, 34);
            this.RestockAmountDepot.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(927, 296);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 28);
            this.label13.TabIndex = 75;
            this.label13.Text = "Amount in store:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(977, 179);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 28);
            this.label14.TabIndex = 69;
            this.label14.Text = "RequestID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(24, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 28);
            this.label15.TabIndex = 57;
            this.label15.Text = "Restock Requests List:";
            // 
            // lbRestock
            // 
            this.lbRestock.FormattingEnabled = true;
            this.lbRestock.ItemHeight = 20;
            this.lbRestock.Location = new System.Drawing.Point(21, 64);
            this.lbRestock.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbRestock.Name = "lbRestock";
            this.lbRestock.Size = new System.Drawing.Size(895, 544);
            this.lbRestock.TabIndex = 56;
            this.lbRestock.SelectedIndexChanged += new System.EventHandler(this.lbRestock_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbRequestID);
            this.tabPage5.Controls.Add(this.tbRName);
            this.tabPage5.Controls.Add(this.tbRamountInStore);
            this.tabPage5.Controls.Add(this.lbAmount);
            this.tabPage5.Controls.Add(this.tbReshelfReqAmount);
            this.tabPage5.Controls.Add(this.tbRID);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.btnDeleteRequest);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.btnViewAllReShelftReq);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.btnFufillReshelftRequest);
            this.tabPage5.Controls.Add(this.tbRAmountInDepot);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.lbReshelfRequest);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(1293, 644);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Reshelf";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbRequestID
            // 
            this.tbRequestID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRequestID.Location = new System.Drawing.Point(1059, 164);
            this.tbRequestID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRequestID.Name = "tbRequestID";
            this.tbRequestID.ReadOnly = true;
            this.tbRequestID.Size = new System.Drawing.Size(185, 34);
            this.tbRequestID.TabIndex = 73;
            // 
            // tbRName
            // 
            this.tbRName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRName.Location = new System.Drawing.Point(1059, 220);
            this.tbRName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRName.Name = "tbRName";
            this.tbRName.ReadOnly = true;
            this.tbRName.Size = new System.Drawing.Size(185, 34);
            this.tbRName.TabIndex = 72;
            // 
            // tbRamountInStore
            // 
            this.tbRamountInStore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRamountInStore.Location = new System.Drawing.Point(1059, 277);
            this.tbRamountInStore.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRamountInStore.Name = "tbRamountInStore";
            this.tbRamountInStore.ReadOnly = true;
            this.tbRamountInStore.Size = new System.Drawing.Size(185, 34);
            this.tbRamountInStore.TabIndex = 71;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAmount.Location = new System.Drawing.Point(970, 397);
            this.lbAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(87, 28);
            this.lbAmount.TabIndex = 70;
            this.lbAmount.Text = "Amount:";
            // 
            // tbReshelfReqAmount
            // 
            this.tbReshelfReqAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbReshelfReqAmount.Location = new System.Drawing.Point(1059, 389);
            this.tbReshelfReqAmount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbReshelfReqAmount.Name = "tbReshelfReqAmount";
            this.tbReshelfReqAmount.ReadOnly = true;
            this.tbReshelfReqAmount.Size = new System.Drawing.Size(185, 34);
            this.tbReshelfReqAmount.TabIndex = 69;
            // 
            // tbRID
            // 
            this.tbRID.Enabled = false;
            this.tbRID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRID.Location = new System.Drawing.Point(1059, 105);
            this.tbRID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRID.Name = "tbRID";
            this.tbRID.ReadOnly = true;
            this.tbRID.Size = new System.Drawing.Size(185, 34);
            this.tbRID.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1017, 113);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 28);
            this.label17.TabIndex = 64;
            this.label17.Text = "ID:";
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRequest.Location = new System.Drawing.Point(969, 580);
            this.btnDeleteRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(237, 40);
            this.btnDeleteRequest.TabIndex = 62;
            this.btnDeleteRequest.Text = "Delete Request";
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            this.btnDeleteRequest.Click += new System.EventHandler(this.btnDeleteRequest_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(986, 228);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 28);
            this.label18.TabIndex = 59;
            this.label18.Text = "Name:";
            // 
            // btnViewAllReShelftReq
            // 
            this.btnViewAllReShelftReq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewAllReShelftReq.Location = new System.Drawing.Point(969, 464);
            this.btnViewAllReShelftReq.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnViewAllReShelftReq.Name = "btnViewAllReShelftReq";
            this.btnViewAllReShelftReq.Size = new System.Drawing.Size(237, 40);
            this.btnViewAllReShelftReq.TabIndex = 65;
            this.btnViewAllReShelftReq.Text = "View all reshelf requests";
            this.btnViewAllReShelftReq.UseVisualStyleBackColor = true;
            this.btnViewAllReShelftReq.Click += new System.EventHandler(this.btnViewAllReShelftReq_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(901, 343);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 28);
            this.label19.TabIndex = 68;
            this.label19.Text = "Amount in depot:";
            // 
            // btnFufillReshelftRequest
            // 
            this.btnFufillReshelftRequest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFufillReshelftRequest.Location = new System.Drawing.Point(969, 524);
            this.btnFufillReshelftRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFufillReshelftRequest.Name = "btnFufillReshelftRequest";
            this.btnFufillReshelftRequest.Size = new System.Drawing.Size(237, 40);
            this.btnFufillReshelftRequest.TabIndex = 61;
            this.btnFufillReshelftRequest.Text = "Fufill reshelf Request";
            this.btnFufillReshelftRequest.UseVisualStyleBackColor = true;
            this.btnFufillReshelftRequest.Click += new System.EventHandler(this.btnFufillReshelftRequest_Click);
            // 
            // tbRAmountInDepot
            // 
            this.tbRAmountInDepot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRAmountInDepot.Location = new System.Drawing.Point(1059, 335);
            this.tbRAmountInDepot.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbRAmountInDepot.Name = "tbRAmountInDepot";
            this.tbRAmountInDepot.ReadOnly = true;
            this.tbRAmountInDepot.Size = new System.Drawing.Size(185, 34);
            this.tbRAmountInDepot.TabIndex = 67;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(906, 285);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 28);
            this.label20.TabIndex = 66;
            this.label20.Text = "Amount in store:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(957, 172);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 28);
            this.label21.TabIndex = 60;
            this.label21.Text = "RequestID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(26, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 28);
            this.label16.TabIndex = 58;
            this.label16.Text = "ReshelfRequests List:";
            // 
            // lbReshelfRequest
            // 
            this.lbReshelfRequest.FormattingEnabled = true;
            this.lbReshelfRequest.ItemHeight = 20;
            this.lbReshelfRequest.Location = new System.Drawing.Point(23, 57);
            this.lbReshelfRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbReshelfRequest.Name = "lbReshelfRequest";
            this.lbReshelfRequest.Size = new System.Drawing.Size(835, 544);
            this.lbReshelfRequest.TabIndex = 36;
            this.lbReshelfRequest.SelectedIndexChanged += new System.EventHandler(this.lbReshelfRequest_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnRemoveFromSchedule);
            this.tabPage7.Controls.Add(this.btnAddToSchedule);
            this.tabPage7.Controls.Add(this.lstEmpCanWork);
            this.tabPage7.Controls.Add(this.lstEmpEnlisted);
            this.tabPage7.Controls.Add(this.dataGridView1);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage7.Size = new System.Drawing.Size(1293, 644);
            this.tabPage7.TabIndex = 11;
            this.tabPage7.Text = "Planning";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromSchedule
            // 
            this.btnRemoveFromSchedule.Location = new System.Drawing.Point(447, 544);
            this.btnRemoveFromSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            this.btnRemoveFromSchedule.Size = new System.Drawing.Size(120, 33);
            this.btnRemoveFromSchedule.TabIndex = 10;
            this.btnRemoveFromSchedule.Text = "Remove Employee";
            this.btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            // 
            // btnAddToSchedule
            // 
            this.btnAddToSchedule.Location = new System.Drawing.Point(1065, 101);
            this.btnAddToSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToSchedule.Name = "btnAddToSchedule";
            this.btnAddToSchedule.Size = new System.Drawing.Size(120, 79);
            this.btnAddToSchedule.TabIndex = 9;
            this.btnAddToSchedule.Text = "Add Employee";
            this.btnAddToSchedule.UseVisualStyleBackColor = true;
            // 
            // lstEmpCanWork
            // 
            this.lstEmpCanWork.FormattingEnabled = true;
            this.lstEmpCanWork.ItemHeight = 20;
            this.lstEmpCanWork.Location = new System.Drawing.Point(603, 32);
            this.lstEmpCanWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEmpCanWork.Name = "lstEmpCanWork";
            this.lstEmpCanWork.Size = new System.Drawing.Size(402, 584);
            this.lstEmpCanWork.TabIndex = 8;
            this.lstEmpCanWork.DoubleClick += new System.EventHandler(this.dd);
            // 
            // lstEmpEnlisted
            // 
            this.lstEmpEnlisted.FormattingEnabled = true;
            this.lstEmpEnlisted.ItemHeight = 20;
            this.lstEmpEnlisted.Location = new System.Drawing.Point(37, 411);
            this.lstEmpEnlisted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEmpEnlisted.Name = "lstEmpEnlisted";
            this.lstEmpEnlisted.Size = new System.Drawing.Size(530, 124);
            this.lstEmpEnlisted.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(530, 357);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(162, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 34);
            this.textBox3.TabIndex = 18;
            // 
            // DepotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 747);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "DepotManager";
            this.Text = "FormDepotManager";
            this.tpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbAmountInDepot;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddPorduct;
        private System.Windows.Forms.TextBox tbmountInStore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbRestockID;
        private System.Windows.Forms.TextBox tbRestockName;
        private System.Windows.Forms.TextBox tbRestockAmountSales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRestockAmount;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnViewAllRestockRequests;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFufillRestockRequest;
        private System.Windows.Forms.TextBox RestockAmountDepot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbRestock;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbRequestID;
        private System.Windows.Forms.TextBox tbRName;
        private System.Windows.Forms.TextBox tbRamountInStore;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbReshelfReqAmount;
        private System.Windows.Forms.TextBox tbRID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnViewAllReShelftReq;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnFufillReshelftRequest;
        private System.Windows.Forms.TextBox tbRAmountInDepot;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lbReshelfRequest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditschedule;
        private System.Windows.Forms.Button btViewSchedule;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbScheduleEvening;
        private System.Windows.Forms.TextBox lbScheduleAfternoon;
        private System.Windows.Forms.TextBox lbScheduleMorning;
        private System.Windows.Forms.TextBox lbScheduleDay;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Button btnRemoveFromSchedule;
        private System.Windows.Forms.Button btnAddToSchedule;
        private System.Windows.Forms.ListBox lstEmpCanWork;
        private System.Windows.Forms.ListBox lstEmpEnlisted;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
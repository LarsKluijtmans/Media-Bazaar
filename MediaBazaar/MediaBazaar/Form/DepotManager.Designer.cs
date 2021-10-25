
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPlanning = new System.Windows.Forms.TabPage();
            this.dgPlanningSchedule = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveFromSchedule = new System.Windows.Forms.Button();
            this.lstEmpCanWork = new System.Windows.Forms.ListBox();
            this.lstEmpEnlisted = new System.Windows.Forms.ListBox();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMonth = new System.Windows.Forms.Label();
            this.lbScheduleDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditschedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbScheduleEvening = new System.Windows.Forms.TextBox();
            this.lbScheduleAfternoon = new System.Windows.Forms.TextBox();
            this.lbScheduleMorning = new System.Windows.Forms.TextBox();
            this.tabRestock = new System.Windows.Forms.TabPage();
            this.dgRestock = new System.Windows.Forms.DataGridView();
            this.rbHistory = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmountRequested = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.Label();
            this.txtRestockID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFufillRestockRequest = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteRestockRequest = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dgSupplier = new System.Windows.Forms.DataGridView();
            this.dgOverviewRestock = new System.Windows.Forms.DataGridView();
            this.lstEmployeesWorkingToday = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgOverviewSchedule = new System.Windows.Forms.DataGridView();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.tabPlanning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).BeginInit();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabRestock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewRestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(898, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 34);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(162, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 29);
            this.textBox3.TabIndex = 18;
            // 
            // tabPlanning
            // 
            this.tabPlanning.Controls.Add(this.dgPlanningSchedule);
            this.tabPlanning.Controls.Add(this.label4);
            this.tabPlanning.Controls.Add(this.label3);
            this.tabPlanning.Controls.Add(this.label2);
            this.tabPlanning.Controls.Add(this.btnRemoveFromSchedule);
            this.tabPlanning.Controls.Add(this.lstEmpCanWork);
            this.tabPlanning.Controls.Add(this.lstEmpEnlisted);
            this.tabPlanning.Location = new System.Drawing.Point(4, 30);
            this.tabPlanning.Name = "tabPlanning";
            this.tabPlanning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlanning.Size = new System.Drawing.Size(954, 510);
            this.tabPlanning.TabIndex = 11;
            this.tabPlanning.Text = "Planning";
            this.tabPlanning.UseVisualStyleBackColor = true;
            // 
            // dgPlanningSchedule
            // 
            this.dgPlanningSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanningSchedule.Location = new System.Drawing.Point(32, 44);
            this.dgPlanningSchedule.Name = "dgPlanningSchedule";
            this.dgPlanningSchedule.RowHeadersWidth = 51;
            this.dgPlanningSchedule.RowTemplate.Height = 25;
            this.dgPlanningSchedule.Size = new System.Drawing.Size(525, 275);
            this.dgPlanningSchedule.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employees Working:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employees Free:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Schedule:";
            // 
            // btnRemoveFromSchedule
            // 
            this.btnRemoveFromSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromSchedule.Location = new System.Drawing.Point(452, 440);
            this.btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            this.btnRemoveFromSchedule.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveFromSchedule.TabIndex = 10;
            this.btnRemoveFromSchedule.Text = "Remove Employee";
            this.btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            // 
            // lstEmpCanWork
            // 
            this.lstEmpCanWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpCanWork.FormattingEnabled = true;
            this.lstEmpCanWork.ItemHeight = 17;
            this.lstEmpCanWork.Location = new System.Drawing.Point(586, 44);
            this.lstEmpCanWork.Name = "lstEmpCanWork";
            this.lstEmpCanWork.Size = new System.Drawing.Size(293, 395);
            this.lstEmpCanWork.TabIndex = 8;
            // 
            // lstEmpEnlisted
            // 
            this.lstEmpEnlisted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpEnlisted.FormattingEnabled = true;
            this.lstEmpEnlisted.ItemHeight = 17;
            this.lstEmpEnlisted.Location = new System.Drawing.Point(32, 346);
            this.lstEmpEnlisted.Name = "lstEmpEnlisted";
            this.lstEmpEnlisted.Size = new System.Drawing.Size(525, 89);
            this.lstEmpEnlisted.TabIndex = 7;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.label6);
            this.tabSchedule.Controls.Add(this.dgSchedule);
            this.tabSchedule.Controls.Add(this.groupBox2);
            this.tabSchedule.Location = new System.Drawing.Point(4, 30);
            this.tabSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSchedule.Size = new System.Drawing.Size(954, 510);
            this.tabSchedule.TabIndex = 0;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Schedule:";
            // 
            // dgSchedule
            // 
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Location = new System.Drawing.Point(26, 58);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.RowHeadersWidth = 51;
            this.dgSchedule.RowTemplate.Height = 25;
            this.dgSchedule.Size = new System.Drawing.Size(528, 325);
            this.dgSchedule.TabIndex = 5;
            this.dgSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSchedule_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMonth);
            this.groupBox2.Controls.Add(this.lbScheduleDay);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEditschedule);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbScheduleEvening);
            this.groupBox2.Controls.Add(this.lbScheduleAfternoon);
            this.groupBox2.Controls.Add(this.lbScheduleMorning);
            this.groupBox2.Location = new System.Drawing.Point(622, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 297);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule Management";
            // 
            // txtMonth
            // 
            this.txtMonth.AutoSize = true;
            this.txtMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonth.Location = new System.Drawing.Point(108, 93);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(46, 17);
            this.txtMonth.TabIndex = 18;
            this.txtMonth.Text = "Month";
            // 
            // lbScheduleDay
            // 
            this.lbScheduleDay.AutoSize = true;
            this.lbScheduleDay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDay.Location = new System.Drawing.Point(108, 49);
            this.lbScheduleDay.Name = "lbScheduleDay";
            this.lbScheduleDay.Size = new System.Drawing.Size(30, 17);
            this.lbScheduleDay.TabIndex = 17;
            this.lbScheduleDay.Text = "Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(46, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Month:";
            // 
            // btnEditschedule
            // 
            this.btnEditschedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditschedule.Location = new System.Drawing.Point(63, 253);
            this.btnEditschedule.Name = "btnEditschedule";
            this.btnEditschedule.Size = new System.Drawing.Size(118, 26);
            this.btnEditschedule.TabIndex = 14;
            this.btnEditschedule.Text = "Update schedule";
            this.btnEditschedule.UseVisualStyleBackColor = true;
            this.btnEditschedule.Click += new System.EventHandler(this.btnEditschedule_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(39, 214);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 17);
            this.label24.TabIndex = 12;
            this.label24.Text = "Evening:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(26, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 17);
            this.label23.TabIndex = 11;
            this.label23.Text = "Afternoon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(36, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 17);
            this.label22.TabIndex = 10;
            this.label22.Text = "Morning:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(62, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Day:";
            // 
            // lbScheduleEvening
            // 
            this.lbScheduleEvening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleEvening.Location = new System.Drawing.Point(108, 211);
            this.lbScheduleEvening.Name = "lbScheduleEvening";
            this.lbScheduleEvening.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleEvening.TabIndex = 6;
            // 
            // lbScheduleAfternoon
            // 
            this.lbScheduleAfternoon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleAfternoon.Location = new System.Drawing.Point(108, 173);
            this.lbScheduleAfternoon.Name = "lbScheduleAfternoon";
            this.lbScheduleAfternoon.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleAfternoon.TabIndex = 5;
            // 
            // lbScheduleMorning
            // 
            this.lbScheduleMorning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleMorning.Location = new System.Drawing.Point(108, 134);
            this.lbScheduleMorning.Name = "lbScheduleMorning";
            this.lbScheduleMorning.Size = new System.Drawing.Size(73, 25);
            this.lbScheduleMorning.TabIndex = 4;
            // 
            // tabRestock
            // 
            this.tabRestock.Controls.Add(this.dgRestock);
            this.tabRestock.Controls.Add(this.rbHistory);
            this.tabRestock.Controls.Add(this.rbPending);
            this.tabRestock.Controls.Add(this.groupBox1);
            this.tabRestock.Controls.Add(this.label15);
            this.tabRestock.Location = new System.Drawing.Point(4, 30);
            this.tabRestock.Name = "tabRestock";
            this.tabRestock.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestock.Size = new System.Drawing.Size(954, 510);
            this.tabRestock.TabIndex = 5;
            this.tabRestock.Text = "Restock";
            this.tabRestock.UseVisualStyleBackColor = true;
            // 
            // dgRestock
            // 
            this.dgRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestock.Location = new System.Drawing.Point(18, 66);
            this.dgRestock.Name = "dgRestock";
            this.dgRestock.RowHeadersWidth = 51;
            this.dgRestock.RowTemplate.Height = 25;
            this.dgRestock.Size = new System.Drawing.Size(603, 386);
            this.dgRestock.TabIndex = 91;
            this.dgRestock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRestock_CellClick);
            // 
            // rbHistory
            // 
            this.rbHistory.AutoSize = true;
            this.rbHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbHistory.Location = new System.Drawing.Point(409, 39);
            this.rbHistory.Name = "rbHistory";
            this.rbHistory.Size = new System.Drawing.Size(120, 21);
            this.rbHistory.TabIndex = 90;
            this.rbHistory.Text = "Previous History";
            this.rbHistory.UseVisualStyleBackColor = true;
            this.rbHistory.CheckedChanged += new System.EventHandler(this.rbHistory_CheckedChanged);
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Checked = true;
            this.rbPending.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPending.Location = new System.Drawing.Point(319, 39);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(73, 21);
            this.rbPending.TabIndex = 89;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending";
            this.rbPending.UseVisualStyleBackColor = true;
            this.rbPending.Click += new System.EventHandler(this.rbPending_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmountRequested);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.txtRestockID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFufillRestockRequest);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnDeleteRestockRequest);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(656, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 265);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restock Management";
            // 
            // txtAmountRequested
            // 
            this.txtAmountRequested.AutoSize = true;
            this.txtAmountRequested.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmountRequested.Location = new System.Drawing.Point(136, 135);
            this.txtAmountRequested.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAmountRequested.Name = "txtAmountRequested";
            this.txtAmountRequested.Size = new System.Drawing.Size(53, 17);
            this.txtAmountRequested.TabIndex = 93;
            this.txtAmountRequested.Text = "Amount";
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoSize = true;
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(136, 106);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(56, 17);
            this.txtBarcode.TabIndex = 92;
            this.txtBarcode.Text = "Barcode";
            // 
            // txtProductID
            // 
            this.txtProductID.AutoSize = true;
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductID.Location = new System.Drawing.Point(136, 79);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(65, 17);
            this.txtProductID.TabIndex = 91;
            this.txtProductID.Text = "ProductID";
            // 
            // txtRestockID
            // 
            this.txtRestockID.AutoSize = true;
            this.txtRestockID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRestockID.Location = new System.Drawing.Point(136, 47);
            this.txtRestockID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtRestockID.Name = "txtRestockID";
            this.txtRestockID.Size = new System.Drawing.Size(65, 17);
            this.txtRestockID.TabIndex = 90;
            this.txtRestockID.Text = "RestockID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(60, 79);
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
            this.label14.Location = new System.Drawing.Point(60, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 69;
            this.label14.Text = "Restock ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "Barcode:";
            // 
            // btnFufillRestockRequest
            // 
            this.btnFufillRestockRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFufillRestockRequest.Location = new System.Drawing.Point(32, 178);
            this.btnFufillRestockRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFufillRestockRequest.Name = "btnFufillRestockRequest";
            this.btnFufillRestockRequest.Size = new System.Drawing.Size(176, 30);
            this.btnFufillRestockRequest.TabIndex = 70;
            this.btnFufillRestockRequest.Text = "Fufill restock request";
            this.btnFufillRestockRequest.UseVisualStyleBackColor = true;
            this.btnFufillRestockRequest.Click += new System.EventHandler(this.btnFufillRestockRequest_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(10, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Amount Requested:";
            // 
            // btnDeleteRestockRequest
            // 
            this.btnDeleteRestockRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteRestockRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRestockRequest.Location = new System.Drawing.Point(32, 210);
            this.btnDeleteRestockRequest.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteRestockRequest.Name = "btnDeleteRestockRequest";
            this.btnDeleteRestockRequest.Size = new System.Drawing.Size(176, 30);
            this.btnDeleteRestockRequest.TabIndex = 84;
            this.btnDeleteRestockRequest.Text = "Delete restock request";
            this.btnDeleteRestockRequest.UseVisualStyleBackColor = true;
            this.btnDeleteRestockRequest.Click += new System.EventHandler(this.btnDeleteRestockRequest_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(18, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 21);
            this.label15.TabIndex = 57;
            this.label15.Text = "Restock Requests:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOverview);
            this.tabControl1.Controls.Add(this.tabRestock);
            this.tabControl1.Controls.Add(this.tabSchedule);
            this.tabControl1.Controls.Add(this.tabPlanning);
            this.tabControl1.Controls.Add(this.tabSupplier);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(33, 49);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.label13);
            this.tabOverview.Controls.Add(this.dgSupplier);
            this.tabOverview.Controls.Add(this.dgOverviewRestock);
            this.tabOverview.Controls.Add(this.lstEmployeesWorkingToday);
            this.tabOverview.Controls.Add(this.label12);
            this.tabOverview.Controls.Add(this.label11);
            this.tabOverview.Controls.Add(this.label10);
            this.tabOverview.Controls.Add(this.dgOverviewSchedule);
            this.tabOverview.Location = new System.Drawing.Point(4, 30);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(954, 510);
            this.tabOverview.TabIndex = 12;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(520, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 92;
            this.label13.Text = "Supplier:";
            // 
            // dgSupplier
            // 
            this.dgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSupplier.Location = new System.Drawing.Point(520, 314);
            this.dgSupplier.Name = "dgSupplier";
            this.dgSupplier.RowHeadersWidth = 51;
            this.dgSupplier.RowTemplate.Height = 25;
            this.dgSupplier.Size = new System.Drawing.Size(410, 190);
            this.dgSupplier.TabIndex = 91;
            this.dgSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dgOverviewRestock
            // 
            this.dgOverviewRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOverviewRestock.Location = new System.Drawing.Point(21, 314);
            this.dgOverviewRestock.Name = "dgOverviewRestock";
            this.dgOverviewRestock.RowHeadersWidth = 51;
            this.dgOverviewRestock.RowTemplate.Height = 25;
            this.dgOverviewRestock.Size = new System.Drawing.Size(487, 190);
            this.dgOverviewRestock.TabIndex = 90;
            this.dgOverviewRestock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOverviewRestock_CellDoubleClick);
            // 
            // lstEmployeesWorkingToday
            // 
            this.lstEmployeesWorkingToday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmployeesWorkingToday.FormattingEnabled = true;
            this.lstEmployeesWorkingToday.ItemHeight = 17;
            this.lstEmployeesWorkingToday.Location = new System.Drawing.Point(528, 27);
            this.lstEmployeesWorkingToday.Name = "lstEmployeesWorkingToday";
            this.lstEmployeesWorkingToday.Size = new System.Drawing.Size(402, 242);
            this.lstEmployeesWorkingToday.TabIndex = 89;
            this.lstEmployeesWorkingToday.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEmployeesWorkingToday_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 21);
            this.label12.TabIndex = 88;
            this.label12.Text = "Employees Working Today:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 21);
            this.label11.TabIndex = 86;
            this.label11.Text = "Pending Restock Requests:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Schedule:";
            // 
            // dgOverviewSchedule
            // 
            this.dgOverviewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOverviewSchedule.Location = new System.Drawing.Point(21, 27);
            this.dgOverviewSchedule.Name = "dgOverviewSchedule";
            this.dgOverviewSchedule.RowHeadersWidth = 51;
            this.dgOverviewSchedule.RowTemplate.Height = 25;
            this.dgOverviewSchedule.Size = new System.Drawing.Size(487, 251);
            this.dgOverviewSchedule.TabIndex = 13;
            this.dgOverviewSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOverviewSchedule_CellDoubleClick);
            // 
            // tabSupplier
            // 
            this.tabSupplier.Location = new System.Drawing.Point(4, 30);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplier.Size = new System.Drawing.Size(954, 510);
            this.tabSupplier.TabIndex = 13;
            this.tabSupplier.Text = "Supplier";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // DepotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 604);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DepotManager";
            this.Text = "DepotManager";
            this.tabPlanning.ResumeLayout(false);
            this.tabPlanning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).EndInit();
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabRestock.ResumeLayout(false);
            this.tabRestock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewRestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPlanning;
        private System.Windows.Forms.Button btnRemoveFromSchedule;
        private System.Windows.Forms.ListBox lstEmpCanWork;
        private System.Windows.Forms.ListBox lstEmpEnlisted;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditschedule;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lbScheduleEvening;
        private System.Windows.Forms.TextBox lbScheduleAfternoon;
        private System.Windows.Forms.TextBox lbScheduleMorning;
        private System.Windows.Forms.TabPage tabRestock;
        private System.Windows.Forms.Button btnDeleteRestockRequest;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFufillRestockRequest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.ListBox lstEmployeesWorkingToday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgOverviewSchedule;
        private System.Windows.Forms.RadioButton rbHistory;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.DataGridView dgPlanningSchedule;
        private System.Windows.Forms.DataGridView dgRestock;
        private System.Windows.Forms.DataGridView dgOverviewRestock;
        private System.Windows.Forms.Label txtAmountRequested;
        private System.Windows.Forms.Label txtBarcode;
        private System.Windows.Forms.Label txtProductID;
        private System.Windows.Forms.Label txtRestockID;
        private System.Windows.Forms.Label txtMonth;
        private System.Windows.Forms.Label lbScheduleDay;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgSupplier;
    }
}
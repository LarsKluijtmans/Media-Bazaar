
namespace MediaBazaar
{
    partial class SalesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.lstEmployeesWorkingToday = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgOverviewSchedule = new System.Windows.Forms.DataGridView();
            this.txtProductID = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxProductType = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxProductID = new System.Windows.Forms.TextBox();
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnDecreaseWeek = new System.Windows.Forms.Button();
            this.btnIncreaseWeek = new System.Windows.Forms.Button();
            this.lblWeek = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMonth = new System.Windows.Forms.Label();
            this.lbScheduleDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditschedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScheduleEvening = new System.Windows.Forms.TextBox();
            this.lbScheduleAfternoon = new System.Windows.Forms.TextBox();
            this.lbScheduleMorning = new System.Windows.Forms.TextBox();
            this.tabPlanning = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlanningYear = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblPlanningWeek = new System.Windows.Forms.Label();
            this.dgPlanningSchedule = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveFromSchedule = new System.Windows.Forms.Button();
            this.lstEmpCanWork = new System.Windows.Forms.ListBox();
            this.lstEmpEnlisted = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).BeginInit();
            this.txtProductID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPlanning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOverview);
            this.tabControl1.Controls.Add(this.txtProductID);
            this.tabControl1.Controls.Add(this.tabSchedule);
            this.tabControl1.Controls.Add(this.tabPlanning);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(14, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1130, 751);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.label13);
            this.tabOverview.Controls.Add(this.dgProduct);
            this.tabOverview.Controls.Add(this.lstEmployeesWorkingToday);
            this.tabOverview.Controls.Add(this.label12);
            this.tabOverview.Controls.Add(this.label14);
            this.tabOverview.Controls.Add(this.dgOverviewSchedule);
            this.tabOverview.Location = new System.Drawing.Point(4, 37);
            this.tabOverview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabOverview.Size = new System.Drawing.Size(1122, 710);
            this.tabOverview.TabIndex = 12;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(25, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 28);
            this.label13.TabIndex = 100;
            this.label13.Text = "Product:";
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(24, 435);
            this.dgProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.RowHeadersWidth = 51;
            this.dgProduct.RowTemplate.Height = 25;
            this.dgProduct.Size = new System.Drawing.Size(558, 253);
            this.dgProduct.TabIndex = 99;
            this.dgProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduct_CellDoubleClick);
            // 
            // lstEmployeesWorkingToday
            // 
            this.lstEmployeesWorkingToday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmployeesWorkingToday.FormattingEnabled = true;
            this.lstEmployeesWorkingToday.ItemHeight = 21;
            this.lstEmployeesWorkingToday.Location = new System.Drawing.Point(606, 51);
            this.lstEmployeesWorkingToday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEmployeesWorkingToday.Name = "lstEmployeesWorkingToday";
            this.lstEmployeesWorkingToday.Size = new System.Drawing.Size(459, 634);
            this.lstEmployeesWorkingToday.TabIndex = 97;
            this.lstEmployeesWorkingToday.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEmployeesWorkingToday_MouseDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 28);
            this.label12.TabIndex = 96;
            this.label12.Text = "Employees Working Today:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 28);
            this.label14.TabIndex = 94;
            this.label14.Text = "Schedule:";
            // 
            // dgOverviewSchedule
            // 
            this.dgOverviewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOverviewSchedule.Location = new System.Drawing.Point(25, 49);
            this.dgOverviewSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgOverviewSchedule.Name = "dgOverviewSchedule";
            this.dgOverviewSchedule.RowHeadersWidth = 51;
            this.dgOverviewSchedule.RowTemplate.Height = 25;
            this.dgOverviewSchedule.Size = new System.Drawing.Size(557, 335);
            this.dgOverviewSchedule.TabIndex = 93;
            this.dgOverviewSchedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOverviewSchedule_CellDoubleClick);
            // 
            // txtProductID
            // 
            this.txtProductID.Controls.Add(this.dgvProducts);
            this.txtProductID.Controls.Add(this.label3);
            this.txtProductID.Controls.Add(this.groupBox1);
            this.txtProductID.Location = new System.Drawing.Point(4, 37);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Padding = new System.Windows.Forms.Padding(3);
            this.txtProductID.Size = new System.Drawing.Size(1122, 710);
            this.txtProductID.TabIndex = 3;
            this.txtProductID.Text = "Products ";
            this.txtProductID.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(29, 55);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(649, 477);
            this.dgvProducts.TabIndex = 97;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product List:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxProductType);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.tbxBarcode);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.tbxProductID);
            this.groupBox1.Controls.Add(this.btnDiscontinue);
            this.groupBox1.Controls.Add(this.btnEditProduct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(717, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 443);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Management";
            // 
            // tbxProductType
            // 
            this.tbxProductType.Location = new System.Drawing.Point(138, 171);
            this.tbxProductType.Name = "tbxProductType";
            this.tbxProductType.ReadOnly = true;
            this.tbxProductType.Size = new System.Drawing.Size(151, 34);
            this.tbxProductType.TabIndex = 63;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(138, 211);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(151, 34);
            this.tbxPrice.TabIndex = 62;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(138, 129);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.ReadOnly = true;
            this.tbxBarcode.Size = new System.Drawing.Size(151, 34);
            this.tbxBarcode.TabIndex = 61;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(138, 88);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.ReadOnly = true;
            this.tbxProductName.Size = new System.Drawing.Size(151, 34);
            this.tbxProductName.TabIndex = 60;
            // 
            // tbxProductID
            // 
            this.tbxProductID.Location = new System.Drawing.Point(138, 47);
            this.tbxProductID.Name = "tbxProductID";
            this.tbxProductID.ReadOnly = true;
            this.tbxProductID.Size = new System.Drawing.Size(151, 34);
            this.tbxProductID.TabIndex = 59;
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiscontinue.Location = new System.Drawing.Point(129, 295);
            this.btnDiscontinue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(157, 57);
            this.btnDiscontinue.TabIndex = 58;
            this.btnDiscontinue.Text = "Discontinue Product";
            this.btnDiscontinue.UseVisualStyleBackColor = true;
            this.btnDiscontinue.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditProduct.Location = new System.Drawing.Point(129, 252);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(157, 35);
            this.btnEditProduct.TabIndex = 57;
            this.btnEditProduct.Text = "Update Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Product Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(60, 98);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(41, 139);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 20);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "Barcode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Price:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(77, 57);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 20);
            this.lblId.TabIndex = 50;
            this.lblId.Text = "ID:";
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.label11);
            this.tabSchedule.Controls.Add(this.label6);
            this.tabSchedule.Controls.Add(this.txtYear);
            this.tabSchedule.Controls.Add(this.btnDecreaseWeek);
            this.tabSchedule.Controls.Add(this.btnIncreaseWeek);
            this.tabSchedule.Controls.Add(this.lblWeek);
            this.tabSchedule.Controls.Add(this.label2);
            this.tabSchedule.Controls.Add(this.dgSchedule);
            this.tabSchedule.Controls.Add(this.groupBox2);
            this.tabSchedule.Location = new System.Drawing.Point(4, 37);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(1122, 710);
            this.tabSchedule.TabIndex = 4;
            this.tabSchedule.Text = "Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(343, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 28);
            this.label11.TabIndex = 67;
            this.label11.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 66;
            this.label6.Text = "Week";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(343, 61);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(110, 34);
            this.txtYear.TabIndex = 65;
            // 
            // btnDecreaseWeek
            // 
            this.btnDecreaseWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecreaseWeek.Location = new System.Drawing.Point(205, 57);
            this.btnDecreaseWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecreaseWeek.Name = "btnDecreaseWeek";
            this.btnDecreaseWeek.Size = new System.Drawing.Size(31, 47);
            this.btnDecreaseWeek.TabIndex = 64;
            this.btnDecreaseWeek.Text = "<";
            this.btnDecreaseWeek.UseVisualStyleBackColor = true;
            this.btnDecreaseWeek.Click += new System.EventHandler(this.btnDecreaseWeek_Click);
            // 
            // btnIncreaseWeek
            // 
            this.btnIncreaseWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncreaseWeek.Location = new System.Drawing.Point(288, 57);
            this.btnIncreaseWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIncreaseWeek.Name = "btnIncreaseWeek";
            this.btnIncreaseWeek.Size = new System.Drawing.Size(31, 47);
            this.btnIncreaseWeek.TabIndex = 63;
            this.btnIncreaseWeek.Text = ">";
            this.btnIncreaseWeek.UseVisualStyleBackColor = true;
            this.btnIncreaseWeek.Click += new System.EventHandler(this.btnIncreaseWeek_Click);
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(242, 65);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(42, 28);
            this.lblWeek.TabIndex = 62;
            this.lblWeek.Text = "NN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 61;
            this.label2.Text = "Schedule:";
            // 
            // dgSchedule
            // 
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Location = new System.Drawing.Point(25, 127);
            this.dgSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.RowHeadersWidth = 51;
            this.dgSchedule.RowTemplate.Height = 25;
            this.dgSchedule.Size = new System.Drawing.Size(603, 433);
            this.dgSchedule.TabIndex = 60;
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
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbScheduleEvening);
            this.groupBox2.Controls.Add(this.lbScheduleAfternoon);
            this.groupBox2.Controls.Add(this.lbScheduleMorning);
            this.groupBox2.Location = new System.Drawing.Point(704, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(256, 396);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule Management";
            // 
            // txtMonth
            // 
            this.txtMonth.AutoSize = true;
            this.txtMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonth.Location = new System.Drawing.Point(123, 124);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(61, 23);
            this.txtMonth.TabIndex = 18;
            this.txtMonth.Text = "Month";
            // 
            // lbScheduleDay
            // 
            this.lbScheduleDay.AutoSize = true;
            this.lbScheduleDay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDay.Location = new System.Drawing.Point(123, 65);
            this.lbScheduleDay.Name = "lbScheduleDay";
            this.lbScheduleDay.Size = new System.Drawing.Size(39, 23);
            this.lbScheduleDay.TabIndex = 17;
            this.lbScheduleDay.Text = "Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(53, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Month:";
            // 
            // btnEditschedule
            // 
            this.btnEditschedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditschedule.Location = new System.Drawing.Point(72, 337);
            this.btnEditschedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditschedule.Name = "btnEditschedule";
            this.btnEditschedule.Size = new System.Drawing.Size(135, 35);
            this.btnEditschedule.TabIndex = 14;
            this.btnEditschedule.Text = "Update schedule";
            this.btnEditschedule.UseVisualStyleBackColor = true;
            this.btnEditschedule.Click += new System.EventHandler(this.btnEditschedule_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(45, 285);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 23);
            this.label24.TabIndex = 12;
            this.label24.Text = "Evening:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(30, 235);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 23);
            this.label23.TabIndex = 11;
            this.label23.Text = "Afternoon:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(41, 183);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 23);
            this.label22.TabIndex = 10;
            this.label22.Text = "Morning:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Day:";
            // 
            // lbScheduleEvening
            // 
            this.lbScheduleEvening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleEvening.Location = new System.Drawing.Point(123, 281);
            this.lbScheduleEvening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbScheduleEvening.Name = "lbScheduleEvening";
            this.lbScheduleEvening.Size = new System.Drawing.Size(83, 29);
            this.lbScheduleEvening.TabIndex = 6;
            // 
            // lbScheduleAfternoon
            // 
            this.lbScheduleAfternoon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleAfternoon.Location = new System.Drawing.Point(123, 231);
            this.lbScheduleAfternoon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbScheduleAfternoon.Name = "lbScheduleAfternoon";
            this.lbScheduleAfternoon.Size = new System.Drawing.Size(83, 29);
            this.lbScheduleAfternoon.TabIndex = 5;
            // 
            // lbScheduleMorning
            // 
            this.lbScheduleMorning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleMorning.Location = new System.Drawing.Point(123, 179);
            this.lbScheduleMorning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbScheduleMorning.Name = "lbScheduleMorning";
            this.lbScheduleMorning.Size = new System.Drawing.Size(83, 29);
            this.lbScheduleMorning.TabIndex = 4;
            // 
            // tabPlanning
            // 
            this.tabPlanning.Controls.Add(this.label15);
            this.tabPlanning.Controls.Add(this.label16);
            this.tabPlanning.Controls.Add(this.txtPlanningYear);
            this.tabPlanning.Controls.Add(this.button3);
            this.tabPlanning.Controls.Add(this.button4);
            this.tabPlanning.Controls.Add(this.lblPlanningWeek);
            this.tabPlanning.Controls.Add(this.dgPlanningSchedule);
            this.tabPlanning.Controls.Add(this.label8);
            this.tabPlanning.Controls.Add(this.label9);
            this.tabPlanning.Controls.Add(this.label10);
            this.tabPlanning.Controls.Add(this.btnRemoveFromSchedule);
            this.tabPlanning.Controls.Add(this.lstEmpCanWork);
            this.tabPlanning.Controls.Add(this.lstEmpEnlisted);
            this.tabPlanning.Location = new System.Drawing.Point(4, 37);
            this.tabPlanning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPlanning.Name = "tabPlanning";
            this.tabPlanning.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPlanning.Size = new System.Drawing.Size(1122, 710);
            this.tabPlanning.TabIndex = 11;
            this.tabPlanning.Text = "Planning";
            this.tabPlanning.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(350, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 28);
            this.label15.TabIndex = 73;
            this.label15.Text = "Year";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 28);
            this.label16.TabIndex = 72;
            this.label16.Text = "Week";
            // 
            // txtPlanningYear
            // 
            this.txtPlanningYear.Location = new System.Drawing.Point(350, 40);
            this.txtPlanningYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlanningYear.Name = "txtPlanningYear";
            this.txtPlanningYear.Size = new System.Drawing.Size(110, 34);
            this.txtPlanningYear.TabIndex = 71;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(211, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 47);
            this.button3.TabIndex = 70;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(295, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 47);
            this.button4.TabIndex = 69;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblPlanningWeek
            // 
            this.lblPlanningWeek.AutoSize = true;
            this.lblPlanningWeek.Location = new System.Drawing.Point(249, 44);
            this.lblPlanningWeek.Name = "lblPlanningWeek";
            this.lblPlanningWeek.Size = new System.Drawing.Size(42, 28);
            this.lblPlanningWeek.TabIndex = 68;
            this.lblPlanningWeek.Text = "NN";
            // 
            // dgPlanningSchedule
            // 
            this.dgPlanningSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanningSchedule.Location = new System.Drawing.Point(21, 87);
            this.dgPlanningSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgPlanningSchedule.Name = "dgPlanningSchedule";
            this.dgPlanningSchedule.RowHeadersWidth = 51;
            this.dgPlanningSchedule.RowTemplate.Height = 25;
            this.dgPlanningSchedule.Size = new System.Drawing.Size(600, 367);
            this.dgPlanningSchedule.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Employees Working:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Employees Free:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Schedule:";
            // 
            // btnRemoveFromSchedule
            // 
            this.btnRemoveFromSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveFromSchedule.Location = new System.Drawing.Point(501, 663);
            this.btnRemoveFromSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveFromSchedule.Name = "btnRemoveFromSchedule";
            this.btnRemoveFromSchedule.Size = new System.Drawing.Size(120, 37);
            this.btnRemoveFromSchedule.TabIndex = 17;
            this.btnRemoveFromSchedule.Text = "Remove Employee";
            this.btnRemoveFromSchedule.UseVisualStyleBackColor = true;
            // 
            // lstEmpCanWork
            // 
            this.lstEmpCanWork.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpCanWork.FormattingEnabled = true;
            this.lstEmpCanWork.ItemHeight = 21;
            this.lstEmpCanWork.Location = new System.Drawing.Point(654, 52);
            this.lstEmpCanWork.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEmpCanWork.Name = "lstEmpCanWork";
            this.lstEmpCanWork.Size = new System.Drawing.Size(334, 508);
            this.lstEmpCanWork.TabIndex = 16;
            // 
            // lstEmpEnlisted
            // 
            this.lstEmpEnlisted.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmpEnlisted.FormattingEnabled = true;
            this.lstEmpEnlisted.ItemHeight = 21;
            this.lstEmpEnlisted.Location = new System.Drawing.Point(21, 491);
            this.lstEmpEnlisted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEmpEnlisted.Name = "lstEmpEnlisted";
            this.lstEmpEnlisted.Size = new System.Drawing.Size(599, 151);
            this.lstEmpEnlisted.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1050, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 45);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 819);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesManager";
            this.Text = "FormSalesManager";
            this.tabControl1.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOverviewSchedule)).EndInit();
            this.txtProductID.ResumeLayout(false);
            this.txtProductID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPlanning.ResumeLayout(false);
            this.tabPlanning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanningSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabPlanning;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtMonth;
        private System.Windows.Forms.Label lbScheduleDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditschedule;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbScheduleEvening;
        private System.Windows.Forms.TextBox lbScheduleAfternoon;
        private System.Windows.Forms.TextBox lbScheduleMorning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.DataGridView dgPlanningSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRemoveFromSchedule;
        private System.Windows.Forms.ListBox lstEmpCanWork;
        private System.Windows.Forms.ListBox lstEmpEnlisted;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.ListBox lstEmployeesWorkingToday;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgOverviewSchedule;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnDiscontinue;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnDecreaseWeek;
        private System.Windows.Forms.Button btnIncreaseWeek;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlanningYear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblPlanningWeek;
        private System.Windows.Forms.TextBox tbxProductType;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxProductID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
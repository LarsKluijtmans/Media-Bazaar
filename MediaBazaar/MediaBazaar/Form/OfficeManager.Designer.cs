
namespace MediaBazaar
{
    partial class OfficeManager
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
            this.Departments = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.btnReadEmployee = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.rbnOfficeEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.Company = new System.Windows.Forms.TabPage();
            this.gbCompanyInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompanyPhoneNumber = new System.Windows.Forms.TextBox();
            this.labBTW = new System.Windows.Forms.Label();
            this.tbBTW = new System.Windows.Forms.TextBox();
            this.labKVK = new System.Windows.Forms.Label();
            this.tbKvkNumber = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.tbCompanyEmail = new System.Windows.Forms.TextBox();
            this.labCompanyAdress = new System.Windows.Forms.Label();
            this.tbCompanyAdress = new System.Windows.Forms.TextBox();
            this.labComapnyName = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.gbDepartmentInfo = new System.Windows.Forms.GroupBox();
            this.cbHeadDepartments = new System.Windows.Forms.ComboBox();
            this.labHeadDepartment = new System.Windows.Forms.Label();
            this.labDepartmentName = new System.Windows.Forms.Label();
            this.tbDepartmentName = new System.Windows.Forms.TextBox();
            this.btnEditDepratment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Departments.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Company.SuspendLayout();
            this.gbCompanyInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.gbDepartmentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Departments
            // 
            this.Departments.Controls.Add(this.tabPage2);
            this.Departments.Controls.Add(this.Company);
            this.Departments.Controls.Add(this.tabPage1);
            this.Departments.Location = new System.Drawing.Point(12, 24);
            this.Departments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Departments.Name = "Departments";
            this.Departments.SelectedIndex = 0;
            this.Departments.Size = new System.Drawing.Size(1130, 522);
            this.Departments.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1122, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee overview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRemoveEmployee);
            this.groupBox4.Controls.Add(this.tbxEmployeeID);
            this.groupBox4.Controls.Add(this.btnReadEmployee);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.btnUpdateEmployee);
            this.groupBox4.Controls.Add(this.btnCreateEmployee);
            this.groupBox4.Location = new System.Drawing.Point(863, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(244, 490);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Employees";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(34, 180);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnRemoveEmployee.TabIndex = 7;
            this.btnRemoveEmployee.Text = "Delete Employees";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Location = new System.Drawing.Point(34, 50);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(168, 23);
            this.tbxEmployeeID.TabIndex = 9;
            // 
            // btnReadEmployee
            // 
            this.btnReadEmployee.Location = new System.Drawing.Point(34, 110);
            this.btnReadEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadEmployee.Name = "btnReadEmployee";
            this.btnReadEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnReadEmployee.TabIndex = 5;
            this.btnReadEmployee.Text = "Read Employees";
            this.btnReadEmployee.UseVisualStyleBackColor = true;
            this.btnReadEmployee.Click += new System.EventHandler(this.btnReadEmployee_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(34, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 15);
            this.label25.TabIndex = 8;
            this.label25.Text = "Selected Employee ID:";
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(34, 145);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnUpdateEmployee.TabIndex = 6;
            this.btnUpdateEmployee.Text = "Update Employees";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(34, 74);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(168, 31);
            this.btnCreateEmployee.TabIndex = 1;
            this.btnCreateEmployee.Text = "Create New Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxEmployees);
            this.groupBox1.Controls.Add(this.rbnOfficeEmployees);
            this.groupBox1.Controls.Add(this.rbnAllEmployees);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(852, 491);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Employees";
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 15;
            this.lbxEmployees.Location = new System.Drawing.Point(17, 58);
            this.lbxEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(809, 424);
            this.lbxEmployees.TabIndex = 4;
            this.lbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lbxEmployees_SelectedIndexChanged);
            // 
            // rbnOfficeEmployees
            // 
            this.rbnOfficeEmployees.AutoSize = true;
            this.rbnOfficeEmployees.Checked = true;
            this.rbnOfficeEmployees.Location = new System.Drawing.Point(145, 26);
            this.rbnOfficeEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnOfficeEmployees.Name = "rbnOfficeEmployees";
            this.rbnOfficeEmployees.Size = new System.Drawing.Size(117, 19);
            this.rbnOfficeEmployees.TabIndex = 2;
            this.rbnOfficeEmployees.TabStop = true;
            this.rbnOfficeEmployees.Text = "Office employees";
            this.rbnOfficeEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnAllEmployees
            // 
            this.rbnAllEmployees.AutoSize = true;
            this.rbnAllEmployees.Location = new System.Drawing.Point(17, 26);
            this.rbnAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnAllEmployees.Name = "rbnAllEmployees";
            this.rbnAllEmployees.Size = new System.Drawing.Size(99, 19);
            this.rbnAllEmployees.TabIndex = 0;
            this.rbnAllEmployees.Text = "All employees";
            this.rbnAllEmployees.UseVisualStyleBackColor = true;
            // 
            // Company
            // 
            this.Company.Controls.Add(this.gbCompanyInfo);
            this.Company.Controls.Add(this.btnSaveChanges);
            this.Company.Location = new System.Drawing.Point(4, 24);
            this.Company.Name = "Company";
            this.Company.Padding = new System.Windows.Forms.Padding(3);
            this.Company.Size = new System.Drawing.Size(1122, 494);
            this.Company.TabIndex = 2;
            this.Company.Text = "Company";
            this.Company.UseVisualStyleBackColor = true;
            // 
            // gbCompanyInfo
            // 
            this.gbCompanyInfo.Controls.Add(this.label1);
            this.gbCompanyInfo.Controls.Add(this.tbCompanyPhoneNumber);
            this.gbCompanyInfo.Controls.Add(this.labBTW);
            this.gbCompanyInfo.Controls.Add(this.tbBTW);
            this.gbCompanyInfo.Controls.Add(this.labKVK);
            this.gbCompanyInfo.Controls.Add(this.tbKvkNumber);
            this.gbCompanyInfo.Controls.Add(this.labEmail);
            this.gbCompanyInfo.Controls.Add(this.tbCompanyEmail);
            this.gbCompanyInfo.Controls.Add(this.labCompanyAdress);
            this.gbCompanyInfo.Controls.Add(this.tbCompanyAdress);
            this.gbCompanyInfo.Controls.Add(this.labComapnyName);
            this.gbCompanyInfo.Controls.Add(this.tbCompanyName);
            this.gbCompanyInfo.Location = new System.Drawing.Point(33, 28);
            this.gbCompanyInfo.Name = "gbCompanyInfo";
            this.gbCompanyInfo.Size = new System.Drawing.Size(516, 424);
            this.gbCompanyInfo.TabIndex = 13;
            this.gbCompanyInfo.TabStop = false;
            this.gbCompanyInfo.Text = "CompanyInfo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone Number:";
            // 
            // tbCompanyPhoneNumber
            // 
            this.tbCompanyPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCompanyPhoneNumber.Location = new System.Drawing.Point(189, 232);
            this.tbCompanyPhoneNumber.Name = "tbCompanyPhoneNumber";
            this.tbCompanyPhoneNumber.Size = new System.Drawing.Size(290, 33);
            this.tbCompanyPhoneNumber.TabIndex = 11;
            // 
            // labBTW
            // 
            this.labBTW.AutoSize = true;
            this.labBTW.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labBTW.Location = new System.Drawing.Point(121, 355);
            this.labBTW.Name = "labBTW";
            this.labBTW.Size = new System.Drawing.Size(54, 25);
            this.labBTW.TabIndex = 10;
            this.labBTW.Text = "BTW:";
            // 
            // tbBTW
            // 
            this.tbBTW.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBTW.Location = new System.Drawing.Point(189, 352);
            this.tbBTW.Name = "tbBTW";
            this.tbBTW.Size = new System.Drawing.Size(290, 33);
            this.tbBTW.TabIndex = 9;
            // 
            // labKVK
            // 
            this.labKVK.AutoSize = true;
            this.labKVK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labKVK.Location = new System.Drawing.Point(133, 294);
            this.labKVK.Name = "labKVK";
            this.labKVK.Size = new System.Drawing.Size(50, 25);
            this.labKVK.TabIndex = 8;
            this.labKVK.Text = "KVK:";
            // 
            // tbKvkNumber
            // 
            this.tbKvkNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbKvkNumber.Location = new System.Drawing.Point(189, 291);
            this.tbKvkNumber.Name = "tbKvkNumber";
            this.tbKvkNumber.Size = new System.Drawing.Size(290, 33);
            this.tbKvkNumber.TabIndex = 7;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labEmail.Location = new System.Drawing.Point(121, 167);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(62, 25);
            this.labEmail.TabIndex = 6;
            this.labEmail.Text = "Email:";
            // 
            // tbCompanyEmail
            // 
            this.tbCompanyEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCompanyEmail.Location = new System.Drawing.Point(189, 164);
            this.tbCompanyEmail.Name = "tbCompanyEmail";
            this.tbCompanyEmail.Size = new System.Drawing.Size(290, 33);
            this.tbCompanyEmail.TabIndex = 5;
            // 
            // labCompanyAdress
            // 
            this.labCompanyAdress.AutoSize = true;
            this.labCompanyAdress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labCompanyAdress.Location = new System.Drawing.Point(111, 102);
            this.labCompanyAdress.Name = "labCompanyAdress";
            this.labCompanyAdress.Size = new System.Drawing.Size(72, 25);
            this.labCompanyAdress.TabIndex = 4;
            this.labCompanyAdress.Text = "Adress:";
            // 
            // tbCompanyAdress
            // 
            this.tbCompanyAdress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCompanyAdress.Location = new System.Drawing.Point(189, 99);
            this.tbCompanyAdress.Name = "tbCompanyAdress";
            this.tbCompanyAdress.Size = new System.Drawing.Size(290, 33);
            this.tbCompanyAdress.TabIndex = 3;
            // 
            // labComapnyName
            // 
            this.labComapnyName.AutoSize = true;
            this.labComapnyName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labComapnyName.Location = new System.Drawing.Point(32, 39);
            this.labComapnyName.Name = "labComapnyName";
            this.labComapnyName.Size = new System.Drawing.Size(151, 25);
            this.labComapnyName.TabIndex = 1;
            this.labComapnyName.Text = "Company Name:";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCompanyName.Location = new System.Drawing.Point(189, 36);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(290, 33);
            this.tbCompanyName.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveChanges.Location = new System.Drawing.Point(794, 386);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(183, 57);
            this.btnSaveChanges.TabIndex = 2;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDepartments);
            this.tabPage1.Controls.Add(this.gbDepartmentInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1122, 494);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Depatment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(26, 18);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowTemplate.Height = 25;
            this.dgvDepartments.Size = new System.Drawing.Size(303, 453);
            this.dgvDepartments.TabIndex = 1;
            // 
            // gbDepartmentInfo
            // 
            this.gbDepartmentInfo.Controls.Add(this.cbHeadDepartments);
            this.gbDepartmentInfo.Controls.Add(this.labHeadDepartment);
            this.gbDepartmentInfo.Controls.Add(this.labDepartmentName);
            this.gbDepartmentInfo.Controls.Add(this.tbDepartmentName);
            this.gbDepartmentInfo.Controls.Add(this.btnEditDepratment);
            this.gbDepartmentInfo.Controls.Add(this.btnAddDepartment);
            this.gbDepartmentInfo.Location = new System.Drawing.Point(352, 18);
            this.gbDepartmentInfo.Name = "gbDepartmentInfo";
            this.gbDepartmentInfo.Size = new System.Drawing.Size(570, 462);
            this.gbDepartmentInfo.TabIndex = 0;
            this.gbDepartmentInfo.TabStop = false;
            this.gbDepartmentInfo.Text = "Department Info";
            // 
            // cbHeadDepartments
            // 
            this.cbHeadDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHeadDepartments.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHeadDepartments.FormattingEnabled = true;
            this.cbHeadDepartments.Location = new System.Drawing.Point(232, 136);
            this.cbHeadDepartments.Name = "cbHeadDepartments";
            this.cbHeadDepartments.Size = new System.Drawing.Size(264, 33);
            this.cbHeadDepartments.TabIndex = 9;
            // 
            // labHeadDepartment
            // 
            this.labHeadDepartment.AutoSize = true;
            this.labHeadDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labHeadDepartment.Location = new System.Drawing.Point(56, 139);
            this.labHeadDepartment.Name = "labHeadDepartment";
            this.labHeadDepartment.Size = new System.Drawing.Size(160, 25);
            this.labHeadDepartment.TabIndex = 8;
            this.labHeadDepartment.Text = "HeadDepartment:";
            // 
            // labDepartmentName
            // 
            this.labDepartmentName.AutoSize = true;
            this.labDepartmentName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labDepartmentName.Location = new System.Drawing.Point(150, 78);
            this.labDepartmentName.Name = "labDepartmentName";
            this.labDepartmentName.Size = new System.Drawing.Size(66, 25);
            this.labDepartmentName.TabIndex = 6;
            this.labDepartmentName.Text = "Name:";
            // 
            // tbDepartmentName
            // 
            this.tbDepartmentName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDepartmentName.Location = new System.Drawing.Point(232, 75);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(264, 33);
            this.tbDepartmentName.TabIndex = 5;
            // 
            // btnEditDepratment
            // 
            this.btnEditDepratment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditDepratment.Location = new System.Drawing.Point(168, 373);
            this.btnEditDepratment.Name = "btnEditDepratment";
            this.btnEditDepratment.Size = new System.Drawing.Size(241, 40);
            this.btnEditDepratment.TabIndex = 1;
            this.btnEditDepratment.Text = "Edit Department";
            this.btnEditDepratment.UseVisualStyleBackColor = true;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddDepartment.Location = new System.Drawing.Point(168, 313);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(241, 40);
            this.btnAddDepartment.TabIndex = 0;
            this.btnAddDepartment.Text = "Add Department";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1012, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 29);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 549);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Departments);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfficeManager";
            this.Text = "FormOfficeManager";
            this.Departments.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Company.ResumeLayout(false);
            this.gbCompanyInfo.ResumeLayout(false);
            this.gbCompanyInfo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.gbDepartmentInfo.ResumeLayout(false);
            this.gbDepartmentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Departments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.RadioButton rbnOfficeEmployees;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Button btnReadEmployee;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.TabPage Company;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompanyPhoneNumber;
        private System.Windows.Forms.Label labBTW;
        private System.Windows.Forms.TextBox tbBTW;
        private System.Windows.Forms.Label labKVK;
        private System.Windows.Forms.TextBox tbKvkNumber;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox tbCompanyEmail;
        private System.Windows.Forms.Label labCompanyAdress;
        private System.Windows.Forms.TextBox tbCompanyAdress;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label labComapnyName;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TabControl Depart;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView s;
        private System.Windows.Forms.GroupBox gbDepartmentInfo;
        private System.Windows.Forms.Button btnEditDepratment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.GroupBox gbCompanyInfo;
        private System.Windows.Forms.Label labHeadDepartment;
        private System.Windows.Forms.Label labDepartmentName;
        private System.Windows.Forms.TextBox tbDepartmentName;
        private System.Windows.Forms.ComboBox cbHeadDepartments;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvDepartments;
    }
}
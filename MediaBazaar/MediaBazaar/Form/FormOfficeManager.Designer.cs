
namespace MediaBazaar
{
    partial class FormOfficeManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbScheduleEvening = new System.Windows.Forms.TextBox();
            this.lbScheduleAfternoon = new System.Windows.Forms.TextBox();
            this.lbScheduleMorning = new System.Windows.Forms.TextBox();
            this.lbScheduleDay = new System.Windows.Forms.TextBox();
            this.lbScheduleDepartment = new System.Windows.Forms.TextBox();
            this.lbScheduleID = new System.Windows.Forms.TextBox();
            this.btnEditschedule = new System.Windows.Forms.Button();
            this.btViewSchedule = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSchedule = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.label31 = new System.Windows.Forms.Label();
            this.lbPlaning = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbWorkId = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnEditPlaning = new System.Windows.Forms.Button();
            this.btnOfficePlan = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbDep = new System.Windows.Forms.TextBox();
            this.tbNewEmployeeId = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpSchedule);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(11, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1123, 498);
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
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(this.groupBox2);
            this.tpSchedule.Controls.Add(this.lbSchedule);
            this.tpSchedule.Location = new System.Drawing.Point(4, 24);
            this.tpSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSchedule.Size = new System.Drawing.Size(1123, 498);
            this.tpSchedule.TabIndex = 10;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbScheduleEvening);
            this.groupBox2.Controls.Add(this.lbScheduleAfternoon);
            this.groupBox2.Controls.Add(this.lbScheduleMorning);
            this.groupBox2.Controls.Add(this.lbScheduleDay);
            this.groupBox2.Controls.Add(this.lbScheduleDepartment);
            this.groupBox2.Controls.Add(this.lbScheduleID);
            this.groupBox2.Controls.Add(this.btnEditschedule);
            this.groupBox2.Controls.Add(this.btViewSchedule);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(768, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 414);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbScheduleEvening
            // 
            this.lbScheduleEvening.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleEvening.Location = new System.Drawing.Point(153, 228);
            this.lbScheduleEvening.Name = "lbScheduleEvening";
            this.lbScheduleEvening.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleEvening.TabIndex = 20;
            // 
            // lbScheduleAfternoon
            // 
            this.lbScheduleAfternoon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleAfternoon.Location = new System.Drawing.Point(153, 190);
            this.lbScheduleAfternoon.Name = "lbScheduleAfternoon";
            this.lbScheduleAfternoon.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleAfternoon.TabIndex = 19;
            // 
            // lbScheduleMorning
            // 
            this.lbScheduleMorning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleMorning.Location = new System.Drawing.Point(153, 151);
            this.lbScheduleMorning.Name = "lbScheduleMorning";
            this.lbScheduleMorning.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleMorning.TabIndex = 18;
            // 
            // lbScheduleDay
            // 
            this.lbScheduleDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDay.Location = new System.Drawing.Point(153, 112);
            this.lbScheduleDay.Name = "lbScheduleDay";
            this.lbScheduleDay.ReadOnly = true;
            this.lbScheduleDay.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleDay.TabIndex = 17;
            // 
            // lbScheduleDepartment
            // 
            this.lbScheduleDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleDepartment.Location = new System.Drawing.Point(153, 74);
            this.lbScheduleDepartment.Name = "lbScheduleDepartment";
            this.lbScheduleDepartment.ReadOnly = true;
            this.lbScheduleDepartment.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleDepartment.TabIndex = 16;
            // 
            // lbScheduleID
            // 
            this.lbScheduleID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScheduleID.Location = new System.Drawing.Point(153, 35);
            this.lbScheduleID.Name = "lbScheduleID";
            this.lbScheduleID.ReadOnly = true;
            this.lbScheduleID.Size = new System.Drawing.Size(164, 29);
            this.lbScheduleID.TabIndex = 15;
            // 
            // btnEditschedule
            // 
            this.btnEditschedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditschedule.Location = new System.Drawing.Point(79, 353);
            this.btnEditschedule.Name = "btnEditschedule";
            this.btnEditschedule.Size = new System.Drawing.Size(215, 34);
            this.btnEditschedule.TabIndex = 14;
            this.btnEditschedule.Text = "Edit schedule";
            this.btnEditschedule.UseVisualStyleBackColor = true;
            this.btnEditschedule.Click += new System.EventHandler(this.btnEditschedule_Click);
            // 
            // btViewSchedule
            // 
            this.btViewSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btViewSchedule.Location = new System.Drawing.Point(79, 301);
            this.btViewSchedule.Name = "btViewSchedule";
            this.btViewSchedule.Size = new System.Drawing.Size(215, 34);
            this.btViewSchedule.TabIndex = 13;
            this.btViewSchedule.Text = "View schedule";
            this.btViewSchedule.UseVisualStyleBackColor = true;
            this.btViewSchedule.Click += new System.EventHandler(this.btViewSchedule_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(79, 231);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 21);
            this.label24.TabIndex = 12;
            this.label24.Text = "Evening:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Afternoon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(77, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Monday:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(107, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Day:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(51, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Department:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(54, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Schedule id:";
            // 
            // lbSchedule
            // 
            this.lbSchedule.FormattingEnabled = true;
            this.lbSchedule.ItemHeight = 15;
            this.lbSchedule.Location = new System.Drawing.Point(24, 40);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(668, 409);
            this.lbSchedule.TabIndex = 0;
            this.lbSchedule.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.lbEmployee);
            this.tabPage7.Controls.Add(this.label31);
            this.tabPage7.Controls.Add(this.lbPlaning);
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1123, 498);
            this.tabPage7.TabIndex = 11;
            this.tabPage7.Text = "Planing";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // lbEmployee
            // 
            this.lbEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmployee.FormattingEnabled = true;
            this.lbEmployee.ItemHeight = 15;
            this.lbEmployee.Location = new System.Drawing.Point(373, 60);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(347, 424);
            this.lbEmployee.TabIndex = 62;
            this.lbEmployee.SelectedIndexChanged += new System.EventHandler(this.lbEmployee_SelectedIndexChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(31, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 21);
            this.label31.TabIndex = 61;
            this.label31.Text = "Planing list:";
            // 
            // lbPlaning
            // 
            this.lbPlaning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPlaning.FormattingEnabled = true;
            this.lbPlaning.ItemHeight = 15;
            this.lbPlaning.Location = new System.Drawing.Point(25, 60);
            this.lbPlaning.Name = "lbPlaning";
            this.lbPlaning.Size = new System.Drawing.Size(342, 424);
            this.lbPlaning.TabIndex = 60;
            this.lbPlaning.SelectedIndexChanged += new System.EventHandler(this.lbPlaning_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbWorkId);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.btnEditPlaning);
            this.groupBox3.Controls.Add(this.btnOfficePlan);
            this.groupBox3.Controls.Add(this.tbTime);
            this.groupBox3.Controls.Add(this.tbDay);
            this.groupBox3.Controls.Add(this.tbDep);
            this.groupBox3.Controls.Add(this.tbNewEmployeeId);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Location = new System.Drawing.Point(743, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 442);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // tbWorkId
            // 
            this.tbWorkId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWorkId.Location = new System.Drawing.Point(153, 45);
            this.tbWorkId.Name = "tbWorkId";
            this.tbWorkId.ReadOnly = true;
            this.tbWorkId.Size = new System.Drawing.Size(164, 29);
            this.tbWorkId.TabIndex = 25;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(45, 45);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 21);
            this.label34.TabIndex = 24;
            this.label34.Text = "Work id:";
            // 
            // btnEditPlaning
            // 
            this.btnEditPlaning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditPlaning.Location = new System.Drawing.Point(69, 276);
            this.btnEditPlaning.Name = "btnEditPlaning";
            this.btnEditPlaning.Size = new System.Drawing.Size(215, 34);
            this.btnEditPlaning.TabIndex = 23;
            this.btnEditPlaning.Text = "EditPlaning";
            this.btnEditPlaning.UseVisualStyleBackColor = true;
            this.btnEditPlaning.Click += new System.EventHandler(this.btnEditPlanning_Click);
            // 
            // btnOfficePlan
            // 
            this.btnOfficePlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOfficePlan.Location = new System.Drawing.Point(69, 340);
            this.btnOfficePlan.Name = "btnOfficePlan";
            this.btnOfficePlan.Size = new System.Drawing.Size(215, 34);
            this.btnOfficePlan.TabIndex = 22;
            this.btnOfficePlan.Text = "View office planing";
            this.btnOfficePlan.UseVisualStyleBackColor = true;
            this.btnOfficePlan.Click += new System.EventHandler(this.btnOfficePlan_Click);
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTime.Location = new System.Drawing.Point(153, 196);
            this.tbTime.Name = "tbTime";
            this.tbTime.ReadOnly = true;
            this.tbTime.Size = new System.Drawing.Size(164, 29);
            this.tbTime.TabIndex = 18;
            // 
            // tbDay
            // 
            this.tbDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDay.Location = new System.Drawing.Point(153, 157);
            this.tbDay.Name = "tbDay";
            this.tbDay.ReadOnly = true;
            this.tbDay.Size = new System.Drawing.Size(164, 29);
            this.tbDay.TabIndex = 17;
            // 
            // tbDep
            // 
            this.tbDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDep.Location = new System.Drawing.Point(153, 119);
            this.tbDep.Name = "tbDep";
            this.tbDep.ReadOnly = true;
            this.tbDep.Size = new System.Drawing.Size(164, 29);
            this.tbDep.TabIndex = 16;
            // 
            // tbNewEmployeeId
            // 
            this.tbNewEmployeeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNewEmployeeId.Location = new System.Drawing.Point(153, 80);
            this.tbNewEmployeeId.Name = "tbNewEmployeeId";
            this.tbNewEmployeeId.ReadOnly = true;
            this.tbNewEmployeeId.Size = new System.Drawing.Size(164, 29);
            this.tbNewEmployeeId.TabIndex = 15;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(93, 199);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(45, 21);
            this.label32.TabIndex = 10;
            this.label32.Text = "Shift:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(98, 157);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(40, 21);
            this.label33.TabIndex = 9;
            this.label33.Text = "Day:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label38.Location = new System.Drawing.Point(42, 119);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(96, 21);
            this.label38.TabIndex = 8;
            this.label38.Text = "Department:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label39.Location = new System.Drawing.Point(45, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(98, 21);
            this.label39.TabIndex = 7;
            this.label39.Text = "Employee id:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(732, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 22);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(862, 4);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(79, 28);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Check In";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FormOfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 549);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOfficeManager";
            this.Text = "FormOfficeManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpSchedule.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.RadioButton rbnOfficeEmployees;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditschedule;
        private System.Windows.Forms.Button btViewSchedule;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbSchedule;
        private System.Windows.Forms.TextBox lbScheduleEvening;
        private System.Windows.Forms.TextBox lbScheduleAfternoon;
        private System.Windows.Forms.TextBox lbScheduleMorning;
        private System.Windows.Forms.TextBox lbScheduleDay;
        private System.Windows.Forms.TextBox lbScheduleDepartment;
        private System.Windows.Forms.TextBox lbScheduleID;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListBox lbEmployee;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ListBox lbPlaning;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbWorkId;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnEditPlaning;
        private System.Windows.Forms.Button btnOfficePlan;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbDep;
        private System.Windows.Forms.TextBox tbNewEmployeeId;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Button btnReadEmployee;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnCheck;
    }
}
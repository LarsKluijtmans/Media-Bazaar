
namespace MediaBazaar
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.gbMakeEmployee = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxJobTitle = new System.Windows.Forms.TextBox();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.tbxStartDate = new System.Windows.Forms.TextBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxWorkHours = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnNewEmployee = new System.Windows.Forms.Button();
            this.tbxBSN = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxDateOfBirth = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.gbMakeEmployee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(36, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 538);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.gbMakeEmployee);
            this.tabEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabEmployee.Location = new System.Drawing.Point(4, 26);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1117, 508);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employees";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // gbMakeEmployee
            // 
            this.gbMakeEmployee.Controls.Add(this.groupBox2);
            this.gbMakeEmployee.Controls.Add(this.groupBox1);
            this.gbMakeEmployee.Controls.Add(this.label1);
            this.gbMakeEmployee.Location = new System.Drawing.Point(7, 8);
            this.gbMakeEmployee.Name = "gbMakeEmployee";
            this.gbMakeEmployee.Size = new System.Drawing.Size(1100, 489);
            this.gbMakeEmployee.TabIndex = 84;
            this.gbMakeEmployee.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxJobTitle);
            this.groupBox2.Controls.Add(this.btnAddContract);
            this.groupBox2.Controls.Add(this.tbxStartDate);
            this.groupBox2.Controls.Add(this.tbxSalary);
            this.groupBox2.Controls.Add(this.tbxWorkHours);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(741, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(350, 421);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract Info:";
            // 
            // cbxJobTitle
            // 
            this.cbxJobTitle.Location = new System.Drawing.Point(140, 59);
            this.cbxJobTitle.Name = "cbxJobTitle";
            this.cbxJobTitle.ReadOnly = true;
            this.cbxJobTitle.Size = new System.Drawing.Size(191, 35);
            this.cbxJobTitle.TabIndex = 85;
            this.cbxJobTitle.Text = "OFFICE MANAGER";
            // 
            // btnAddContract
            // 
            this.btnAddContract.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddContract.Location = new System.Drawing.Point(63, 337);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(230, 62);
            this.btnAddContract.TabIndex = 84;
            this.btnAddContract.Text = "Add Contract";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // tbxStartDate
            // 
            this.tbxStartDate.Location = new System.Drawing.Point(140, 262);
            this.tbxStartDate.Name = "tbxStartDate";
            this.tbxStartDate.Size = new System.Drawing.Size(191, 35);
            this.tbxStartDate.TabIndex = 25;
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(140, 190);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(191, 35);
            this.tbxSalary.TabIndex = 24;
            // 
            // tbxWorkHours
            // 
            this.tbxWorkHours.Location = new System.Drawing.Point(140, 122);
            this.tbxWorkHours.Name = "tbxWorkHours";
            this.tbxWorkHours.Size = new System.Drawing.Size(191, 35);
            this.tbxWorkHours.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 30);
            this.label11.TabIndex = 18;
            this.label11.Text = "Job Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "Work hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salary:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.BtnNewEmployee);
            this.groupBox1.Controls.Add(this.tbxBSN);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.tbxDateOfBirth);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbxEmail);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxEmployeeID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbxFirstName);
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.tbxLastName);
            this.groupBox1.Controls.Add(this.tbxUsername);
            this.groupBox1.Controls.Add(this.tbxCity);
            this.groupBox1.Controls.Add(this.tbxPhoneNumber);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(719, 421);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 30);
            this.label20.TabIndex = 54;
            this.label20.Text = "Employee ID:";
            // 
            // BtnNewEmployee
            // 
            this.BtnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNewEmployee.Location = new System.Drawing.Point(62, 337);
            this.BtnNewEmployee.Name = "BtnNewEmployee";
            this.BtnNewEmployee.Size = new System.Drawing.Size(317, 62);
            this.BtnNewEmployee.TabIndex = 81;
            this.BtnNewEmployee.Text = "Add Empolyee";
            this.BtnNewEmployee.UseVisualStyleBackColor = true;
            this.BtnNewEmployee.Click += new System.EventHandler(this.BtnNewEmployee_Click);
            // 
            // tbxBSN
            // 
            this.tbxBSN.Location = new System.Drawing.Point(524, 96);
            this.tbxBSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxBSN.Name = "tbxBSN";
            this.tbxBSN.Size = new System.Drawing.Size(175, 35);
            this.tbxBSN.TabIndex = 77;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(51, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 30);
            this.label19.TabIndex = 55;
            this.label19.Text = "First name:";
            // 
            // tbxDateOfBirth
            // 
            this.tbxDateOfBirth.Location = new System.Drawing.Point(524, 44);
            this.tbxDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDateOfBirth.Name = "tbxDateOfBirth";
            this.tbxDateOfBirth.Size = new System.Drawing.Size(175, 35);
            this.tbxDateOfBirth.TabIndex = 76;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 30);
            this.label18.TabIndex = 56;
            this.label18.Text = "Last name:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(171, 264);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(191, 35);
            this.tbxEmail.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 30);
            this.label12.TabIndex = 74;
            this.label12.Text = "Email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 30);
            this.label16.TabIndex = 58;
            this.label16.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 73;
            this.label5.Text = "BSN:";
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Location = new System.Drawing.Point(172, 47);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(190, 35);
            this.tbxEmployeeID.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 72;
            this.label8.Text = "Date of Birth:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(171, 96);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(191, 35);
            this.tbxFirstName.TabIndex = 60;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(524, 262);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.ReadOnly = true;
            this.tbxPassword.Size = new System.Drawing.Size(175, 35);
            this.tbxPassword.TabIndex = 71;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(171, 155);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(191, 35);
            this.tbxLastName.TabIndex = 61;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(524, 207);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ReadOnly = true;
            this.tbxUsername.Size = new System.Drawing.Size(175, 35);
            this.tbxUsername.TabIndex = 70;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(524, 155);
            this.tbxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(175, 35);
            this.tbxCity.TabIndex = 69;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(171, 207);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhoneNumber.Multiline = true;
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(191, 35);
            this.tbxPhoneNumber.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 30);
            this.label13.TabIndex = 67;
            this.label13.Text = "Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(465, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 30);
            this.label15.TabIndex = 65;
            this.label15.Text = "City:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 30);
            this.label14.TabIndex = 66;
            this.label14.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please add the first employee, this employee will be a office manager so he/she c" +
    "an add all other employees in the future ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1117, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Backups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(527, 37);
            this.label7.TabIndex = 1;
            this.label7.Text = "It is advised to make at least daily backups!";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(291, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(467, 157);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make backup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edit.Location = new System.Drawing.Point(65, 320);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(215, 34);
            this.Edit.TabIndex = 21;
            this.Edit.Text = "View sales planing";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(65, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 34);
            this.button5.TabIndex = 24;
            this.button5.Text = "View sales planing";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(65, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(215, 34);
            this.button6.TabIndex = 23;
            this.button6.Text = "View depot planing";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(1004, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 582);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.gbMakeEmployee.ResumeLayout(false);
            this.gbMakeEmployee.PerformLayout();
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
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.Button btnOffi;
        private System.Windows.Forms.Button btnViewAllSalesPlani;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAllPlani;
        private System.Windows.Forms.Button ng;
        private System.Windows.Forms.TextBox lbNewEmployeeId;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox lbWorkId;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cbxJobTitle;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.TextBox tbxStartDate;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.TextBox tbxWorkHours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BtnNewEmployee;
        private System.Windows.Forms.TextBox tbxBSN;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxDateOfBirth;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbMakeEmployee;
    }
}


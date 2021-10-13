
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
            this.Comapny = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.btnReadEmployee = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnSalesEmployees = new System.Windows.Forms.RadioButton();
            this.rbnDepotEmployees = new System.Windows.Forms.RadioButton();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.rbnOfficeEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCompanyInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Comapny.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbCompanyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Comapny
            // 
            this.Comapny.Controls.Add(this.tabPage2);
            this.Comapny.Controls.Add(this.tabPage1);
            this.Comapny.Controls.Add(this.tabPage3);
            this.Comapny.Location = new System.Drawing.Point(11, 20);
            this.Comapny.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Comapny.Name = "Comapny";
            this.Comapny.SelectedIndex = 0;
            this.Comapny.Size = new System.Drawing.Size(1131, 526);
            this.Comapny.TabIndex = 0;
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
            this.btnCreateEmployee.Text = "Add New Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnSalesEmployees);
            this.groupBox1.Controls.Add(this.rbnDepotEmployees);
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
            // rbnSalesEmployees
            // 
            this.rbnSalesEmployees.AutoSize = true;
            this.rbnSalesEmployees.Location = new System.Drawing.Point(368, 26);
            this.rbnSalesEmployees.Name = "rbnSalesEmployees";
            this.rbnSalesEmployees.Size = new System.Drawing.Size(111, 19);
            this.rbnSalesEmployees.TabIndex = 6;
            this.rbnSalesEmployees.Text = "Sales Employees";
            this.rbnSalesEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnDepotEmployees
            // 
            this.rbnDepotEmployees.AutoSize = true;
            this.rbnDepotEmployees.Location = new System.Drawing.Point(245, 26);
            this.rbnDepotEmployees.Name = "rbnDepotEmployees";
            this.rbnDepotEmployees.Size = new System.Drawing.Size(117, 19);
            this.rbnDepotEmployees.TabIndex = 5;
            this.rbnDepotEmployees.Text = "Depot Employees";
            this.rbnDepotEmployees.UseVisualStyleBackColor = true;
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
            this.rbnOfficeEmployees.Location = new System.Drawing.Point(122, 26);
            this.rbnOfficeEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnOfficeEmployees.Name = "rbnOfficeEmployees";
            this.rbnOfficeEmployees.Size = new System.Drawing.Size(117, 19);
            this.rbnOfficeEmployees.TabIndex = 2;
            this.rbnOfficeEmployees.Text = "Office employees";
            this.rbnOfficeEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnAllEmployees
            // 
            this.rbnAllEmployees.AutoSize = true;
            this.rbnAllEmployees.Checked = true;
            this.rbnAllEmployees.Location = new System.Drawing.Point(17, 26);
            this.rbnAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnAllEmployees.Name = "rbnAllEmployees";
            this.rbnAllEmployees.Size = new System.Drawing.Size(99, 19);
            this.rbnAllEmployees.TabIndex = 0;
            this.rbnAllEmployees.TabStop = true;
            this.rbnAllEmployees.Text = "All employees";
            this.rbnAllEmployees.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(971, 6);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 28);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(1059, 6);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(79, 28);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "Check In";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbCompanyInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 498);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Company";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1123, 498);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Deprtments";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCompanyName.Location = new System.Drawing.Point(254, 62);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(326, 33);
            this.tbCompanyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name:";
            // 
            // gbCompanyInfo
            // 
            this.gbCompanyInfo.Controls.Add(this.label3);
            this.gbCompanyInfo.Controls.Add(this.textBox2);
            this.gbCompanyInfo.Controls.Add(this.label2);
            this.gbCompanyInfo.Controls.Add(this.textBox1);
            this.gbCompanyInfo.Controls.Add(this.label1);
            this.gbCompanyInfo.Controls.Add(this.tbCompanyName);
            this.gbCompanyInfo.Location = new System.Drawing.Point(23, 19);
            this.gbCompanyInfo.Name = "gbCompanyInfo";
            this.gbCompanyInfo.Size = new System.Drawing.Size(629, 451);
            this.gbCompanyInfo.TabIndex = 2;
            this.gbCompanyInfo.TabStop = false;
            this.gbCompanyInfo.Text = "Company info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company Name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(254, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 33);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(82, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(254, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 33);
            this.textBox2.TabIndex = 4;
            // 
            // OfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 549);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Comapny);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfficeManager";
            this.Text = "FormOfficeManager";
            this.Comapny.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.gbCompanyInfo.ResumeLayout(false);
            this.gbCompanyInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Comapny;
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
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton rbnSalesEmployees;
        private System.Windows.Forms.RadioButton rbnDepotEmployees;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbCompanyInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
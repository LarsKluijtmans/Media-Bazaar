
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.rbnDepotEmployees = new System.Windows.Forms.RadioButton();
            this.rbnSalesEmployees = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
            // OfficeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 549);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfficeManager";
            this.Text = "FormOfficeManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}
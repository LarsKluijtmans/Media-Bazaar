
namespace MediaBazaar
{
    partial class FormDepotManager
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreateNewEmployee = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxEmployees = new System.Windows.Forms.ListBox();
            this.rbnOfficeEmployees = new System.Windows.Forms.RadioButton();
            this.rbnDepotEmployees = new System.Windows.Forms.RadioButton();
            this.rbnSalesEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCreateNewEmployee);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee overview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewEmployee
            // 
            this.btnCreateNewEmployee.Location = new System.Drawing.Point(702, 25);
            this.btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            this.btnCreateNewEmployee.Size = new System.Drawing.Size(192, 41);
            this.btnCreateNewEmployee.TabIndex = 1;
            this.btnCreateNewEmployee.Text = "Create New Employee";
            this.btnCreateNewEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxEmployees);
            this.groupBox1.Controls.Add(this.rbnOfficeEmployees);
            this.groupBox1.Controls.Add(this.rbnDepotEmployees);
            this.groupBox1.Controls.Add(this.rbnSalesEmployees);
            this.groupBox1.Controls.Add(this.rbnAllEmployees);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Employees";
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 20;
            this.lbxEmployees.Location = new System.Drawing.Point(19, 98);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(543, 344);
            this.lbxEmployees.TabIndex = 4;
            // 
            // rbnOfficeEmployees
            // 
            this.rbnOfficeEmployees.AutoSize = true;
            this.rbnOfficeEmployees.Location = new System.Drawing.Point(165, 67);
            this.rbnOfficeEmployees.Name = "rbnOfficeEmployees";
            this.rbnOfficeEmployees.Size = new System.Drawing.Size(146, 24);
            this.rbnOfficeEmployees.TabIndex = 3;
            this.rbnOfficeEmployees.Text = "Office employees";
            this.rbnOfficeEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnDepotEmployees
            // 
            this.rbnDepotEmployees.AutoSize = true;
            this.rbnDepotEmployees.Checked = true;
            this.rbnDepotEmployees.Location = new System.Drawing.Point(165, 37);
            this.rbnDepotEmployees.Name = "rbnDepotEmployees";
            this.rbnDepotEmployees.Size = new System.Drawing.Size(148, 24);
            this.rbnDepotEmployees.TabIndex = 2;
            this.rbnDepotEmployees.TabStop = true;
            this.rbnDepotEmployees.Text = "Depot employees";
            this.rbnDepotEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnSalesEmployees
            // 
            this.rbnSalesEmployees.AutoSize = true;
            this.rbnSalesEmployees.Location = new System.Drawing.Point(19, 67);
            this.rbnSalesEmployees.Name = "rbnSalesEmployees";
            this.rbnSalesEmployees.Size = new System.Drawing.Size(140, 24);
            this.rbnSalesEmployees.TabIndex = 1;
            this.rbnSalesEmployees.Text = "Sales employees";
            this.rbnSalesEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnAllEmployees
            // 
            this.rbnAllEmployees.AutoSize = true;
            this.rbnAllEmployees.Location = new System.Drawing.Point(19, 36);
            this.rbnAllEmployees.Name = "rbnAllEmployees";
            this.rbnAllEmployees.Size = new System.Drawing.Size(124, 24);
            this.rbnAllEmployees.TabIndex = 0;
            this.rbnAllEmployees.Text = "All employees";
            this.rbnAllEmployees.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(833, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // FormDepotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 541);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDepotManager";
            this.Text = "FormDepotManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateNewEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxEmployees;
        private System.Windows.Forms.RadioButton rbnOfficeEmployees;
        private System.Windows.Forms.RadioButton rbnDepotEmployees;
        private System.Windows.Forms.RadioButton rbnSalesEmployees;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
    }
}
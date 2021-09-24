
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
            this.rbnDepotEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReadEmployees = new System.Windows.Forms.Button();
            this.btnUpdateEmployees = new System.Windows.Forms.Button();
            this.btnDeleteEmployees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
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
            this.btnCreateNewEmployee.Location = new System.Drawing.Point(597, 155);
            this.btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            this.btnCreateNewEmployee.Size = new System.Drawing.Size(192, 41);
            this.btnCreateNewEmployee.TabIndex = 1;
            this.btnCreateNewEmployee.Text = "Create New Employee";
            this.btnCreateNewEmployee.UseVisualStyleBackColor = true;
            //this.btnCreateNewEmployee.Click += new System.EventHandler(this.btnCreateNewEmployee_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxEmployeeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeleteEmployees);
            this.groupBox1.Controls.Add(this.btnUpdateEmployees);
            this.groupBox1.Controls.Add(this.btnReadEmployees);
            this.groupBox1.Controls.Add(this.btnCreateNewEmployee);
            this.groupBox1.Controls.Add(this.lbxEmployees);
            this.groupBox1.Controls.Add(this.rbnDepotEmployees);
            this.groupBox1.Controls.Add(this.rbnAllEmployees);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Employees";
            // 
            // lbxEmployees
            // 
            this.lbxEmployees.FormattingEnabled = true;
            this.lbxEmployees.ItemHeight = 20;
            this.lbxEmployees.Location = new System.Drawing.Point(19, 78);
            this.lbxEmployees.Name = "lbxEmployees";
            this.lbxEmployees.Size = new System.Drawing.Size(543, 364);
            this.lbxEmployees.TabIndex = 4;
            //this.lbxEmployees.SelectedIndexChanged += new System.EventHandler(this.lbxEmployees_SelectedIndexChanged);
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
            // btnReadEmployees
            // 
            this.btnReadEmployees.Location = new System.Drawing.Point(597, 202);
            this.btnReadEmployees.Name = "btnReadEmployees";
            this.btnReadEmployees.Size = new System.Drawing.Size(192, 41);
            this.btnReadEmployees.TabIndex = 5;
            this.btnReadEmployees.Text = "Read Employees";
            this.btnReadEmployees.UseVisualStyleBackColor = true;
           // this.btnReadEmployees.Click += new System.EventHandler(this.btnReadEmployees_Click);
            // 
            // btnUpdateEmployees
            // 
            this.btnUpdateEmployees.Location = new System.Drawing.Point(597, 249);
            this.btnUpdateEmployees.Name = "btnUpdateEmployees";
            this.btnUpdateEmployees.Size = new System.Drawing.Size(192, 41);
            this.btnUpdateEmployees.TabIndex = 6;
            this.btnUpdateEmployees.Text = "Update Employees";
            this.btnUpdateEmployees.UseVisualStyleBackColor = true;
           // this.btnUpdateEmployees.Click += new System.EventHandler(this.btnUpdateEmployees_Click);
            // 
            // btnDeleteEmployees
            // 
            this.btnDeleteEmployees.Location = new System.Drawing.Point(597, 296);
            this.btnDeleteEmployees.Name = "btnDeleteEmployees";
            this.btnDeleteEmployees.Size = new System.Drawing.Size(192, 41);
            this.btnDeleteEmployees.TabIndex = 7;
            this.btnDeleteEmployees.Text = "Delete Employees";
            this.btnDeleteEmployees.UseVisualStyleBackColor = true;
            //this.btnDeleteEmployees.Click += new System.EventHandler(this.btnDeleteEmployees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selected Employee ID:";
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Location = new System.Drawing.Point(597, 110);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.ReadOnly = true;
            this.tbxEmployeeID.Size = new System.Drawing.Size(192, 27);
            this.tbxEmployeeID.TabIndex = 9;
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
        private System.Windows.Forms.RadioButton rbnDepotEmployees;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteEmployees;
        private System.Windows.Forms.Button btnUpdateEmployees;
        private System.Windows.Forms.Button btnReadEmployees;
    }
}
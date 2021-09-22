
namespace MediaBazaar
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOverviewSchedule = new System.Windows.Forms.ListBox();
            this.lstOverviewComplaint = new System.Windows.Forms.ListBox();
            this.lstOverviewAnnoucement = new System.Windows.Forms.ListBox();
            this.lstOverviewProduct = new System.Windows.Forms.ListBox();
            this.lstOverviewEmployee = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbEvening = new System.Windows.Forms.CheckBox();
            this.cbMorning = new System.Windows.Forms.CheckBox();
            this.cbAfternoon = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lstRequest = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(41, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 717);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lstOverviewSchedule);
            this.tabPage1.Controls.Add(this.lstOverviewComplaint);
            this.tabPage1.Controls.Add(this.lstOverviewAnnoucement);
            this.tabPage1.Controls.Add(this.lstOverviewProduct);
            this.tabPage1.Controls.Add(this.lstOverviewEmployee);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1272, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(277, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Schedule:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(641, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Complaints";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(277, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Announcements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1015, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product List:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee List:";
            // 
            // lstOverviewSchedule
            // 
            this.lstOverviewSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewSchedule.FormattingEnabled = true;
            this.lstOverviewSchedule.ItemHeight = 21;
            this.lstOverviewSchedule.Location = new System.Drawing.Point(277, 291);
            this.lstOverviewSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOverviewSchedule.Name = "lstOverviewSchedule";
            this.lstOverviewSchedule.Size = new System.Drawing.Size(722, 319);
            this.lstOverviewSchedule.TabIndex = 4;
            // 
            // lstOverviewComplaint
            // 
            this.lstOverviewComplaint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewComplaint.FormattingEnabled = true;
            this.lstOverviewComplaint.ItemHeight = 21;
            this.lstOverviewComplaint.Location = new System.Drawing.Point(641, 51);
            this.lstOverviewComplaint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOverviewComplaint.Name = "lstOverviewComplaint";
            this.lstOverviewComplaint.Size = new System.Drawing.Size(357, 151);
            this.lstOverviewComplaint.TabIndex = 3;
            // 
            // lstOverviewAnnoucement
            // 
            this.lstOverviewAnnoucement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewAnnoucement.FormattingEnabled = true;
            this.lstOverviewAnnoucement.ItemHeight = 21;
            this.lstOverviewAnnoucement.Location = new System.Drawing.Point(277, 51);
            this.lstOverviewAnnoucement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOverviewAnnoucement.Name = "lstOverviewAnnoucement";
            this.lstOverviewAnnoucement.Size = new System.Drawing.Size(357, 151);
            this.lstOverviewAnnoucement.TabIndex = 2;
            // 
            // lstOverviewProduct
            // 
            this.lstOverviewProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewProduct.FormattingEnabled = true;
            this.lstOverviewProduct.ItemHeight = 21;
            this.lstOverviewProduct.Location = new System.Drawing.Point(1015, 51);
            this.lstOverviewProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOverviewProduct.Name = "lstOverviewProduct";
            this.lstOverviewProduct.Size = new System.Drawing.Size(249, 571);
            this.lstOverviewProduct.TabIndex = 1;
            // 
            // lstOverviewEmployee
            // 
            this.lstOverviewEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewEmployee.FormattingEnabled = true;
            this.lstOverviewEmployee.ItemHeight = 21;
            this.lstOverviewEmployee.Location = new System.Drawing.Point(7, 51);
            this.lstOverviewEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOverviewEmployee.Name = "lstOverviewEmployee";
            this.lstOverviewEmployee.Size = new System.Drawing.Size(249, 571);
            this.lstOverviewEmployee.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.cbEvening);
            this.tabPage2.Controls.Add(this.cbMorning);
            this.tabPage2.Controls.Add(this.cbAfternoon);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.btnEditEmployee);
            this.tabPage2.Controls.Add(this.btnAddNewEmployee);
            this.tabPage2.Controls.Add(this.btnRemoveEmployee);
            this.tabPage2.Controls.Add(this.lstEmployees);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1272, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.Day,
            this.Time});
            this.dataGridView1.Location = new System.Drawing.Point(675, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(427, 207);
            this.dataGridView1.TabIndex = 10;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            this.Employee.Width = 125;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // cbEvening
            // 
            this.cbEvening.AutoSize = true;
            this.cbEvening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEvening.Location = new System.Drawing.Point(522, 361);
            this.cbEvening.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEvening.Name = "cbEvening";
            this.cbEvening.Size = new System.Drawing.Size(92, 27);
            this.cbEvening.TabIndex = 8;
            this.cbEvening.Text = "Evening";
            this.cbEvening.UseVisualStyleBackColor = true;
            // 
            // cbMorning
            // 
            this.cbMorning.AutoSize = true;
            this.cbMorning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMorning.Location = new System.Drawing.Point(522, 279);
            this.cbMorning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMorning.Name = "cbMorning";
            this.cbMorning.Size = new System.Drawing.Size(97, 27);
            this.cbMorning.TabIndex = 7;
            this.cbMorning.Text = "Morning";
            this.cbMorning.UseVisualStyleBackColor = true;
            // 
            // cbAfternoon
            // 
            this.cbAfternoon.AutoSize = true;
            this.cbAfternoon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAfternoon.Location = new System.Drawing.Point(522, 320);
            this.cbAfternoon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAfternoon.Name = "cbAfternoon";
            this.cbAfternoon.Size = new System.Drawing.Size(109, 27);
            this.cbAfternoon.TabIndex = 6;
            this.cbAfternoon.Text = "Afternoon";
            this.cbAfternoon.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(387, 47);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditEmployee.Location = new System.Drawing.Point(154, 581);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(197, 37);
            this.btnEditEmployee.TabIndex = 4;
            this.btnEditEmployee.Text = "Edit Employee Info";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewEmployee.Location = new System.Drawing.Point(154, 536);
            this.btnAddNewEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(197, 37);
            this.btnAddNewEmployee.TabIndex = 3;
            this.btnAddNewEmployee.Text = "Add New Employee";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEmployee.Location = new System.Drawing.Point(154, 627);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(197, 37);
            this.btnRemoveEmployee.TabIndex = 2;
            this.btnRemoveEmployee.Text = "Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            // 
            // lstEmployees
            // 
            this.lstEmployees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 21;
            this.lstEmployees.Location = new System.Drawing.Point(25, 47);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(325, 466);
            this.lstEmployees.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRemoveProduct);
            this.tabPage3.Controls.Add(this.btnAddProduct);
            this.tabPage3.Controls.Add(this.lstRequest);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.lstProduct);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1272, 683);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveProduct.Location = new System.Drawing.Point(189, 552);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(197, 37);
            this.btnRemoveProduct.TabIndex = 28;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Location = new System.Drawing.Point(189, 501);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(197, 43);
            this.btnAddProduct.TabIndex = 21;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lstRequest
            // 
            this.lstRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstRequest.FormattingEnabled = true;
            this.lstRequest.ItemHeight = 21;
            this.lstRequest.Location = new System.Drawing.Point(408, 57);
            this.lstRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstRequest.Name = "lstRequest";
            this.lstRequest.Size = new System.Drawing.Size(494, 172);
            this.lstRequest.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Replenish Request:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Product List:";
            // 
            // lstProduct
            // 
            this.lstProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 21;
            this.lstProduct.Location = new System.Drawing.Point(29, 57);
            this.lstProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(356, 424);
            this.lstProduct.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 773);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOverviewSchedule;
        private System.Windows.Forms.ListBox lstOverviewComplaint;
        private System.Windows.Forms.ListBox lstOverviewAnnoucement;
        private System.Windows.Forms.ListBox lstOverviewProduct;
        private System.Windows.Forms.ListBox lstOverviewEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.CheckBox cbEvening;
        private System.Windows.Forms.CheckBox cbMorning;
        private System.Windows.Forms.CheckBox cbAfternoon;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstRequest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
    }
}


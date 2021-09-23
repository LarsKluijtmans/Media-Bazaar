
namespace MediaBazaar
{
    partial class FormOfficeEmployee
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstOverviewSchedule = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstOverviewAnnouncement = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSubmitComplaint = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComplaint = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSubmitAnnouncement = new System.Windows.Forms.Button();
            this.txtAnnouncement = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstAnnouncement = new System.Windows.Forms.ListBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(29, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 513);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnProfile);
            this.tabPage1.Controls.Add(this.btnCheck);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lstOverviewSchedule);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lstOverviewAnnouncement);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Location = new System.Drawing.Point(779, 20);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(97, 55);
            this.btnProfile.TabIndex = 21;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(779, 370);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(97, 55);
            this.btnCheck.TabIndex = 20;
            this.btnCheck.Text = "Check In";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Schedule:";
            // 
            // lstOverviewSchedule
            // 
            this.lstOverviewSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewSchedule.FormattingEnabled = true;
            this.lstOverviewSchedule.ItemHeight = 17;
            this.lstOverviewSchedule.Location = new System.Drawing.Point(19, 234);
            this.lstOverviewSchedule.Name = "lstOverviewSchedule";
            this.lstOverviewSchedule.Size = new System.Drawing.Size(658, 191);
            this.lstOverviewSchedule.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Announcements:";
            // 
            // lstOverviewAnnouncement
            // 
            this.lstOverviewAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverviewAnnouncement.FormattingEnabled = true;
            this.lstOverviewAnnouncement.ItemHeight = 17;
            this.lstOverviewAnnouncement.Location = new System.Drawing.Point(19, 44);
            this.lstOverviewAnnouncement.Name = "lstOverviewAnnouncement";
            this.lstOverviewAnnouncement.Size = new System.Drawing.Size(658, 140);
            this.lstOverviewAnnouncement.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSubmitComplaint);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtComplaint);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(965, 483);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Complaint";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSubmitComplaint
            // 
            this.btnSubmitComplaint.Location = new System.Drawing.Point(609, 303);
            this.btnSubmitComplaint.Name = "btnSubmitComplaint";
            this.btnSubmitComplaint.Size = new System.Drawing.Size(77, 29);
            this.btnSubmitComplaint.TabIndex = 14;
            this.btnSubmitComplaint.Text = "Submit";
            this.btnSubmitComplaint.UseVisualStyleBackColor = true;
            this.btnSubmitComplaint.Click += new System.EventHandler(this.btnSubmitComplaint_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Complaint:";
            // 
            // txtComplaint
            // 
            this.txtComplaint.Location = new System.Drawing.Point(26, 49);
            this.txtComplaint.Multiline = true;
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(660, 248);
            this.txtComplaint.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSubmitAnnouncement);
            this.tabPage4.Controls.Add(this.txtAnnouncement);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.lstAnnouncement);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(965, 483);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Announcement";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSubmitAnnouncement
            // 
            this.btnSubmitAnnouncement.Location = new System.Drawing.Point(708, 292);
            this.btnSubmitAnnouncement.Name = "btnSubmitAnnouncement";
            this.btnSubmitAnnouncement.Size = new System.Drawing.Size(77, 29);
            this.btnSubmitAnnouncement.TabIndex = 15;
            this.btnSubmitAnnouncement.Text = "Submit";
            this.btnSubmitAnnouncement.UseVisualStyleBackColor = true;
            this.btnSubmitAnnouncement.Click += new System.EventHandler(this.btnSubmitAnnouncement_Click);
            // 
            // txtAnnouncement
            // 
            this.txtAnnouncement.Location = new System.Drawing.Point(21, 261);
            this.txtAnnouncement.Name = "txtAnnouncement";
            this.txtAnnouncement.Size = new System.Drawing.Size(764, 25);
            this.txtAnnouncement.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Announcements:";
            // 
            // lstAnnouncement
            // 
            this.lstAnnouncement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstAnnouncement.FormattingEnabled = true;
            this.lstAnnouncement.ItemHeight = 17;
            this.lstAnnouncement.Location = new System.Drawing.Point(21, 47);
            this.lstAnnouncement.Name = "lstAnnouncement";
            this.lstAnnouncement.Size = new System.Drawing.Size(764, 208);
            this.lstAnnouncement.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(920, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 33);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormOfficeEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 583);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOfficeEmployee";
            this.Text = "FormOfficeEmployee";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstOverviewSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstOverviewAnnouncement;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSubmitComplaint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComplaint;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSubmitAnnouncement;
        private System.Windows.Forms.TextBox txtAnnouncement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstAnnouncement;
        private System.Windows.Forms.Button btnLogout;
    }
}
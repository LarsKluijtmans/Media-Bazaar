
namespace MediaBazaar
{
    partial class FormEmployeeDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewContract = new System.Windows.Forms.Button();
            this.lblDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnViewContract
            // 
            this.btnViewContract.Location = new System.Drawing.Point(106, 234);
            this.btnViewContract.Name = "btnViewContract";
            this.btnViewContract.Size = new System.Drawing.Size(229, 23);
            this.btnViewContract.TabIndex = 1;
            this.btnViewContract.Text = "View Employee Contract Details";
            this.btnViewContract.UseVisualStyleBackColor = true;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(106, 71);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(42, 15);
            this.lblDetail.TabIndex = 2;
            this.lblDetail.Text = "Details";
            // 
            // FormEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 362);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.btnViewContract);
            this.Controls.Add(this.btnClose);
            this.Name = "FormEmployeeDetails";
            this.Text = "FormEmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewContract;
        private System.Windows.Forms.Label lblDetail;
    }
}
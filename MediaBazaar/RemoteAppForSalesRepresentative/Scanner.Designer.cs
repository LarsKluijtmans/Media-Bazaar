
namespace RemoteAppForSalesRepresentative
{
    partial class Scanner
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
            this.components = new System.ComponentModel.Container();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerRevival = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(36, 62);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(247, 27);
            this.txtBarcode.TabIndex = 0;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // timerRevival
            // 
            this.timerRevival.Tick += new System.EventHandler(this.timerRevival_Tick);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 146);
            this.Controls.Add(this.txtBarcode);
            this.Name = "Scanner";
            this.Text = "Barcode Scanner Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Timer timerRevival;
    }
}


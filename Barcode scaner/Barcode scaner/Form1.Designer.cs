
namespace Barcode_scaner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReShelf = new System.Windows.Forms.Button();
            this.btnAddToAmount = new System.Windows.Forms.Button();
            this.tbDecreaseAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarcode.Location = new System.Drawing.Point(138, 115);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(162, 29);
            this.tbBarcode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(138, 180);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.Size = new System.Drawing.Size(162, 29);
            this.tbAmount.TabIndex = 2;
            this.tbAmount.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReShelf
            // 
            this.btnReShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReShelf.Location = new System.Drawing.Point(70, 333);
            this.btnReShelf.Name = "btnReShelf";
            this.btnReShelf.Size = new System.Drawing.Size(240, 79);
            this.btnReShelf.TabIndex = 4;
            this.btnReShelf.Text = "Request seshelf";
            this.btnReShelf.UseVisualStyleBackColor = true;
            this.btnReShelf.Click += new System.EventHandler(this.btnReShelf_Click);
            // 
            // btnAddToAmount
            // 
            this.btnAddToAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToAmount.Location = new System.Drawing.Point(304, 180);
            this.btnAddToAmount.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddToAmount.Name = "btnAddToAmount";
            this.btnAddToAmount.Size = new System.Drawing.Size(30, 30);
            this.btnAddToAmount.TabIndex = 5;
            this.btnAddToAmount.Text = "+";
            this.btnAddToAmount.UseVisualStyleBackColor = true;
            this.btnAddToAmount.Click += new System.EventHandler(this.btnAddToAmount_Click);
            // 
            // tbDecreaseAmount
            // 
            this.tbDecreaseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDecreaseAmount.Location = new System.Drawing.Point(336, 180);
            this.tbDecreaseAmount.Margin = new System.Windows.Forms.Padding(1);
            this.tbDecreaseAmount.Name = "tbDecreaseAmount";
            this.tbDecreaseAmount.Size = new System.Drawing.Size(30, 30);
            this.tbDecreaseAmount.TabIndex = 6;
            this.tbDecreaseAmount.Text = "-";
            this.tbDecreaseAmount.UseVisualStyleBackColor = true;
            this.tbDecreaseAmount.Click += new System.EventHandler(this.tbDecreaseAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.tbDecreaseAmount);
            this.Controls.Add(this.btnAddToAmount);
            this.Controls.Add(this.btnReShelf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBarcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReShelf;
        private System.Windows.Forms.Button btnAddToAmount;
        private System.Windows.Forms.Button tbDecreaseAmount;
    }
}


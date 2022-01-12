﻿
namespace MediaBazaar
{
    partial class FormNewProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateProduct);
            this.groupBox1.Controls.Add(this.cbxProductType);
            this.groupBox1.Controls.Add(this.tbxBarcode);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Type:";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(127, 23);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(147, 23);
            this.tbxProductName.TabIndex = 3;
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(127, 53);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(147, 23);
            this.tbxBarcode.TabIndex = 4;
            // 
            // cbxProductType
            // 
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(127, 83);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(147, 23);
            this.cbxProductType.TabIndex = 5;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(179, 112);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(95, 23);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Add Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            // 
            // FormNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 166);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNewProduct";
            this.Text = "Add new product";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProductType;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Button btnCreateProduct;
    }
}
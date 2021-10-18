
namespace acr122_demo {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbEmployee = new System.Windows.Forms.ListBox();
            this.gbSearchEmployee = new System.Windows.Forms.GroupBox();
            this.rbnDepotEmployees = new System.Windows.Forms.RadioButton();
            this.rbnSalesEmployees = new System.Windows.Forms.RadioButton();
            this.rbnOfficeEmployees = new System.Windows.Forms.RadioButton();
            this.rbnAllEmployees = new System.Windows.Forms.RadioButton();
            this.labEmployeeID = new System.Windows.Forms.Label();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.labEmployeeName = new System.Windows.Forms.Label();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.labCard = new System.Windows.Forms.Label();
            this.btnConnectCardAndEmployee = new System.Windows.Forms.Button();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.lbCheck = new System.Windows.Forms.ListBox();
            this.gbSearchEmployee.SuspendLayout();
            this.gbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbEmployee
            // 
            this.lbEmployee.FormattingEnabled = true;
            this.lbEmployee.Location = new System.Drawing.Point(9, 16);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(399, 459);
            this.lbEmployee.TabIndex = 1;
            this.lbEmployee.SelectedIndexChanged += new System.EventHandler(this.lbEmployee_SelectedIndexChanged);
            // 
            // gbSearchEmployee
            // 
            this.gbSearchEmployee.Controls.Add(this.rbnDepotEmployees);
            this.gbSearchEmployee.Controls.Add(this.rbnSalesEmployees);
            this.gbSearchEmployee.Controls.Add(this.rbnOfficeEmployees);
            this.gbSearchEmployee.Controls.Add(this.rbnAllEmployees);
            this.gbSearchEmployee.Location = new System.Drawing.Point(447, 16);
            this.gbSearchEmployee.Name = "gbSearchEmployee";
            this.gbSearchEmployee.Size = new System.Drawing.Size(347, 116);
            this.gbSearchEmployee.TabIndex = 2;
            this.gbSearchEmployee.TabStop = false;
            this.gbSearchEmployee.Text = "Search by ";
            // 
            // rbnDepotEmployees
            // 
            this.rbnDepotEmployees.AutoSize = true;
            this.rbnDepotEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnDepotEmployees.Location = new System.Drawing.Point(180, 69);
            this.rbnDepotEmployees.Name = "rbnDepotEmployees";
            this.rbnDepotEmployees.Size = new System.Drawing.Size(151, 24);
            this.rbnDepotEmployees.TabIndex = 3;
            this.rbnDepotEmployees.TabStop = true;
            this.rbnDepotEmployees.Text = "Depot employees";
            this.rbnDepotEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnSalesEmployees
            // 
            this.rbnSalesEmployees.AutoSize = true;
            this.rbnSalesEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSalesEmployees.Location = new System.Drawing.Point(27, 69);
            this.rbnSalesEmployees.Name = "rbnSalesEmployees";
            this.rbnSalesEmployees.Size = new System.Drawing.Size(147, 24);
            this.rbnSalesEmployees.TabIndex = 2;
            this.rbnSalesEmployees.TabStop = true;
            this.rbnSalesEmployees.Text = "Sales employees";
            this.rbnSalesEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnOfficeEmployees
            // 
            this.rbnOfficeEmployees.AutoSize = true;
            this.rbnOfficeEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnOfficeEmployees.Location = new System.Drawing.Point(180, 28);
            this.rbnOfficeEmployees.Name = "rbnOfficeEmployees";
            this.rbnOfficeEmployees.Size = new System.Drawing.Size(149, 24);
            this.rbnOfficeEmployees.TabIndex = 1;
            this.rbnOfficeEmployees.TabStop = true;
            this.rbnOfficeEmployees.Text = "Office employees";
            this.rbnOfficeEmployees.UseVisualStyleBackColor = true;
            // 
            // rbnAllEmployees
            // 
            this.rbnAllEmployees.AutoSize = true;
            this.rbnAllEmployees.Checked = true;
            this.rbnAllEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAllEmployees.Location = new System.Drawing.Point(27, 28);
            this.rbnAllEmployees.Name = "rbnAllEmployees";
            this.rbnAllEmployees.Size = new System.Drawing.Size(124, 24);
            this.rbnAllEmployees.TabIndex = 0;
            this.rbnAllEmployees.TabStop = true;
            this.rbnAllEmployees.Text = "All employees";
            this.rbnAllEmployees.UseVisualStyleBackColor = true;
            // 
            // labEmployeeID
            // 
            this.labEmployeeID.AutoSize = true;
            this.labEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeID.Location = new System.Drawing.Point(460, 147);
            this.labEmployeeID.Name = "labEmployeeID";
            this.labEmployeeID.Size = new System.Drawing.Size(123, 24);
            this.labEmployeeID.TabIndex = 3;
            this.labEmployeeID.Text = "Employee ID:";
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeID.Location = new System.Drawing.Point(464, 174);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.ReadOnly = true;
            this.tbEmployeeID.Size = new System.Drawing.Size(331, 29);
            this.tbEmployeeID.TabIndex = 4;
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeeName.Location = new System.Drawing.Point(464, 246);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.ReadOnly = true;
            this.tbEmployeeName.Size = new System.Drawing.Size(331, 29);
            this.tbEmployeeName.TabIndex = 6;
            // 
            // labEmployeeName
            // 
            this.labEmployeeName.AutoSize = true;
            this.labEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeName.Location = new System.Drawing.Point(460, 219);
            this.labEmployeeName.Name = "labEmployeeName";
            this.labEmployeeName.Size = new System.Drawing.Size(157, 24);
            this.labEmployeeName.TabIndex = 5;
            this.labEmployeeName.Text = "Employee Name:";
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCardNumber.Location = new System.Drawing.Point(464, 314);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.ReadOnly = true;
            this.tbCardNumber.Size = new System.Drawing.Size(331, 29);
            this.tbCardNumber.TabIndex = 8;
            // 
            // labCard
            // 
            this.labCard.AutoSize = true;
            this.labCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCard.Location = new System.Drawing.Point(460, 287);
            this.labCard.Name = "labCard";
            this.labCard.Size = new System.Drawing.Size(129, 24);
            this.labCard.TabIndex = 7;
            this.labCard.Text = "Card Number:";
            // 
            // btnConnectCardAndEmployee
            // 
            this.btnConnectCardAndEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectCardAndEmployee.Location = new System.Drawing.Point(465, 369);
            this.btnConnectCardAndEmployee.Name = "btnConnectCardAndEmployee";
            this.btnConnectCardAndEmployee.Size = new System.Drawing.Size(329, 74);
            this.btnConnectCardAndEmployee.TabIndex = 9;
            this.btnConnectCardAndEmployee.Text = "Connect card to employee";
            this.btnConnectCardAndEmployee.UseVisualStyleBackColor = true;
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.btnConnectCardAndEmployee);
            this.gbEmployee.Controls.Add(this.tbCardNumber);
            this.gbEmployee.Controls.Add(this.labCard);
            this.gbEmployee.Controls.Add(this.tbEmployeeName);
            this.gbEmployee.Controls.Add(this.labEmployeeName);
            this.gbEmployee.Controls.Add(this.tbEmployeeID);
            this.gbEmployee.Controls.Add(this.labEmployeeID);
            this.gbEmployee.Controls.Add(this.gbSearchEmployee);
            this.gbEmployee.Controls.Add(this.lbEmployee);
            this.gbEmployee.Location = new System.Drawing.Point(328, 12);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(813, 487);
            this.gbEmployee.TabIndex = 10;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Employee";
            // 
            // lbCheck
            // 
            this.lbCheck.FormattingEnabled = true;
            this.lbCheck.Location = new System.Drawing.Point(12, 30);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(302, 459);
            this.lbCheck.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 513);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.gbEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSearchEmployee.ResumeLayout(false);
            this.gbSearchEmployee.PerformLayout();
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lbEmployee;
        private System.Windows.Forms.GroupBox gbSearchEmployee;
        private System.Windows.Forms.Label labEmployeeID;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label labEmployeeName;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label labCard;
        private System.Windows.Forms.Button btnConnectCardAndEmployee;
        private System.Windows.Forms.RadioButton rbnAllEmployees;
        private System.Windows.Forms.RadioButton rbnDepotEmployees;
        private System.Windows.Forms.RadioButton rbnSalesEmployees;
        private System.Windows.Forms.RadioButton rbnOfficeEmployees;
        private System.Windows.Forms.GroupBox gbEmployee;
        private System.Windows.Forms.ListBox lbCheck;
    }
}



namespace InvoiceManagementSystem.Views
{
    partial class Reports
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserScheduleLbl = new System.Windows.Forms.Label();
            this.InvTypeLbl = new System.Windows.Forms.Label();
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.SelectUserLbl = new System.Windows.Forms.Label();
            this.UserScheduleDGV = new System.Windows.Forms.DataGridView();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.InvoiceCountLbl = new System.Windows.Forms.Label();
            this.NumberOfInvsTxtBox = new System.Windows.Forms.TextBox();
            this.GenerateInvCountBtn = new System.Windows.Forms.Button();
            this.Arrow = new System.Windows.Forms.Label();
            this.GenerateUserReports = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReportOnInvsByEmpLbl = new System.Windows.Forms.Label();
            this.EmpComboBox = new System.Windows.Forms.ComboBox();
            this.EmpLbl = new System.Windows.Forms.Label();
            this.GenerateEmpReport = new System.Windows.Forms.Button();
            this.Arrow2 = new System.Windows.Forms.Label();
            this.InvCountByEmp = new System.Windows.Forms.Label();
            this.EmpInvCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserScheduleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // UserScheduleLbl
            // 
            this.UserScheduleLbl.AutoSize = true;
            this.UserScheduleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserScheduleLbl.Location = new System.Drawing.Point(12, 141);
            this.UserScheduleLbl.Name = "UserScheduleLbl";
            this.UserScheduleLbl.Size = new System.Drawing.Size(172, 20);
            this.UserScheduleLbl.TabIndex = 3;
            this.UserScheduleLbl.Text = "Generate user invoices";
            // 
            // InvTypeLbl
            // 
            this.InvTypeLbl.AutoSize = true;
            this.InvTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvTypeLbl.Location = new System.Drawing.Point(12, 45);
            this.InvTypeLbl.Name = "InvTypeLbl";
            this.InvTypeLbl.Size = new System.Drawing.Size(457, 20);
            this.InvTypeLbl.TabIndex = 4;
            this.InvTypeLbl.Text = "Generate report on number of invoices based on employee type";
            // 
            // UserComboBox
            // 
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(12, 192);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserComboBox.TabIndex = 5;
            // 
            // SelectUserLbl
            // 
            this.SelectUserLbl.AutoSize = true;
            this.SelectUserLbl.Location = new System.Drawing.Point(12, 170);
            this.SelectUserLbl.Name = "SelectUserLbl";
            this.SelectUserLbl.Size = new System.Drawing.Size(62, 13);
            this.SelectUserLbl.TabIndex = 6;
            this.SelectUserLbl.Text = "Select User";
            // 
            // UserScheduleDGV
            // 
            this.UserScheduleDGV.AllowUserToAddRows = false;
            this.UserScheduleDGV.AllowUserToDeleteRows = false;
            this.UserScheduleDGV.AllowUserToResizeColumns = false;
            this.UserScheduleDGV.AllowUserToResizeRows = false;
            this.UserScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserScheduleDGV.Location = new System.Drawing.Point(12, 222);
            this.UserScheduleDGV.MultiSelect = false;
            this.UserScheduleDGV.Name = "UserScheduleDGV";
            this.UserScheduleDGV.ReadOnly = true;
            this.UserScheduleDGV.RowHeadersVisible = false;
            this.UserScheduleDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserScheduleDGV.Size = new System.Drawing.Size(583, 150);
            this.UserScheduleDGV.TabIndex = 7;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Full-time",
            "Part-time",
            "Contract"});
            this.TypeComboBox.Location = new System.Drawing.Point(12, 92);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 8;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(9, 72);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(31, 13);
            this.TypeLbl.TabIndex = 9;
            this.TypeLbl.Text = "Type";
            // 
            // InvoiceCountLbl
            // 
            this.InvoiceCountLbl.AutoSize = true;
            this.InvoiceCountLbl.Location = new System.Drawing.Point(346, 72);
            this.InvoiceCountLbl.Name = "InvoiceCountLbl";
            this.InvoiceCountLbl.Size = new System.Drawing.Size(73, 13);
            this.InvoiceCountLbl.TabIndex = 12;
            this.InvoiceCountLbl.Text = "Invoice Count";
            // 
            // NumberOfInvsTxtBox
            // 
            this.NumberOfInvsTxtBox.Enabled = false;
            this.NumberOfInvsTxtBox.Location = new System.Drawing.Point(349, 92);
            this.NumberOfInvsTxtBox.Name = "NumberOfInvsTxtBox";
            this.NumberOfInvsTxtBox.ReadOnly = true;
            this.NumberOfInvsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfInvsTxtBox.TabIndex = 13;
            // 
            // GenerateInvCountBtn
            // 
            this.GenerateInvCountBtn.Location = new System.Drawing.Point(158, 90);
            this.GenerateInvCountBtn.Name = "GenerateInvCountBtn";
            this.GenerateInvCountBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateInvCountBtn.TabIndex = 14;
            this.GenerateInvCountBtn.Text = "Generate";
            this.GenerateInvCountBtn.UseVisualStyleBackColor = true;
            this.GenerateInvCountBtn.Click += new System.EventHandler(this.GenerateInvCountBtn_Click);
            // 
            // Arrow
            // 
            this.Arrow.AutoSize = true;
            this.Arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrow.Location = new System.Drawing.Point(281, 95);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(18, 13);
            this.Arrow.TabIndex = 15;
            this.Arrow.Text = "->";
            // 
            // GenerateUserReports
            // 
            this.GenerateUserReports.Location = new System.Drawing.Point(158, 192);
            this.GenerateUserReports.Name = "GenerateUserReports";
            this.GenerateUserReports.Size = new System.Drawing.Size(75, 23);
            this.GenerateUserReports.TabIndex = 16;
            this.GenerateUserReports.Text = "Generate";
            this.GenerateUserReports.UseVisualStyleBackColor = true;
            this.GenerateUserReports.Click += new System.EventHandler(this.GenerateUserReports_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(520, 484);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 17;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReportOnInvsByEmpLbl
            // 
            this.ReportOnInvsByEmpLbl.AutoSize = true;
            this.ReportOnInvsByEmpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportOnInvsByEmpLbl.Location = new System.Drawing.Point(12, 401);
            this.ReportOnInvsByEmpLbl.Name = "ReportOnInvsByEmpLbl";
            this.ReportOnInvsByEmpLbl.Size = new System.Drawing.Size(373, 20);
            this.ReportOnInvsByEmpLbl.TabIndex = 18;
            this.ReportOnInvsByEmpLbl.Text = "Generate report on number of invoices by employee";
            // 
            // EmpComboBox
            // 
            this.EmpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpComboBox.FormattingEnabled = true;
            this.EmpComboBox.Location = new System.Drawing.Point(15, 443);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmpComboBox.TabIndex = 19;
            // 
            // EmpLbl
            // 
            this.EmpLbl.AutoSize = true;
            this.EmpLbl.Location = new System.Drawing.Point(13, 427);
            this.EmpLbl.Name = "EmpLbl";
            this.EmpLbl.Size = new System.Drawing.Size(86, 13);
            this.EmpLbl.TabIndex = 20;
            this.EmpLbl.Text = "Select Employee";
            // 
            // GenerateEmpReport
            // 
            this.GenerateEmpReport.Location = new System.Drawing.Point(158, 441);
            this.GenerateEmpReport.Name = "GenerateEmpReport";
            this.GenerateEmpReport.Size = new System.Drawing.Size(75, 23);
            this.GenerateEmpReport.TabIndex = 21;
            this.GenerateEmpReport.Text = "Generate";
            this.GenerateEmpReport.UseVisualStyleBackColor = true;
            this.GenerateEmpReport.Click += new System.EventHandler(this.GenerateEmployeeReport_Click);
            // 
            // Arrow2
            // 
            this.Arrow2.AutoSize = true;
            this.Arrow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arrow2.Location = new System.Drawing.Point(361, 443);
            this.Arrow2.Name = "Arrow2";
            this.Arrow2.Size = new System.Drawing.Size(18, 13);
            this.Arrow2.TabIndex = 22;
            this.Arrow2.Text = "->";
            // 
            // InvCountByEmp
            // 
            this.InvCountByEmp.AutoSize = true;
            this.InvCountByEmp.Location = new System.Drawing.Point(492, 428);
            this.InvCountByEmp.Name = "InvCountByEmp";
            this.InvCountByEmp.Size = new System.Drawing.Size(73, 13);
            this.InvCountByEmp.TabIndex = 23;
            this.InvCountByEmp.Text = "Invoice Count";
            // 
            // EmpInvCount
            // 
            this.EmpInvCount.Enabled = false;
            this.EmpInvCount.Location = new System.Drawing.Point(495, 444);
            this.EmpInvCount.Name = "EmpInvCount";
            this.EmpInvCount.ReadOnly = true;
            this.EmpInvCount.Size = new System.Drawing.Size(100, 20);
            this.EmpInvCount.TabIndex = 24;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 522);
            this.ControlBox = false;
            this.Controls.Add(this.EmpInvCount);
            this.Controls.Add(this.InvCountByEmp);
            this.Controls.Add(this.Arrow2);
            this.Controls.Add(this.GenerateEmpReport);
            this.Controls.Add(this.EmpLbl);
            this.Controls.Add(this.EmpComboBox);
            this.Controls.Add(this.ReportOnInvsByEmpLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.GenerateUserReports);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.GenerateInvCountBtn);
            this.Controls.Add(this.NumberOfInvsTxtBox);
            this.Controls.Add(this.InvoiceCountLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.UserScheduleDGV);
            this.Controls.Add(this.SelectUserLbl);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.InvTypeLbl);
            this.Controls.Add(this.UserScheduleLbl);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.UserScheduleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserScheduleLbl;
        private System.Windows.Forms.Label InvTypeLbl;
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.Label SelectUserLbl;
        private System.Windows.Forms.DataGridView UserScheduleDGV;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label InvoiceCountLbl;
        private System.Windows.Forms.TextBox NumberOfInvsTxtBox;
        private System.Windows.Forms.Button GenerateInvCountBtn;
        private System.Windows.Forms.Label Arrow;
        private System.Windows.Forms.Button GenerateUserReports;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label ReportOnInvsByEmpLbl;
        private System.Windows.Forms.ComboBox EmpComboBox;
        private System.Windows.Forms.Label EmpLbl;
        private System.Windows.Forms.Button GenerateEmpReport;
        private System.Windows.Forms.Label Arrow2;
        private System.Windows.Forms.Label InvCountByEmp;
        private System.Windows.Forms.TextBox EmpInvCount;
    }
}
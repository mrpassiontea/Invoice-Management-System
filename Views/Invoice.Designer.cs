
namespace InvoiceManagementSystem.Views
{
    partial class Invoice
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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.EmployeeLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.AmountDueLbl = new System.Windows.Forms.Label();
            this.HoursWorkedLbl = new System.Windows.Forms.Label();
            this.PricePerHourLbl = new System.Windows.Forms.Label();
            this.DueDateLbl = new System.Windows.Forms.Label();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.EmployeeList = new System.Windows.Forms.ComboBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.AmountDueTxtBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedTxtBox = new System.Windows.Forms.TextBox();
            this.PricePerHourTxtBox = new System.Windows.Forms.TextBox();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(13, 13);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(0, 20);
            this.HeaderLbl.TabIndex = 0;
            // 
            // EmployeeLbl
            // 
            this.EmployeeLbl.AutoSize = true;
            this.EmployeeLbl.Location = new System.Drawing.Point(17, 50);
            this.EmployeeLbl.Name = "EmployeeLbl";
            this.EmployeeLbl.Size = new System.Drawing.Size(53, 13);
            this.EmployeeLbl.TabIndex = 1;
            this.EmployeeLbl.Text = "Employee";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(17, 96);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 3;
            this.DescriptionLbl.Text = "Description";
            // 
            // AmountDueLbl
            // 
            this.AmountDueLbl.AutoSize = true;
            this.AmountDueLbl.Location = new System.Drawing.Point(17, 188);
            this.AmountDueLbl.Name = "AmountDueLbl";
            this.AmountDueLbl.Size = new System.Drawing.Size(66, 13);
            this.AmountDueLbl.TabIndex = 4;
            this.AmountDueLbl.Text = "Amount Due";
            // 
            // HoursWorkedLbl
            // 
            this.HoursWorkedLbl.AutoSize = true;
            this.HoursWorkedLbl.Location = new System.Drawing.Point(17, 234);
            this.HoursWorkedLbl.Name = "HoursWorkedLbl";
            this.HoursWorkedLbl.Size = new System.Drawing.Size(76, 13);
            this.HoursWorkedLbl.TabIndex = 5;
            this.HoursWorkedLbl.Text = "Hours Worked";
            // 
            // PricePerHourLbl
            // 
            this.PricePerHourLbl.AutoSize = true;
            this.PricePerHourLbl.Location = new System.Drawing.Point(17, 280);
            this.PricePerHourLbl.Name = "PricePerHourLbl";
            this.PricePerHourLbl.Size = new System.Drawing.Size(76, 13);
            this.PricePerHourLbl.TabIndex = 7;
            this.PricePerHourLbl.Text = "Price Per Hour";
            // 
            // DueDateLbl
            // 
            this.DueDateLbl.AutoSize = true;
            this.DueDateLbl.Location = new System.Drawing.Point(17, 142);
            this.DueDateLbl.Name = "DueDateLbl";
            this.DueDateLbl.Size = new System.Drawing.Size(53, 13);
            this.DueDateLbl.TabIndex = 8;
            this.DueDateLbl.Text = "Due Date";
            // 
            // ActionBtn
            // 
            this.ActionBtn.Enabled = false;
            this.ActionBtn.Location = new System.Drawing.Point(96, 325);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(200, 23);
            this.ActionBtn.TabIndex = 10;
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeList.FormattingEnabled = true;
            this.EmployeeList.Location = new System.Drawing.Point(96, 50);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.Size = new System.Drawing.Size(200, 21);
            this.EmployeeList.TabIndex = 11;
            this.EmployeeList.SelectedIndexChanged += new System.EventHandler(this.EmployeeList_SelectedIndexChanged);
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Location = new System.Drawing.Point(96, 96);
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(200, 20);
            this.DescriptionTxtBox.TabIndex = 13;
            this.DescriptionTxtBox.TextChanged += new System.EventHandler(this.DescriptionTxtBox_TextChanged);
            // 
            // AmountDueTxtBox
            // 
            this.AmountDueTxtBox.Location = new System.Drawing.Point(96, 186);
            this.AmountDueTxtBox.Name = "AmountDueTxtBox";
            this.AmountDueTxtBox.Size = new System.Drawing.Size(200, 20);
            this.AmountDueTxtBox.TabIndex = 14;
            this.AmountDueTxtBox.TextChanged += new System.EventHandler(this.AmountDueTxtBox_TextChanged);
            // 
            // HoursWorkedTxtBox
            // 
            this.HoursWorkedTxtBox.Location = new System.Drawing.Point(96, 231);
            this.HoursWorkedTxtBox.Name = "HoursWorkedTxtBox";
            this.HoursWorkedTxtBox.Size = new System.Drawing.Size(200, 20);
            this.HoursWorkedTxtBox.TabIndex = 15;
            this.HoursWorkedTxtBox.TextChanged += new System.EventHandler(this.HoursWorkedTxtBox_TextChanged);
            // 
            // PricePerHourTxtBox
            // 
            this.PricePerHourTxtBox.Location = new System.Drawing.Point(96, 276);
            this.PricePerHourTxtBox.Name = "PricePerHourTxtBox";
            this.PricePerHourTxtBox.Size = new System.Drawing.Size(200, 20);
            this.PricePerHourTxtBox.TabIndex = 17;
            this.PricePerHourTxtBox.TextChanged += new System.EventHandler(this.PricePerHourTxtBox_TextChanged);
            // 
            // DueDate
            // 
            this.DueDate.CustomFormat = "yyyy-MM-dd";
            this.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueDate.Location = new System.Drawing.Point(96, 141);
            this.DueDate.MinDate = new System.DateTime(2021, 12, 23, 0, 0, 0, 0);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(200, 20);
            this.DueDate.TabIndex = 18;
            this.DueDate.ValueChanged += new System.EventHandler(this.DueDate_ValueChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(237, 370);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 407);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.PricePerHourTxtBox);
            this.Controls.Add(this.HoursWorkedTxtBox);
            this.Controls.Add(this.AmountDueTxtBox);
            this.Controls.Add(this.DescriptionTxtBox);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.DueDateLbl);
            this.Controls.Add(this.PricePerHourLbl);
            this.Controls.Add(this.HoursWorkedLbl);
            this.Controls.Add(this.AmountDueLbl);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.EmployeeLbl);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Label EmployeeLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label AmountDueLbl;
        private System.Windows.Forms.Label HoursWorkedLbl;
        private System.Windows.Forms.Label PricePerHourLbl;
        private System.Windows.Forms.Label DueDateLbl;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.ComboBox EmployeeList;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.TextBox AmountDueTxtBox;
        private System.Windows.Forms.TextBox HoursWorkedTxtBox;
        private System.Windows.Forms.TextBox PricePerHourTxtBox;
        private System.Windows.Forms.DateTimePicker DueDate;
        private System.Windows.Forms.Button ExitBtn;
    }
}

namespace InvoiceManagementSystem.Views
{
    partial class Employee
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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.EmployeeNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.EmployeeAdd1 = new System.Windows.Forms.TextBox();
            this.EmployeeCityTxtBox = new System.Windows.Forms.TextBox();
            this.EmployeeCountry = new System.Windows.Forms.TextBox();
            this.EmployeePhone = new System.Windows.Forms.TextBox();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CityLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.EmployeeAddress2 = new System.Windows.Forms.TextBox();
            this.Address2Lbl = new System.Windows.Forms.Label();
            this.PostalLbl = new System.Windows.Forms.Label();
            this.PostalTxtBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.EmployeeTypeLbl = new System.Windows.Forms.Label();
            this.EmployeeTypeComboBox = new System.Windows.Forms.ComboBox();
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
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(14, 90);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(35, 13);
            this.FirstNameLbl.TabIndex = 1;
            this.FirstNameLbl.Text = "Name";
            // 
            // EmployeeNameTxtBox
            // 
            this.EmployeeNameTxtBox.Location = new System.Drawing.Point(77, 88);
            this.EmployeeNameTxtBox.MaxLength = 45;
            this.EmployeeNameTxtBox.Name = "EmployeeNameTxtBox";
            this.EmployeeNameTxtBox.Size = new System.Drawing.Size(152, 20);
            this.EmployeeNameTxtBox.TabIndex = 1;
            this.EmployeeNameTxtBox.TextChanged += new System.EventHandler(this.EmployeeNameTxtBox_TextChanged);
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(14, 164);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(45, 13);
            this.AddressLbl.TabIndex = 5;
            this.AddressLbl.Text = "Address";
            // 
            // EmployeeAdd1
            // 
            this.EmployeeAdd1.Location = new System.Drawing.Point(77, 162);
            this.EmployeeAdd1.MaxLength = 50;
            this.EmployeeAdd1.Name = "EmployeeAdd1";
            this.EmployeeAdd1.Size = new System.Drawing.Size(152, 20);
            this.EmployeeAdd1.TabIndex = 3;
            this.EmployeeAdd1.TextChanged += new System.EventHandler(this.EmployeeAdd1_TextChanged);
            // 
            // EmployeeCityTxtBox
            // 
            this.EmployeeCityTxtBox.Location = new System.Drawing.Point(77, 236);
            this.EmployeeCityTxtBox.MaxLength = 50;
            this.EmployeeCityTxtBox.Name = "EmployeeCityTxtBox";
            this.EmployeeCityTxtBox.Size = new System.Drawing.Size(152, 20);
            this.EmployeeCityTxtBox.TabIndex = 5;
            this.EmployeeCityTxtBox.TextChanged += new System.EventHandler(this.EmployeeCityTxtBox_TextChanged);
            // 
            // EmployeeCountry
            // 
            this.EmployeeCountry.Location = new System.Drawing.Point(77, 310);
            this.EmployeeCountry.MaxLength = 50;
            this.EmployeeCountry.Name = "EmployeeCountry";
            this.EmployeeCountry.Size = new System.Drawing.Size(152, 20);
            this.EmployeeCountry.TabIndex = 7;
            this.EmployeeCountry.TextChanged += new System.EventHandler(this.EmployeeCountry_TextChanged);
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.Location = new System.Drawing.Point(77, 347);
            this.EmployeePhone.MaxLength = 20;
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.Size = new System.Drawing.Size(152, 20);
            this.EmployeePhone.TabIndex = 8;
            this.EmployeePhone.TextChanged += new System.EventHandler(this.EmployeePhone_TextChanged);
            // 
            // ActionBtn
            // 
            this.ActionBtn.Enabled = false;
            this.ActionBtn.Location = new System.Drawing.Point(77, 387);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(152, 23);
            this.ActionBtn.TabIndex = 9;
            this.ActionBtn.UseVisualStyleBackColor = true;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(204, 418);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CityLbl
            // 
            this.CityLbl.AutoSize = true;
            this.CityLbl.Location = new System.Drawing.Point(14, 238);
            this.CityLbl.Name = "CityLbl";
            this.CityLbl.Size = new System.Drawing.Size(24, 13);
            this.CityLbl.TabIndex = 14;
            this.CityLbl.Text = "City";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Location = new System.Drawing.Point(14, 312);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(43, 13);
            this.CountryLbl.TabIndex = 15;
            this.CountryLbl.Text = "Country";
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Location = new System.Drawing.Point(14, 349);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(38, 13);
            this.PhoneLbl.TabIndex = 16;
            this.PhoneLbl.Text = "Phone";
            // 
            // EmployeeAddress2
            // 
            this.EmployeeAddress2.Location = new System.Drawing.Point(77, 199);
            this.EmployeeAddress2.MaxLength = 50;
            this.EmployeeAddress2.Name = "EmployeeAddress2";
            this.EmployeeAddress2.Size = new System.Drawing.Size(152, 20);
            this.EmployeeAddress2.TabIndex = 4;
            // 
            // Address2Lbl
            // 
            this.Address2Lbl.AutoSize = true;
            this.Address2Lbl.Location = new System.Drawing.Point(14, 201);
            this.Address2Lbl.Name = "Address2Lbl";
            this.Address2Lbl.Size = new System.Drawing.Size(54, 13);
            this.Address2Lbl.TabIndex = 18;
            this.Address2Lbl.Text = "Address 2";
            this.toolTip1.SetToolTip(this.Address2Lbl, "Address 2 is optional.");
            // 
            // PostalLbl
            // 
            this.PostalLbl.AutoSize = true;
            this.PostalLbl.Location = new System.Drawing.Point(14, 275);
            this.PostalLbl.Name = "PostalLbl";
            this.PostalLbl.Size = new System.Drawing.Size(36, 13);
            this.PostalLbl.TabIndex = 19;
            this.PostalLbl.Text = "Postal";
            // 
            // PostalTxtBox
            // 
            this.PostalTxtBox.Location = new System.Drawing.Point(77, 273);
            this.PostalTxtBox.MaxLength = 10;
            this.PostalTxtBox.Name = "PostalTxtBox";
            this.PostalTxtBox.Size = new System.Drawing.Size(152, 20);
            this.PostalTxtBox.TabIndex = 6;
            this.PostalTxtBox.TextChanged += new System.EventHandler(this.PostalTxtBox_TextChanged);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(77, 125);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(152, 20);
            this.EmailTxtBox.TabIndex = 2;
            this.EmailTxtBox.TextChanged += new System.EventHandler(this.EmailTxtBox_TextChanged);
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(14, 127);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EmailLbl.TabIndex = 21;
            this.EmailLbl.Text = "Email";
            // 
            // EmployeeTypeLbl
            // 
            this.EmployeeTypeLbl.AutoSize = true;
            this.EmployeeTypeLbl.Location = new System.Drawing.Point(14, 53);
            this.EmployeeTypeLbl.Name = "EmployeeTypeLbl";
            this.EmployeeTypeLbl.Size = new System.Drawing.Size(31, 13);
            this.EmployeeTypeLbl.TabIndex = 22;
            this.EmployeeTypeLbl.Text = "Type";
            // 
            // EmployeeTypeComboBox
            // 
            this.EmployeeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeTypeComboBox.FormattingEnabled = true;
            this.EmployeeTypeComboBox.Items.AddRange(new object[] {
            "Full-time",
            "Part-time",
            "Contract"});
            this.EmployeeTypeComboBox.Location = new System.Drawing.Point(77, 50);
            this.EmployeeTypeComboBox.Name = "EmployeeTypeComboBox";
            this.EmployeeTypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.EmployeeTypeComboBox.TabIndex = 0;
            this.EmployeeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeTypeComboBox_SelectedIndexChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.ControlBox = false;
            this.Controls.Add(this.EmployeeTypeComboBox);
            this.Controls.Add(this.EmployeeTypeLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.PostalTxtBox);
            this.Controls.Add(this.PostalLbl);
            this.Controls.Add(this.Address2Lbl);
            this.Controls.Add(this.EmployeeAddress2);
            this.Controls.Add(this.PhoneLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.CityLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.EmployeePhone);
            this.Controls.Add(this.EmployeeCountry);
            this.Controls.Add(this.EmployeeCityTxtBox);
            this.Controls.Add(this.EmployeeAdd1);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.EmployeeNameTxtBox);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox EmployeeNameTxtBox;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox EmployeeAdd1;
        private System.Windows.Forms.TextBox EmployeeCityTxtBox;
        private System.Windows.Forms.TextBox EmployeeCountry;
        private System.Windows.Forms.TextBox EmployeePhone;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label CityLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.TextBox EmployeeAddress2;
        private System.Windows.Forms.Label Address2Lbl;
        private System.Windows.Forms.Label PostalLbl;
        private System.Windows.Forms.TextBox PostalTxtBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label EmployeeTypeLbl;
        private System.Windows.Forms.ComboBox EmployeeTypeComboBox;
    }
}
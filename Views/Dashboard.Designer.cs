
namespace InvoiceManagementSystem.Views
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invDGV = new System.Windows.Forms.DataGridView();
            this.empDGV = new System.Windows.Forms.DataGridView();
            this.InvLbl = new System.Windows.Forms.Label();
            this.EmpLbl = new System.Windows.Forms.Label();
            this.AddInvBtn = new System.Windows.Forms.Button();
            this.ModifyInvBtn = new System.Windows.Forms.Button();
            this.DeleteInvBtn = new System.Windows.Forms.Button();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.ModifyEmpBtn = new System.Windows.Forms.Button();
            this.DeleteEmpBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.SearchEmpBtn = new System.Windows.Forms.Button();
            this.SearchInvBtn = new System.Windows.Forms.Button();
            this.InvSearchTxtBox = new System.Windows.Forms.TextBox();
            this.SearchEmpTxtBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // invDGV
            // 
            this.invDGV.AllowUserToAddRows = false;
            this.invDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.invDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.invDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invDGV.Location = new System.Drawing.Point(142, 42);
            this.invDGV.MultiSelect = false;
            this.invDGV.Name = "invDGV";
            this.invDGV.ReadOnly = true;
            this.invDGV.RowHeadersVisible = false;
            this.invDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invDGV.Size = new System.Drawing.Size(689, 150);
            this.invDGV.TabIndex = 1;
            // 
            // empDGV
            // 
            this.empDGV.AllowUserToAddRows = false;
            this.empDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.empDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.empDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.empDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.empDGV.Location = new System.Drawing.Point(142, 310);
            this.empDGV.MultiSelect = false;
            this.empDGV.Name = "empDGV";
            this.empDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.empDGV.RowHeadersVisible = false;
            this.empDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.empDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empDGV.Size = new System.Drawing.Size(689, 150);
            this.empDGV.TabIndex = 2;
            // 
            // InvLbl
            // 
            this.InvLbl.AutoSize = true;
            this.InvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvLbl.Location = new System.Drawing.Point(138, 13);
            this.InvLbl.Name = "InvLbl";
            this.InvLbl.Size = new System.Drawing.Size(112, 20);
            this.InvLbl.TabIndex = 3;
            this.InvLbl.Text = "List of invoices";
            // 
            // EmpLbl
            // 
            this.EmpLbl.AutoSize = true;
            this.EmpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLbl.Location = new System.Drawing.Point(138, 279);
            this.EmpLbl.Name = "EmpLbl";
            this.EmpLbl.Size = new System.Drawing.Size(132, 20);
            this.EmpLbl.TabIndex = 4;
            this.EmpLbl.Text = "List of employees";
            // 
            // AddInvBtn
            // 
            this.AddInvBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddInvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddInvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddInvBtn.ForeColor = System.Drawing.Color.White;
            this.AddInvBtn.Location = new System.Drawing.Point(209, 213);
            this.AddInvBtn.Name = "AddInvBtn";
            this.AddInvBtn.Size = new System.Drawing.Size(178, 30);
            this.AddInvBtn.TabIndex = 5;
            this.AddInvBtn.Text = "Add Invoice";
            this.AddInvBtn.UseVisualStyleBackColor = false;
            this.AddInvBtn.Click += new System.EventHandler(this.AddInvBtn_Click);
            // 
            // ModifyInvBtn
            // 
            this.ModifyInvBtn.BackColor = System.Drawing.Color.Yellow;
            this.ModifyInvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyInvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyInvBtn.Location = new System.Drawing.Point(427, 213);
            this.ModifyInvBtn.Name = "ModifyInvBtn";
            this.ModifyInvBtn.Size = new System.Drawing.Size(178, 30);
            this.ModifyInvBtn.TabIndex = 6;
            this.ModifyInvBtn.Text = "Modify Invoice";
            this.ModifyInvBtn.UseVisualStyleBackColor = false;
            this.ModifyInvBtn.Click += new System.EventHandler(this.ModifyInvBtn_Click);
            // 
            // DeleteInvBtn
            // 
            this.DeleteInvBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteInvBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteInvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInvBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteInvBtn.Location = new System.Drawing.Point(645, 213);
            this.DeleteInvBtn.Name = "DeleteInvBtn";
            this.DeleteInvBtn.Size = new System.Drawing.Size(184, 30);
            this.DeleteInvBtn.TabIndex = 7;
            this.DeleteInvBtn.Text = "Delete Invoice";
            this.DeleteInvBtn.UseVisualStyleBackColor = false;
            this.DeleteInvBtn.Click += new System.EventHandler(this.DeleteInvBtn_Click);
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.AddEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBtn.ForeColor = System.Drawing.Color.White;
            this.AddEmpBtn.Location = new System.Drawing.Point(209, 486);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(184, 30);
            this.AddEmpBtn.TabIndex = 8;
            this.AddEmpBtn.Text = "Add Employee";
            this.AddEmpBtn.UseVisualStyleBackColor = false;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmpBtn_Click);
            // 
            // ModifyEmpBtn
            // 
            this.ModifyEmpBtn.BackColor = System.Drawing.Color.Yellow;
            this.ModifyEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyEmpBtn.Location = new System.Drawing.Point(427, 486);
            this.ModifyEmpBtn.Name = "ModifyEmpBtn";
            this.ModifyEmpBtn.Size = new System.Drawing.Size(184, 30);
            this.ModifyEmpBtn.TabIndex = 9;
            this.ModifyEmpBtn.Text = "Modify Employee";
            this.ModifyEmpBtn.UseVisualStyleBackColor = false;
            this.ModifyEmpBtn.Click += new System.EventHandler(this.ModifyEmpBtn_Click);
            // 
            // DeleteEmpBtn
            // 
            this.DeleteEmpBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmpBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteEmpBtn.Location = new System.Drawing.Point(645, 486);
            this.DeleteEmpBtn.Name = "DeleteEmpBtn";
            this.DeleteEmpBtn.Size = new System.Drawing.Size(184, 30);
            this.DeleteEmpBtn.TabIndex = 10;
            this.DeleteEmpBtn.Text = "Delete Employee";
            this.DeleteEmpBtn.UseVisualStyleBackColor = false;
            this.DeleteEmpBtn.Click += new System.EventHandler(this.DeleteEmpBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(12, 78);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(114, 30);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsBtn.Location = new System.Drawing.Point(12, 42);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(114, 30);
            this.ReportsBtn.TabIndex = 13;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = true;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // SearchEmpBtn
            // 
            this.SearchEmpBtn.Enabled = false;
            this.SearchEmpBtn.Location = new System.Drawing.Point(346, 276);
            this.SearchEmpBtn.Name = "SearchEmpBtn";
            this.SearchEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchEmpBtn.TabIndex = 14;
            this.SearchEmpBtn.Text = "Search";
            this.SearchEmpBtn.UseVisualStyleBackColor = true;
            this.SearchEmpBtn.Click += new System.EventHandler(this.SearchEmpBtn_Click);
            // 
            // SearchInvBtn
            // 
            this.SearchInvBtn.Enabled = false;
            this.SearchInvBtn.Location = new System.Drawing.Point(346, 13);
            this.SearchInvBtn.Name = "SearchInvBtn";
            this.SearchInvBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchInvBtn.TabIndex = 15;
            this.SearchInvBtn.Text = "Search";
            this.SearchInvBtn.UseVisualStyleBackColor = true;
            this.SearchInvBtn.Click += new System.EventHandler(this.SearchInvBtn_Click);
            // 
            // InvSearchTxtBox
            // 
            this.InvSearchTxtBox.Location = new System.Drawing.Point(427, 15);
            this.InvSearchTxtBox.Name = "InvSearchTxtBox";
            this.InvSearchTxtBox.Size = new System.Drawing.Size(402, 20);
            this.InvSearchTxtBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.InvSearchTxtBox, "Search invoice by description");
            this.InvSearchTxtBox.TextChanged += new System.EventHandler(this.InvSearchTxtBox_TextChanged);
            // 
            // SearchEmpTxtBox
            // 
            this.SearchEmpTxtBox.Location = new System.Drawing.Point(427, 279);
            this.SearchEmpTxtBox.Name = "SearchEmpTxtBox";
            this.SearchEmpTxtBox.Size = new System.Drawing.Size(402, 20);
            this.SearchEmpTxtBox.TabIndex = 17;
            this.toolTip1.SetToolTip(this.SearchEmpTxtBox, "Search employee by name");
            this.SearchEmpTxtBox.TextChanged += new System.EventHandler(this.SearchEmpTxtBox_TextChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 530);
            this.ControlBox = false;
            this.Controls.Add(this.SearchEmpTxtBox);
            this.Controls.Add(this.InvSearchTxtBox);
            this.Controls.Add(this.SearchInvBtn);
            this.Controls.Add(this.SearchEmpBtn);
            this.Controls.Add(this.ReportsBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteEmpBtn);
            this.Controls.Add(this.ModifyEmpBtn);
            this.Controls.Add(this.AddEmpBtn);
            this.Controls.Add(this.DeleteInvBtn);
            this.Controls.Add(this.ModifyInvBtn);
            this.Controls.Add(this.AddInvBtn);
            this.Controls.Add(this.EmpLbl);
            this.Controls.Add(this.InvLbl);
            this.Controls.Add(this.empDGV);
            this.Controls.Add(this.invDGV);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.invDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView invDGV;
        private System.Windows.Forms.DataGridView empDGV;
        private System.Windows.Forms.Label InvLbl;
        private System.Windows.Forms.Label EmpLbl;
        private System.Windows.Forms.Button AddInvBtn;
        private System.Windows.Forms.Button ModifyInvBtn;
        private System.Windows.Forms.Button DeleteInvBtn;
        private System.Windows.Forms.Button AddEmpBtn;
        private System.Windows.Forms.Button ModifyEmpBtn;
        private System.Windows.Forms.Button DeleteEmpBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Button SearchEmpBtn;
        private System.Windows.Forms.Button SearchInvBtn;
        private System.Windows.Forms.TextBox InvSearchTxtBox;
        private System.Windows.Forms.TextBox SearchEmpTxtBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
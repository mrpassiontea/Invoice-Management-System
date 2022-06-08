using System;
using System.Windows.Forms;
using InvoiceManagementSystem.Models.Dashboard;
using InvoiceManagementSystem.Models.Database;
using InvoiceManagementSystem.Models.Entities;

namespace InvoiceManagementSystem.Views
{
    public partial class Employee : Form
    {
        DGVEmployee employee;
        private IIMSConnection _imsConnection;
        User currentUser;
        public Employee(IIMSConnection dataAccess)
        {
            _imsConnection = dataAccess;
            InitializeComponent();
            currentUser = _imsConnection.CurrentUser;
            Text = "Create Employee";
            HeaderLbl.Text = "Create Employee";
            ActionBtn.Text = "Create Employee";
            ActionBtn.Enabled = IsEnabled();
            EmployeeTypeComboBox.SelectedIndex = 0;
        }

        public bool IsEnabled()
        {
            // Not every employee will have an Address2, thus, Address2 is an optional field which will result in "" if empty on submit. 
            return (!string.IsNullOrWhiteSpace(EmployeeNameTxtBox.Text) && !string.IsNullOrWhiteSpace(EmployeeAdd1.Text)
                && !string.IsNullOrWhiteSpace(EmployeeCityTxtBox.Text) && !string.IsNullOrWhiteSpace(PostalTxtBox.Text) 
                && !string.IsNullOrWhiteSpace(EmployeeCountry.Text) && !string.IsNullOrWhiteSpace(EmployeePhone.Text)
                && !string.IsNullOrWhiteSpace(EmailTxtBox.Text) && EmployeeTypeComboBox.SelectedIndex > -1);
        }

        public Employee(IIMSConnection dataAccess, DataGridViewRow selectedEmployeeRow)
        {
            _imsConnection = dataAccess;
            InitializeComponent();
            currentUser = _imsConnection.CurrentUser;
            Text = "Modify Employee";
            HeaderLbl.Text = "Modify Employee";
            ActionBtn.Text = "Modify Employee";
            EmployeeNameTxtBox.Text = selectedEmployeeRow.Cells["Name"].Value.ToString();
            EmployeeAdd1.Text = selectedEmployeeRow.Cells["Address"].Value.ToString();
            EmployeeAddress2.Text = selectedEmployeeRow.Cells["Address2"].Value.ToString();
            EmployeeCityTxtBox.Text = selectedEmployeeRow.Cells["City"].Value.ToString();
            PostalTxtBox.Text = selectedEmployeeRow.Cells["PostalCode"].Value.ToString();
            EmployeeCountry.Text = selectedEmployeeRow.Cells["Country"].Value.ToString();
            EmployeePhone.Text = selectedEmployeeRow.Cells["Phone"].Value.ToString();
            EmailTxtBox.Text = selectedEmployeeRow.Cells["Email"].Value.ToString();
            // Use a lambda function to easily get the data of the employee with specific ID. 
            employee = _imsConnection.GetEmployee(selectedEmployeeRow.Cells["ID"].Value.ToString());
            EmployeeTypeComboBox.SelectedItem = employee.EmployeeType;
            ActionBtn.Enabled = IsEnabled();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            var date = DateTime.UtcNow;
            if (ActionBtn.Text.Equals("Modify Employee"))
            {
                var result = MessageBox.Show("Are you sure you want to modify this employee?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Continue modification 
                    employee.Name = EmployeeNameTxtBox.Text;
                    employee.Email = EmailTxtBox.Text;
                    employee.EmployeeType = (string)EmployeeTypeComboBox.SelectedItem;
                    employee.Address = EmployeeAdd1.Text;
                    employee.Address2 = EmployeeAddress2.Text;
                    employee.City = EmployeeCityTxtBox.Text;
                    employee.PostalCode = PostalTxtBox.Text;
                    employee.Country = EmployeeCountry.Text;
                    employee.Phone = EmployeePhone.Text;
                    employee.LastUpdate = date;
                    employee.LastUpdateBy = currentUser.UserName;
                    _imsConnection.ModifyEmployee(employee);
                }
            } else
            {
                employee = new DGVEmployee()
                {
                    Name = EmployeeNameTxtBox.Text,
                    Email = EmailTxtBox.Text,
                    EmployeeType = (string)EmployeeTypeComboBox.SelectedItem,
                    Address = EmployeeAdd1.Text,
                    Address2 = EmployeeAddress2.Text,
                    City = EmployeeCityTxtBox.Text,
                    PostalCode = PostalTxtBox.Text,
                    Country = EmployeeCountry.Text,
                    Phone = EmployeePhone.Text,
                    CreateDate = date,
                    LastUpdate = date,
                    CreatedBy = currentUser.UserName,
                    LastUpdateBy = currentUser.UserName
                };
                _imsConnection.CreateEmployee(employee);
            }
            Close();
        }

        private void EmployeeNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

     
        private void PostalTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void EmployeeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void EmployeeAdd1_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void EmployeeCityTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void EmployeeCountry_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void EmployeePhone_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }
    }
}

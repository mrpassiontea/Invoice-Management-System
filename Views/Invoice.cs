using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceManagementSystem.Models.Dashboard;
using InvoiceManagementSystem.Models.Database;
using InvoiceManagementSystem.Models.Entities;

namespace InvoiceManagementSystem.Views
{
    public partial class Invoice : Form
    {
        Dictionary<int, string> tempEmployeeList = new Dictionary<int, string>();
        DGVInvoice invoice;
        private IIMSConnection _imsConnection;
        User currentUser;
        public Invoice(IIMSConnection dataAccess)
        {
            _imsConnection = dataAccess;
            InitializeComponent();
            currentUser = _imsConnection.CurrentUser;
            Text = "Create Invoice";
            HeaderLbl.Text = "Create Invoice";
            ActionBtn.Text = "Create Invoice";
            foreach (var employee in _imsConnection.Employees)
            {
                tempEmployeeList.Add(employee.ID, employee.Name);
            }
            EmployeeList.DisplayMember = "Value";
            EmployeeList.ValueMember = "Key";
            EmployeeList.DataSource = new BindingSource(tempEmployeeList, null);
            if (tempEmployeeList.Count == 0)
            {
                EmployeeList.Enabled = false;
            }
            ActionBtn.Enabled = IsEnabled();
        }
        public Invoice(IIMSConnection dataAccess, DataGridViewRow selectedInvoice)
        {
            _imsConnection = dataAccess;
            InitializeComponent();
            currentUser = _imsConnection.CurrentUser;
            Text = "Modify Invoice";
            HeaderLbl.Text = "Modify Invoice";
            ActionBtn.Text = "Modify Invoice";
            foreach (var employee in _imsConnection.Employees)
            {
                tempEmployeeList.Add(employee.ID, employee.Name);
            }

            EmployeeList.DisplayMember = "Value";
            EmployeeList.ValueMember = "Key";
            EmployeeList.DataSource = new BindingSource(tempEmployeeList, null);
            if (tempEmployeeList.Count == 0)
            {
                EmployeeList.Enabled = false;
            }
            invoice = _imsConnection.GetInvoice(selectedInvoice.Cells["ID"].Value.ToString());
            EmployeeList.SelectedValue = invoice.EmployeeId;
            DescriptionTxtBox.Text = invoice.Description;
            AmountDueTxtBox.Text = invoice.TotalAmountDue.ToString();
            HoursWorkedTxtBox.Text = invoice.HoursWorked.ToString();
            PricePerHourTxtBox.Text = invoice.PricePerHour.ToString();
            DueDate.Value = invoice.PaymentDueDate;
            ActionBtn.Enabled = IsEnabled();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsEnabled()
        {
            return (EmployeeList.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(DescriptionTxtBox.Text) 
                && !string.IsNullOrWhiteSpace(AmountDueTxtBox.Text) && !string.IsNullOrWhiteSpace(HoursWorkedTxtBox.Text) 
                && !string.IsNullOrWhiteSpace(PricePerHourTxtBox.Text) && _imsConnection.Employees.Count > 0 && !string.IsNullOrWhiteSpace(DueDate.Text) &&
                double.TryParse(AmountDueTxtBox.Text, out _) && double.TryParse(HoursWorkedTxtBox.Text, out _) && double.TryParse(PricePerHourTxtBox.Text, out _));
        }

        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            if (double.Parse(AmountDueTxtBox.Text) < 0 || double.Parse(HoursWorkedTxtBox.Text) < 0 || double.Parse(PricePerHourTxtBox.Text) < 0)
            {
                MessageBox.Show("Amount Due, Hours Worked, Price Per Hour can not be negative.");
                return;
            }
            var date = DateTime.UtcNow;
            if (ActionBtn.Text.Equals("Modify Invoice"))
            {
                var result = MessageBox.Show("Are you sure you want to modify this invoice?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (double.TryParse(AmountDueTxtBox.Text, out _) && double.TryParse(HoursWorkedTxtBox.Text, out _) && double.TryParse(PricePerHourTxtBox.Text, out _))
                    {
                        invoice.EmployeeId = (int)EmployeeList.SelectedValue;
                        invoice.UserId = currentUser.UserId;
                        invoice.PaymentDueDate = DateTime.Parse(DueDate.Value.ToString()).ToUniversalTime();
                        invoice.Description = DescriptionTxtBox.Text;
                        invoice.TotalAmountDue = string.Format("{0:0.##}", AmountDueTxtBox.Text);
                        invoice.HoursWorked = string.Format("{0:0.##}", HoursWorkedTxtBox.Text);
                        invoice.PricePerHour = string.Format("{0:0.##}", PricePerHourTxtBox.Text);
                        invoice.LastUpdate = date;
                        invoice.LastUpdateBy = currentUser.UserName;
                        _imsConnection.ModifyInvoice(invoice);
                        Close();
                    } else
                    {
                        MessageBox.Show("Total Amount Due, Hours Worked, Price Per Hour can only be numbers.", "Error: Invalid Entry", MessageBoxButtons.OK);
                    }
                    
                }
            }
            else
            {
                if (double.TryParse(AmountDueTxtBox.Text, out _) && double.TryParse(HoursWorkedTxtBox.Text, out _) && double.TryParse(PricePerHourTxtBox.Text, out _))
                {
                    invoice = new DGVInvoice()
                    {
                        EmployeeId = (int)EmployeeList.SelectedValue,
                        UserId = currentUser.UserId,
                        PaymentDueDate = DateTime.Parse(DueDate.Value.ToString()).ToUniversalTime(),
                        Description = DescriptionTxtBox.Text,
                        TotalAmountDue = string.Format("{0:0.##}", AmountDueTxtBox.Text),
                        HoursWorked = string.Format("{0:0.##}", HoursWorkedTxtBox.Text),
                        PricePerHour = string.Format("{0:0.##}", PricePerHourTxtBox.Text),
                        LastUpdate = date,
                        LastUpdateBy = currentUser.UserName,
                        CreateDate = date,
                        CreatedBy = currentUser.UserName,
                    };
                    _imsConnection.CreateInvoice(invoice);
                    Close();
                } else
                {
                    MessageBox.Show("Total Amount Due, Hours Worked, Price Per Hour can only be numbers.", "Error: Invalid Entry", MessageBoxButtons.OK);
                }
            }
        }

        private void DescriptionTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void DueDate_ValueChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void AmountDueTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void HoursWorkedTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }

        private void PricePerHourTxtBox_TextChanged(object sender, EventArgs e)
        {
            ActionBtn.Enabled = IsEnabled();
        }
    }
}

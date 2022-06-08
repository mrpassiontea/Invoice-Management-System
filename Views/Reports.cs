using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using InvoiceManagementSystem.Models.Dashboard;
using InvoiceManagementSystem.Models.Database;
using InvoiceManagementSystem.Models.Entities;

namespace InvoiceManagementSystem.Views
{
    public partial class Reports : Form
    {
        Dictionary<int, string> tempEmpList = new Dictionary<int, string>();
        Dictionary<int, string> tempUserList = new Dictionary<int, string>();
        BindingList<DGVInvoice> invoices;
        BindingList<DGVEmployee> employees;
        BindingList<User> users;
        private IIMSConnection _imsConnection;
        public Reports(IIMSConnection dataAccess)
        {
            InitializeComponent();
            _imsConnection = dataAccess;
            invoices = dataAccess.Invoices;
            employees = dataAccess.Employees;
            users = dataAccess.Users;

            // Provide the employee combobox a source of employees to select from. 
            foreach (var employee in employees)
            {
                tempEmpList.Add(employee.ID, employee.Name);
            }
            EmpComboBox.DisplayMember = "Value";
            EmpComboBox.ValueMember = "Key";
            EmpComboBox.DataSource = new BindingSource(tempEmpList, null);

            foreach(var user in users)
            {
                tempUserList.Add(user.UserId, user.UserName);
            }
            UserComboBox.DisplayMember = "Value";
            UserComboBox.ValueMember = "Key";
            UserComboBox.DataSource = new BindingSource(tempUserList, null);
            UserScheduleDGV.DataSource = new List<DGVInvoice>();
            HideInvColumns();

            if (employees.Count == 0)
            {
                GenerateEmpReport.Enabled = false;
            }

            if (users.Count == 0)
            {
                GenerateUserReports.Enabled = false;
            }

            TypeComboBox.SelectedIndex = 0;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideInvColumns()
        {
            UserScheduleDGV.Columns["UserId"].Visible = false;
            UserScheduleDGV.Columns["CreateDate"].Visible = false;
            UserScheduleDGV.Columns["LastUpdateBy"].Visible = false;
        }

        private void GenerateEmployeeReport_Click(object sender, EventArgs e)
        {
            if (EmpComboBox.SelectedIndex > -1)
            {
                var employeeId = (int)EmpComboBox.SelectedValue;
                int invoiceCount = 0;
                invoiceCount = invoices.Where(invoice => invoice.EmployeeId == employeeId).ToList().Count();
                EmpInvCount.Text = invoiceCount.ToString();
            } else
            {
                MessageBox.Show("You must select a employee.", "No employee selected.", MessageBoxButtons.OK);
            }
        }

        private void GenerateUserReports_Click(object sender, EventArgs e)
        {
            var tempInvList = new List<DGVInvoice>();
            if (UserComboBox.SelectedIndex > -1)
            {
                var userId = (int)UserComboBox.SelectedValue;
                tempInvList = invoices.Where(inv => inv.UserId == userId).ToList();
                UserScheduleDGV.DataSource = tempInvList;
            }
            else
            {
                MessageBox.Show("You must select a user.", "No user selected.", MessageBoxButtons.OK);
            }
        }

        private void GenerateInvCountBtn_Click(object sender, EventArgs e)
        {
            if (TypeComboBox.SelectedIndex > -1)
            {
                var type = (string)TypeComboBox.SelectedItem;
                int invoiceCount = 0;
                foreach (var inv in invoices)
                {
                    foreach(var emp in employees)
                    {
                        if (inv.EmployeeId == emp.ID)
                        {
                            if (type == emp.EmployeeType) invoiceCount++;
                        }
                    }
                }
                NumberOfInvsTxtBox.Text = invoiceCount.ToString();
            }
            else
            {
                MessageBox.Show("Please ensure you've selected a type of employee.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}

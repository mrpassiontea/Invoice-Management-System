using System;
using System.ComponentModel;
using System.Windows.Forms;
using InvoiceManagementSystem.Models.Dashboard;
using InvoiceManagementSystem.Models.Database;

namespace InvoiceManagementSystem.Views
{
    public partial class Dashboard : Form
    {
        BindingList<DGVInvoice> invoices;
        BindingList<DGVEmployee> employees;
        IIMSConnection _imsConnection;
        public Dashboard(IIMSConnection dataAccess)
        {
            _imsConnection = dataAccess;
            InitializeComponent();
            invoices = _imsConnection.Invoices;
            employees = _imsConnection.Employees;
            invDGV.DataSource = invoices;
            HideInvColumns();
            empDGV.DataSource = employees;
            HideEmpColumns();
        }

        private void HideInvColumns()
        {
            invDGV.Columns["UserId"].Visible = false;
            invDGV.Columns["CreateDate"].Visible = false;
            invDGV.Columns["CreatedBy"].Visible = false;
            invDGV.Columns["LastUpdate"].Visible = false;
            invDGV.Columns["LastUpdateBy"].Visible = false;
            invDGV.Columns["PricePerHour"].Visible = false;
        }

        private void HideEmpColumns()
        {
            empDGV.Columns["AddressId"].Visible = false;
            empDGV.Columns["CityId"].Visible = false;
            empDGV.Columns["CountryId"].Visible = false;
            empDGV.Columns["CreateDate"].Visible = false;
            empDGV.Columns["CreatedBy"].Visible = false;
            empDGV.Columns["LastUpdate"].Visible = false;
            empDGV.Columns["LastUpdateBy"].Visible = false;
            empDGV.Columns["Address"].Visible = false;
            empDGV.Columns["Address2"].Visible = false;
            empDGV.Columns["City"].Visible = false;
            empDGV.Columns["PostalCode"].Visible = false;
            empDGV.Columns["Country"].Visible = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var reports = new Reports(_imsConnection);
            reports.ShowDialog();
            Show();
        }

        private void AddEmpBtn_Click(object sender, EventArgs e)
        {
            Hide();
            var employeeForm = new Employee(_imsConnection);
            employeeForm.ShowDialog();
            Show();
            RefreshViews();
        }

        private void ModifyEmpBtn_Click(object sender, EventArgs e)
        {
            if (empDGV.SelectedRows.Count > 0)
            {
                Hide();
                var employeeForm = new Employee(_imsConnection, empDGV.SelectedRows[0]);
                employeeForm.ShowDialog();
                Show();
                RefreshViews();
            } else
            {
                MessageBox.Show("Can not modify. No employee selected.", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void AddInvBtn_Click(object sender, EventArgs e)
        {
            if (employees.Count == 0)
            {
                MessageBox.Show("You may not add an invoice if no employees have been added. Add an employee first before attempting to add an invoice.", "Error", MessageBoxButtons.OK);
            } else
            {
                Hide();
                var invoiceForm = new Invoice(_imsConnection);
                invoiceForm.ShowDialog();
                Show();
                RefreshViews();
            }
        }

        private void ModifyInvBtn_Click(object sender, EventArgs e)
        {
            if (invDGV.SelectedRows.Count > 0)
            {
                Hide();
                var invoiceForm = new Invoice(_imsConnection, invDGV.SelectedRows[0]);
                invoiceForm.ShowDialog();
                Show();
                RefreshViews();
            } else
            {
                MessageBox.Show("Can not modify. No invoice selected.", "Error", MessageBoxButtons.OK);
            }
        }

        private void DeleteEmpBtn_Click(object sender, EventArgs e)
        {
            if (empDGV.SelectedRows.Count > 0)
            {
                var response = MessageBox.Show($"Are you sure you want to delete the following employee: Name: {empDGV.SelectedRows[0].Cells["Name"].Value}?", "Confirmation", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    _imsConnection.DeleteEmployee(empDGV.SelectedRows[0].Cells["ID"].Value.ToString());
                    RefreshViews();
                }
            } else
            {
                MessageBox.Show("Can not delete. No employee selected.", "Error", MessageBoxButtons.OK);
            }
        }

        private void RefreshViews() {
            employees = _imsConnection.AllEmployees();
            invoices = _imsConnection.AllInvoices();
            empDGV.DataSource = employees;
            invDGV.DataSource = invoices;
        }

        private void DeleteInvBtn_Click(object sender, EventArgs e)
        {
            if (invDGV.SelectedRows.Count > 0)
            {
                var response = MessageBox.Show($"Are you sure you want to delete the following invoice: ID: {invDGV.SelectedRows[0].Cells["ID"].Value}?", "Confirmation", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    _imsConnection.DeleteInvoice(invDGV.SelectedRows[0].Cells["ID"].Value.ToString());
                    RefreshViews();
                }
            }
            else
            {
                MessageBox.Show("Can not delete. No invoice selected.", "Error", MessageBoxButtons.OK);
            }
        }

        private void SearchEmpTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SearchEmpTxtBox.Text)) {
                SearchEmpBtn.Enabled = true;
            } else
            {
                SearchEmpBtn.Enabled = false;
            }
        }

        private void InvSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(InvSearchTxtBox.Text)) {
                SearchInvBtn.Enabled = true;
            }
            else
            {
                SearchInvBtn.Enabled = false;
            }
        }

        public void Search(string empOrInv)
        {
            if (empOrInv == "employee")
            {
                var TempEmpList = new BindingList<DGVEmployee>();
                bool foundEmp = false;
                if (!string.IsNullOrWhiteSpace(SearchEmpTxtBox.Text))
                {
                    for (int index = 0; index < employees.Count; index++)
                    {
                        if (employees[index].Name.ToUpper().Contains(SearchEmpTxtBox.Text.ToUpper()))
                        {
                            TempEmpList.Add(employees[index]);
                            foundEmp = true;
                        }
                    }
                    if (foundEmp)
                    {
                        empDGV.DataSource = TempEmpList;
                    }
                    else
                    {
                        MessageBox.Show($"Employee with name: {SearchEmpTxtBox.Text} not found.");
                        empDGV.DataSource = employees;
                    }
                }
                else
                {
                    MessageBox.Show("You must enter in a Employee name you'd like to search by.");
                    empDGV.DataSource = employees;
                }
            }
            else
            {
                var TempInvList = new BindingList<DGVInvoice>();
                bool foundInv = false;
                if (!string.IsNullOrWhiteSpace(InvSearchTxtBox.Text))
                {
                    for (int index = 0; index < invoices.Count; index++)
                    {
                        if (invoices[index].Description.ToUpper().Contains(InvSearchTxtBox.Text.ToUpper()))
                        {
                            TempInvList.Add(invoices[index]);
                            foundInv = true;
                        }
                    }
                    if (foundInv)
                    {
                        invDGV.DataSource = TempInvList;
                    }
                    else
                    {
                        MessageBox.Show($"Invoices with description: {InvSearchTxtBox.Text} not found.");
                        invDGV.DataSource = invoices;
                    }
                }
                else
                {
                    MessageBox.Show("You must enter in an Invoice Description you'd like to search by.");
                    invDGV.DataSource = invoices;
                }
            }
        }

        private void SearchInvBtn_Click(object sender, EventArgs e)
        {
            Search("invoice");
            return;
        }

        private void SearchEmpBtn_Click(object sender, EventArgs e)
        {
            Search("employee");
            return;
        }
    }
}

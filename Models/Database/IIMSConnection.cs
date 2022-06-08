using System.ComponentModel;
using System.Resources;
using InvoiceManagementSystem.Models.Dashboard;
using InvoiceManagementSystem.Models.Entities;

namespace InvoiceManagementSystem.Models.Database
{
    public interface IIMSConnection
    {
        BindingList<DGVInvoice> Invoices { get; set; }
        BindingList<DGVEmployee> Employees { get; set; }
        BindingList<User> Users { get; set; }
        User CurrentUser { get; set; }
        void ModifyEmployee(DGVEmployee employee);
        void CreateEmployee(DGVEmployee employee);
        void DeleteEmployee(string ID);
        DGVEmployee GetEmployee(string ID);
        BindingList<DGVEmployee> AllEmployees();
        void DeleteInvoice(string ID);
        BindingList<DGVInvoice> AllInvoices();
        void CreateInvoice(DGVInvoice invoice);
        void ModifyInvoice(DGVInvoice invoice);
        DGVInvoice GetInvoice(string ID);
        void SetCurrentUser(string username);
        BindingList<User> GetAllUsers();
        bool AttemptLogin(ResourceManager rm, string usernameTxtBox, string passwordTxtBox);
    }
}

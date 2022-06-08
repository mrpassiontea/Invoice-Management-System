using System;
using System.Windows.Forms;
using InvoiceManagementSystem.Models.Database;
using InvoiceManagementSystem.Views;

namespace InvoiceManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(new IMSConnection()));
        }
    }
}

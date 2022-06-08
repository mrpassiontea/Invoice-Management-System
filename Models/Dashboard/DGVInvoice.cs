using InvoiceManagementSystem.Models.Entities;

namespace InvoiceManagementSystem.Models.Dashboard
{
    public class DGVInvoice : Invoice
    {
        public int ID { get; set; }
        public int EmployeeId { get; set; }
        public int UserId { get; set; }
    }
}

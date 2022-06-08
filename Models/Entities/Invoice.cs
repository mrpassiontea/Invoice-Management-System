using System;

namespace InvoiceManagementSystem.Models.Entities
{
    public class Invoice
    {
        public string Description { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public string TotalAmountDue { get; set; }
        public string HoursWorked { get; set; }
        public string PricePerHour { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}

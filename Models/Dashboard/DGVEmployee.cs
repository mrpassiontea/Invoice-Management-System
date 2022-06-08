﻿using InvoiceManagementSystem.Models.Entities;

namespace InvoiceManagementSystem.Models.Dashboard
{
    public class DGVEmployee : Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

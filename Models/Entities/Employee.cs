using System;

namespace InvoiceManagementSystem.Models.Entities
{
    public class Employee
    {
        public string EmployeeType { get; set; }
        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}

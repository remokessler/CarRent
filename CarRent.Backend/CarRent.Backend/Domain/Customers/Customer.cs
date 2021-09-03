using System;

namespace CarRent.Backend.Domain.Customers
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }
}

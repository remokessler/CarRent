using System;

namespace CarRent.Backend.Domain.Customers
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public Adress Adress { get; set; }
    }
}

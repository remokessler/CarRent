using System;
using System.Collections.Generic;

namespace CarRent.Backend.Domain.Customers
{
    public interface ICustomerRepository
    {
        public Customer Get(Guid id);
        public IEnumerable<Customer> GetAll();
        public Customer Create(string name, string firstname, string city, string street, string zipCode);

    }
}

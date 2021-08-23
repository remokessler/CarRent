using CarRent.Backend.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Backend.Infrastructure.Persistance
{
    public class CustomerRepository : ICustomerRepository
    {
        private CarRentDbContext carRentDbContext { get; }
        public CustomerRepository(CarRentDbContext dbContext)
        {
            carRentDbContext = dbContext;
        }
        public Customer Create(string name, string firstname, string city, string street, string zipCode)
        {
            if (name == null || firstname == null || city == null || street == null || zipCode == null)
                throw new NullReferenceException("some of the arguments where null!");

            Customer newCustomer = new Customer()
            {
                Name = name,
                Firstname = firstname,
                Adress = new Adress()
                {
                    City = city,
                    Street = street,
                    ZipCode = zipCode
                }
            };

            return carRentDbContext.Customers.Add(newCustomer).Entity;
        }

        public Customer Get(Guid id)
        {
            return carRentDbContext.Customers.First(c => c.Id == id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return carRentDbContext.Customers;
        }
    }
}

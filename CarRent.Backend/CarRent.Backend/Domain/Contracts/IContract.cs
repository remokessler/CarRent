using CarRent.Backend.Domain.Cars;
using CarRent.Backend.Domain.Customers;
using System;

namespace CarRent.Backend.Domain.Contracts
{
    public interface IContract
    {
        public Guid Id { get; }
        public Customer Customer { get; }
        public DateTimeOffset StartDate { get; }
        public DateTimeOffset EndDate { get; }
        public decimal TotalAmount { get; }
    }
}

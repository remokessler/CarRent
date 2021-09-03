using CarRent.Backend.Domain.Cars;
using CarRent.Backend.Domain.Customers;
using System;

namespace CarRent.Backend.Domain.Contracts
{
    public class RentContract : IContract
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public decimal TotalAmount => decimal.Parse(EndDate.Subtract(StartDate).Days.ToString()) * Car.CarClass.CostPerDay;
    }
}

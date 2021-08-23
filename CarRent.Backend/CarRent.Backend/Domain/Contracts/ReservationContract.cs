using CarRent.Backend.Domain.Cars;
using CarRent.Backend.Domain.Customers;
using System;

namespace CarRent.Backend.Domain.Contracts
{
    public class ReservationContract
    {
        public Guid Id { get; set; }
        public Customer Customer { get; private set; }
        public CarClass CarClass { get; private set; }
        public DateTimeOffset StartDate { get; private set; }
        public DateTimeOffset EndDate { get; private set; }

        public decimal TotalAmount { get; private set; }

        public ReservationContract(Customer customer, CarClass carClass, DateTimeOffset startDate, DateTimeOffset endDate)
        {
            Customer = customer;
            CarClass = carClass; 
            StartDate = startDate;
            EndDate = endDate;
            TotalAmount = decimal.Parse(EndDate.Subtract(StartDate).Days.ToString()) * CarClass.CostPerDay;

        }
    }
}

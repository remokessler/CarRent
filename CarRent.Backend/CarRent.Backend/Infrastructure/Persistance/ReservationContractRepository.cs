using CarRent.Backend.Domain.Cars;
using CarRent.Backend.Domain.Contracts;
using CarRent.Backend.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Backend.Infrastructure.Persistance
{
    public class ReservationContractRepository : IReservationContractRepository
    {
        private CarRentDbContext carRentDbContext { get; }

        public ReservationContractRepository(CarRentDbContext dbContext)
        {
            carRentDbContext = dbContext;
        }

        public ReservationContract Create(Guid customerId, string carClassName, DateTimeOffset startDate, DateTimeOffset endDate)
        {
            if (customerId == default(Guid) || string.IsNullOrWhiteSpace(carClassName) || startDate == default(DateTimeOffset) || endDate == default(DateTimeOffset))
                throw new NullReferenceException("What a pitty... it seams someone has eaten all the cookies and so none where found!");

            if ((endDate - startDate).TotalSeconds < 0)
                throw new ArgumentException("Although the end is near, it cannot be nearer then the start!");

            Customer customer = carRentDbContext.Customers.First(c => c.Id == customerId);
            CarClass carClass = carRentDbContext.CarClass.First(c => c.Name == carClassName);

            ReservationContract contract = new ReservationContract(customer, carClass, startDate, endDate);

            carRentDbContext.ReservationContracts.Add(contract);
            carRentDbContext.SaveChanges();
            return contract;
        }

        public ReservationContract Get(Guid id)
        {
            return carRentDbContext.ReservationContracts.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<ReservationContract> GetAll()
        {
            return carRentDbContext.ReservationContracts.ToList();
        }

        public void Delete(Guid id)
        {
            var reservationContract = Get(id);
            carRentDbContext.ReservationContracts.Remove(reservationContract);
            carRentDbContext.SaveChanges();
        }
    }
}

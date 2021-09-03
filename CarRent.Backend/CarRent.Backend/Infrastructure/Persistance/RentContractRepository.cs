using CarRent.Backend.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Backend.Infrastructure.Persistance
{
    public class RentContractRepository : IRentContractRepository
    {
        private CarRentDbContext carRentDbContext { get; }

        public RentContractRepository(CarRentDbContext dbContext)
        {
            carRentDbContext = dbContext;
        }

        public RentContract Create(Guid reservationContractGuid)
        {
            var reservation = carRentDbContext.ReservationContracts
                .Include(c => c.Customer)
                .Include(c => c.CarClass)
                .First(c => c.Id == reservationContractGuid);

            var excludedCar = carRentDbContext.RentContracts
                .Include(c => c.Car)
                .Where(c => c.EndDate > DateTimeOffset.Now && c.StartDate < DateTimeOffset.Now)
                .Select(c => c.Car.Id)
                .ToArray();
            var car = carRentDbContext.Cars.First(c => !excludedCar.Any(e => e == c.Id));

            var rent = new RentContract()
            {
                Id = reservation.Id,
                Customer = reservation.Customer,
                EndDate = reservation.EndDate,
                StartDate = reservation.StartDate,
                Car = car
            };
            carRentDbContext.RentContracts.Add(rent);
            carRentDbContext.ReservationContracts.Remove(reservation);
            carRentDbContext.SaveChanges();
            return rent;
        }

        public RentContract Get(Guid id)
        {
            return carRentDbContext.RentContracts.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<RentContract> GetAll()
        {
            return carRentDbContext.RentContracts.ToList();
        }

        public void Delete(Guid id)
        {
            var rentContract = Get(id);
            carRentDbContext.RentContracts.Remove(rentContract);
            carRentDbContext.SaveChanges();
        }
    }
}

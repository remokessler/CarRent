using CarRent.Backend.Domain.Cars;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Backend.Infrastructure.Persistance
{
    public class CarRepository : ICarRepository
    {
        private CarRentDbContext carRentDbContext { get; }

        public CarRepository(CarRentDbContext dbContext)
        {
            carRentDbContext = dbContext;
        }

        public Car Create(string brand, string type, string carClass)
        {
            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(carClass))
                throw new NullReferenceException("CarRepository.Create: brand, type and car-class cannot be empty or null");

            Brand dbBrand = GetBrand(brand);
            var dbCarClass = carRentDbContext.CarClass.First(c => c.Name == carClass);
            var car = new Car()
            {
                Id = Guid.NewGuid(),
                Brand = dbBrand,
                Type = type,
                CarClass = dbCarClass
            };
            carRentDbContext.Cars.Add(car);
            carRentDbContext.SaveChanges();
            return car;
        }

        private Brand GetBrand(string brand)
        {
            Brand dbBrand = carRentDbContext.Brands.FirstOrDefault(b => b.Name == brand);
            if (dbBrand == null)
            {
                dbBrand = CreateNewBrand(brand);
            }
            return dbBrand;
        }

        private Brand CreateNewBrand(string brand)
        {
            Brand dbBrand = new Brand(brand);
            carRentDbContext.Brands.Add(dbBrand);
            return dbBrand;
        }

        public Car Get(Guid id)
        {
            return carRentDbContext.Cars.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Car> GetAll()
        {
            return carRentDbContext.Cars.ToList();
        }

        public void Delete(Guid id)
        {
            var car = Get(id);
            carRentDbContext.Cars.Remove(car);
            carRentDbContext.SaveChanges();
        }
    }
}

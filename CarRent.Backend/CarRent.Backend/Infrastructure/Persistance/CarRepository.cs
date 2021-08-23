using CarRent.Backend.Domain.Cars;
using System;
using System.Collections.Generic;

namespace CarRent.Backend.Infrastructure.Persistance
{
    public class CarRepository : ICarRepository
    {
        public CarRepository()
        {

        }

        public Car Create(string brand, string typ, string carClass)
        {
            throw new NotImplementedException();
        }

        public Car Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

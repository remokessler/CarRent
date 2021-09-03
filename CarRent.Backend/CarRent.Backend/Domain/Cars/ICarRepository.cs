using System;
using System.Collections.Generic;

namespace CarRent.Backend.Domain.Cars
{
    public interface ICarRepository
    {
        public Car Get(Guid id);
        public IEnumerable<Car> GetAll();
        public Car Create(string brand, string type, string carClass);

    }
}

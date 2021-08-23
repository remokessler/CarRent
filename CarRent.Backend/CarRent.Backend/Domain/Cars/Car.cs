using System;

namespace CarRent.Backend.Domain.Cars
{
    public class Car
    {
        public CarClass CarClass { get; set; }
        public Brand Brand { get; set; }
        public string Type { get; set; }
        public Guid Id { get; set; }
    }
}

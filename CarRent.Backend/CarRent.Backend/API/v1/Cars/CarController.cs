using CarRent.Backend.Domain.Cars;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Backend.API.v1.Cars
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> logger;
        private readonly ICarRepository carRepository;

        public CarController(ILogger<CarController> logger, ICarRepository carRepository)
        {
            this.logger = logger;
            this.carRepository = carRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(Guid id)
        {
            return carRepository.Get(id);
        }

        [HttpPost]
        public ActionResult<Car> CreateCar(CarPostDTO dto)
        {
            return carRepository.Create(dto.Brand, dto.Type, dto.CarClass);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            return carRepository.GetAll().ToList();
        }
    }
}

using CarRent.Backend.Domain.Contracts;
using CarRent.Backend.Domain.Customers;
using CarRent.Backend.Infrastructure.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRent.Backend.API.v1.Contracts
{
    [ApiController]
    [Route("[controller]")]
    public class RentContractController : ControllerBase
    {
        private readonly ILogger<RentContractController> logger;
        private readonly IRentContractRepository rentContractRepository;

        public RentContractController(ILogger<RentContractController> logger, IRentContractRepository rentContractRepository)
        {
            this.logger = logger;
            this.rentContractRepository = rentContractRepository;
        }

        [HttpGet("/{id}")]
        public ActionResult<RentContract> GetById(Guid id)
        {
            return rentContractRepository.Get(id);
        }

        [HttpPost]
        public ActionResult<RentContract> Create(Guid reservationGuid)
        {
            return rentContractRepository.Create(reservationGuid);
        }

        [HttpGet]
        public ActionResult<IEnumerable<RentContract>> GetAll()
        {
            return rentContractRepository.GetAll().ToList();
        }
    }
}

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
    [Route("[controller]/v1")]
    public class RentContractController : ControllerBase
    {
        private readonly ILogger<RentContractController> logger;
        private readonly IRentContractRepository rentContractRepository;

        public RentContractController(ILogger<RentContractController> logger, IRentContractRepository rentContractRepository)
        {
            this.logger = logger;
            this.rentContractRepository = rentContractRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<RentContract> GetRentContractById(Guid id)
        {
            return rentContractRepository.Get(id);
        }

        [HttpPost]
        public ActionResult<RentContract> CreateRentContract(Guid reservationGuid)
        {
            return rentContractRepository.Create(reservationGuid);
        }

        [HttpGet]
        public ActionResult<IEnumerable<RentContract>> GetAllRentContractsW()
        {
            return rentContractRepository.GetAll().ToList();
        }

        [HttpDelete("{id}")]
        public void DeleteRentContract(Guid id)
        {
            rentContractRepository.Delete(id);
        }
    }
}

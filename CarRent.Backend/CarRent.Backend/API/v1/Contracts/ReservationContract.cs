
using CarRent.Backend.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarReservation.Backend.API.v1.Contracts
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationContractController : ControllerBase
    {
        private readonly ILogger<ReservationContractController> logger;
        private readonly IReservationContractRepository reservationContractRepository;

        public ReservationContractController(ILogger<ReservationContractController> logger, IReservationContractRepository reservationContractRepository)
        {
            this.logger = logger;
            this.reservationContractRepository = reservationContractRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<ReservationContract> GetReservationContractById(Guid id)
        {
            return reservationContractRepository.Get(id);
        }

        [HttpPost]
        public ActionResult<ReservationContract> CreateReservationContract(ReservationDTO reservationDTO)
        {
            return reservationContractRepository.Create(reservationDTO.CustomerId, reservationDTO.CarClassName, reservationDTO.StartDate, reservationDTO.EndDate);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReservationContract>> GetAllReservationContract()
        {
            return reservationContractRepository.GetAll().ToList();
        }
    }
}

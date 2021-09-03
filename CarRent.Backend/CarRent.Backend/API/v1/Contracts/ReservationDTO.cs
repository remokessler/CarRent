using System;

namespace CarReservation.Backend.API.v1.Contracts
{
    public class ReservationDTO
    {
        public Guid CustomerId { get; set; }
        public string CarClassName { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
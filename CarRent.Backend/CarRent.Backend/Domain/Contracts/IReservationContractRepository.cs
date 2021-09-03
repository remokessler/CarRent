using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Backend.Domain.Contracts
{
    public interface IReservationContractRepository
    {
        public ReservationContract Create(Guid customerId, string carClassName, DateTimeOffset startDate, DateTimeOffset endDate);
        public ReservationContract Get(Guid id);
        public IEnumerable<ReservationContract> GetAll();
        public void Delete(Guid id);
    }
}

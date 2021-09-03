using System;
using System.Collections.Generic;

namespace CarRent.Backend.Domain.Contracts
{
    public interface IRentContractRepository
    {
        public RentContract Create(Guid reservationContractGuid);
        public RentContract Get(Guid id);
        public IEnumerable<RentContract> GetAll();
        public void Delete(Guid id);
    }
}

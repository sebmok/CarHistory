using System.Collections.Generic;
using Entities;

namespace Services
{
    public interface ICarOwnerService
    {
        IEnumerable<CarOwner> GetOwners();
    }
}
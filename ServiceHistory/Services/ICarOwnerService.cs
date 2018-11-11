using Entities.Models;
using System.Collections.Generic;


namespace Services
{
    public interface ICarOwnerService
    {
        IEnumerable<CarOwner> GetOwners();
    }
}
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CarOwnerService : ICarOwnerService
    {
        private IEnumerable<CarOwner> CarOwners = new List<CarOwner>();

        public IEnumerable<CarOwner> GetOwners()
        {
            return CarOwners;
        }

    }
}

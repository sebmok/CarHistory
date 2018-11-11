
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class CarOwnerService : ICarOwnerService
    {
        SHistoryContext db = new SHistoryContext();        
     
        public IEnumerable<CarOwner> GetOwners()
        {
            return db.CarOwner.ToList();

           
        }

    }
}

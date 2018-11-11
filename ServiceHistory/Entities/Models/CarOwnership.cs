using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CarOwnership
    {
        public long Id { get; set; }
        public int OwnerId { get; set; }
        public string Vin { get; set; }
        public DateTime InsDate { get; set; }
        public DateTime OwnerFrom { get; set; }
        public DateTime? OwnerTo { get; set; }
        public decimal? Price { get; set; }
        public int? UpdatedOdometer { get; set; }

        public CarOwner Owner { get; set; }
        public Vin VinNavigation { get; set; }
    }
}

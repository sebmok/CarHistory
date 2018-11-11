using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CarHistory
    {
        public int Id { get; set; }
        public int LastOwnerId { get; set; }
        public string Vin { get; set; }
        public DateTime OwnerFrom { get; set; }
        public DateTime OwnerTo { get; set; }
        public bool? IsSold { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? SPrice { get; set; }
        public string LastLicencePlate { get; set; }
        public int? LastOdometer { get; set; }

        public Vin VinNavigation { get; set; }
    }
}

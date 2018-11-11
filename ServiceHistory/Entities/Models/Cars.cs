using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Cars
    {
        public Cars()
        {
            ServiceHistory = new HashSet<ServiceHistory>();
        }

        public long Id { get; set; }
        public string Vin { get; set; }
        public string LicencePlate { get; set; }
        public string Color { get; set; }
        public int StartOdometer { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime? FirstRegistration { get; set; }
        public DateTime? ProductionDate { get; set; }
        public decimal? PowerKm { get; set; }
        public decimal? PowerKw { get; set; }
        public int? SeatsNo { get; set; }
        public short? CarTypeId { get; set; }

        public Brands BrandNavigation { get; set; }
        public CarType CarType { get; set; }
        public Colours ColorNavigation { get; set; }
        public ICollection<ServiceHistory> ServiceHistory { get; set; }
    }
}

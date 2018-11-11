using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ServiceHistory
    {
        public ServiceHistory()
        {
            ServiceHistoryService = new HashSet<ServiceHistoryService>();
        }

        public int Id { get; set; }
        public long CarId { get; set; }
        public string LicencePlate { get; set; }
        public int Odometer { get; set; }
        public DateTime InsDate { get; set; }
        public string Description { get; set; }
        public int ServiceStationId { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string Vin { get; set; }

        public Cars Car { get; set; }
        public ServiceStations ServiceStation { get; set; }
        public ICollection<ServiceHistoryService> ServiceHistoryService { get; set; }
    }
}

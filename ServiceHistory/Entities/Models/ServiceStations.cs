using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ServiceStations
    {
        public ServiceStations()
        {
            ServiceHistory = new HashSet<ServiceHistory>();
        }

        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNo { get; set; }
        public string ServiceName { get; set; }
        public DateTime? InsDate { get; set; }
        public int RegistrationId { get; set; }
        public string RegistrationNo { get; set; }
        public string PhoneNo { get; set; }
        public string MobilePhoneNo { get; set; }

        public Countries CountryNavigation { get; set; }
        public RegistrationDictionary Registration { get; set; }
        public ICollection<ServiceHistory> ServiceHistory { get; set; }
    }
}

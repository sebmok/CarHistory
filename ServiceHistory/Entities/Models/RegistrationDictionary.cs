using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class RegistrationDictionary
    {
        public RegistrationDictionary()
        {
            ServiceStations = new HashSet<ServiceStations>();
        }

        public int Id { get; set; }
        public string RegistrationName { get; set; }
        public string Country { get; set; }

        public Countries CountryNavigation { get; set; }
        public ICollection<ServiceStations> ServiceStations { get; set; }
    }
}

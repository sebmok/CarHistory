using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Countries
    {
        public Countries()
        {
            CarOwner = new HashSet<CarOwner>();
            RegistrationDictionary = new HashSet<RegistrationDictionary>();
            ServiceStations = new HashSet<ServiceStations>();
        }

        public string Name { get; set; }
        public string PhonePreffix { get; set; }

        public ICollection<CarOwner> CarOwner { get; set; }
        public ICollection<RegistrationDictionary> RegistrationDictionary { get; set; }
        public ICollection<ServiceStations> ServiceStations { get; set; }
    }
}

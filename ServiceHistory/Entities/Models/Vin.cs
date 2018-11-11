using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Vin
    {
        public Vin()
        {
            CarHistory = new HashSet<CarHistory>();
            CarOwnership = new HashSet<CarOwnership>();
        }

        public string Vin1 { get; set; }

        public ICollection<CarHistory> CarHistory { get; set; }
        public ICollection<CarOwnership> CarOwnership { get; set; }
    }
}

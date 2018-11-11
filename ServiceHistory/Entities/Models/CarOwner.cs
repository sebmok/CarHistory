using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CarOwner
    {
        public CarOwner()
        {
            CarOwnership = new HashSet<CarOwnership>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }
        public string Country { get; set; }
        public DateTime? InsDate { get; set; }
        public DateTime? UpdDate { get; set; }

        public Countries CountryNavigation { get; set; }
        public ICollection<CarOwnership> CarOwnership { get; set; }
    }
}

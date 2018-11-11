using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Brands
    {
        public Brands()
        {
            Cars = new HashSet<Cars>();
        }

        public string Name { get; set; }

        public ICollection<Cars> Cars { get; set; }
    }
}

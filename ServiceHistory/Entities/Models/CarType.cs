using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CarType
    {
        public CarType()
        {
            Cars = new HashSet<Cars>();
        }

        public short Id { get; set; }
        public string Name { get; set; }

        public ICollection<Cars> Cars { get; set; }
    }
}

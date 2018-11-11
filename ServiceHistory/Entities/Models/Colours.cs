using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Colours
    {
        public Colours()
        {
            Cars = new HashSet<Cars>();
        }

        public string Name { get; set; }

        public ICollection<Cars> Cars { get; set; }
    }
}

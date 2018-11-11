using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ServiceDictionary
    {
        public ServiceDictionary()
        {
            ServiceHistoryService = new HashSet<ServiceHistoryService>();
        }

        public short Id { get; set; }
        public string Name { get; set; }
        public short SortOrder { get; set; }

        public ICollection<ServiceHistoryService> ServiceHistoryService { get; set; }
    }
}

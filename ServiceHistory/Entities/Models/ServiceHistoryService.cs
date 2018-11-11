using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ServiceHistoryService
    {
        public int Id { get; set; }
        public short ServiceDictionaryId { get; set; }
        public int ServieHistoryId { get; set; }
        public string Comment { get; set; }
        public DateTime? InsDate { get; set; }

        public ServiceDictionary ServiceDictionary { get; set; }
        public ServiceHistory ServieHistory { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceHistory()
        {
            this.ServiceHistoryService = new HashSet<ServiceHistoryService>();
        }
    
        public int Id { get; set; }
        public long CarId { get; set; }
        public string LicencePlate { get; set; }
        public int Odometer { get; set; }
        public System.DateTime InsDate { get; set; }
        public string Description { get; set; }
        public int PlaceId { get; set; }
        public Nullable<System.DateTime> ServiceDate { get; set; }
    
        public virtual Cars Cars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceHistoryService> ServiceHistoryService { get; set; }
    }
}

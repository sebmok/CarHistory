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
    
    public partial class Cars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cars()
        {
            this.ServiceHistory = new HashSet<ServiceHistory>();
        }
    
        public long Id { get; set; }
        public string VIN { get; set; }
        public string LicencePlate { get; set; }
        public int OwnerId { get; set; }
        public string Color { get; set; }
        public int CurrentOdometer { get; set; }
    
        public virtual Colours Colours { get; set; }
        public virtual VIN VIN1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceHistory> ServiceHistory { get; set; }
    }
}

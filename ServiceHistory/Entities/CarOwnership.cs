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
    
    public partial class CarOwnership
    {
        public long Id { get; set; }
        public long CarId { get; set; }
        public int OwnerId { get; set; }
        public string VIN { get; set; }
        public System.DateTime insDate { get; set; }
        public System.DateTime OwnerFrom { get; set; }
        public Nullable<System.DateTime> OwnerTo { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual CarOwner CarOwner { get; set; }
        public virtual VIN VIN1 { get; set; }
    }
}

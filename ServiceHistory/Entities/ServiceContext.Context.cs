﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ServiceHistoryContext : DbContext
    {
        public ServiceHistoryContext()
            : base("name=ServiceHistoryContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarOwner> CarOwner { get; set; }
        public virtual DbSet<CarOwnership> CarOwnership { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Colours> Colours { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<RegistrationDictionary> RegistrationDictionary { get; set; }
        public virtual DbSet<ServiceDictionary> ServiceDictionary { get; set; }
        public virtual DbSet<ServiceHistory> ServiceHistory { get; set; }
        public virtual DbSet<ServiceHistoryService> ServiceHistoryService { get; set; }
        public virtual DbSet<ServiceStations> ServiceStations { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<VIN> VIN { get; set; }
    }
}

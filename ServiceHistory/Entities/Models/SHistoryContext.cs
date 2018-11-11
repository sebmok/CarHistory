using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Entities.Models
{
    public partial class SHistoryContext : DbContext
    {
        public SHistoryContext()
        {
        }

        public SHistoryContext(DbContextOptions<SHistoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<CarHistory> CarHistory { get; set; }
        public virtual DbSet<CarOwner> CarOwner { get; set; }
        public virtual DbSet<CarOwnership> CarOwnership { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<CarType> CarType { get; set; }
        public virtual DbSet<Colours> Colours { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<RegistrationDictionary> RegistrationDictionary { get; set; }
        public virtual DbSet<ServiceDictionary> ServiceDictionary { get; set; }
        public virtual DbSet<ServiceHistory> ServiceHistory { get; set; }
        public virtual DbSet<ServiceHistoryService> ServiceHistoryService { get; set; }
        public virtual DbSet<ServiceStations> ServiceStations { get; set; }
        public virtual DbSet<Vin> Vin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-B2A4V9D\\SQLEXPRESS;Initial Catalog=SHistory;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<CarHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LastLicencePlate).HasMaxLength(15);

                entity.Property(e => e.OwnerFrom).HasColumnType("datetime");

                entity.Property(e => e.OwnerTo).HasColumnType("datetime");

                entity.Property(e => e.SPrice).HasColumnName("sPrice");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(17);

                entity.HasOne(d => d.VinNavigation)
                    .WithMany(p => p.CarHistory)
                    .HasForeignKey(d => d.Vin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarHistory_VIN");
            });

            modelBuilder.Entity<CarOwner>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnName("insDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(25);

                entity.Property(e => e.Surname).HasMaxLength(100);

                entity.Property(e => e.UpdDate)
                    .HasColumnName("updDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.CarOwner)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_CarOwner_Countries1");
            });

            modelBuilder.Entity<CarOwnership>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InsDate)
                    .HasColumnName("insDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OwnerFrom).HasColumnType("datetime");

                entity.Property(e => e.OwnerTo).HasColumnType("datetime");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(17);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.CarOwnership)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarOwnership_CarOwner");

                entity.HasOne(d => d.VinNavigation)
                    .WithMany(p => p.CarOwnership)
                    .HasForeignKey(d => d.Vin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarOwnership_VIN");
            });

            modelBuilder.Entity<Cars>(entity =>
            {
                entity.HasIndex(e => e.Vin)
                    .HasName("UniqueVIN")
                    .IsUnique();

                entity.Property(e => e.Brand).HasMaxLength(45);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FirstRegistration).HasColumnType("datetime");

                entity.Property(e => e.LicencePlate).HasMaxLength(15);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.PowerKm)
                    .HasColumnName("PowerKM")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PowerKw)
                    .HasColumnName("PowerKW")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ProductionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(17);

                entity.HasOne(d => d.BrandNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.Brand)
                    .HasConstraintName("FK_Cars_Brands");

                entity.HasOne(d => d.CarType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarTypeId)
                    .HasConstraintName("FK_Cars_CarType");

                entity.HasOne(d => d.ColorNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.Color)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Colours");
            });

            modelBuilder.Entity<CarType>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Colours>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.PhonePreffix).HasMaxLength(5);
            });

            modelBuilder.Entity<RegistrationDictionary>(entity =>
            {
                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RegistrationName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.RegistrationDictionary)
                    .HasForeignKey(d => d.Country)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationDictionary_Countries");
            });

            modelBuilder.Entity<ServiceDictionary>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ServiceHistory>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.InsDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LicencePlate).HasMaxLength(15);

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasMaxLength(17);

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.ServiceHistory)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceHistory_Cars");

                entity.HasOne(d => d.ServiceStation)
                    .WithMany(p => p.ServiceHistory)
                    .HasForeignKey(d => d.ServiceStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceHistory_ServiceStations");
            });

            modelBuilder.Entity<ServiceHistoryService>(entity =>
            {
                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.InsDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceDictionary)
                    .WithMany(p => p.ServiceHistoryService)
                    .HasForeignKey(d => d.ServiceDictionaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceHistoryService_ServiceDictionary");

                entity.HasOne(d => d.ServieHistory)
                    .WithMany(p => p.ServiceHistoryService)
                    .HasForeignKey(d => d.ServieHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceHistoryService_ServiceHistory");
            });

            modelBuilder.Entity<ServiceStations>(entity =>
            {
                entity.Property(e => e.BuildingNo).HasMaxLength(10);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.InsDate)
                    .HasColumnName("insDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobilePhoneNo).HasMaxLength(20);

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.RegistrationNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceName).HasMaxLength(155);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.ServiceStations)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_ServiceStations_Countries");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.ServiceStations)
                    .HasForeignKey(d => d.RegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceStations_RegistrationDictionary");
            });

            modelBuilder.Entity<Vin>(entity =>
            {
                entity.HasKey(e => e.Vin1);

                entity.ToTable("VIN");

                entity.Property(e => e.Vin1)
                    .HasColumnName("VIN")
                    .HasMaxLength(17)
                    .ValueGeneratedNever();
            });
        }
    }
}

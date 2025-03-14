using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AM.ApllicationCore
{
    public class AMContext:DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=MayssaBenjoudDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        //Question6/7
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1er methode
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.Entity<Traveller>().ToTable("Travellers");
            modelBuilder.Entity<Staff>().ToTable("Staffs");
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            //2eme methode
            //modelBuilder.Entity<Passenger>().OwnsOne(p => p.FullName,
            //    full => {
            //        full.Property(f => f.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
            //        full.Property(f => f.LastName).HasColumnName("PassLastName").IsRequired();
            //        });
        }

        //Question 8/9
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");

        }



    }
}

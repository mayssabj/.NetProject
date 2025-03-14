using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //Configurer la relation many-to-many entre la classe Flight et la classe Passenger
            //builder.HasMany(f => f.ListPassengers)
            //    .WithMany(p => p.Flights)
            //    .UsingEntity(j => j.ToTable("ReservationFlightPassenger"));

            ////Configurer la relation one-to-many entre la classe Flight et la classe Plane
            //builder.HasOne(p => p.MyPlane)
            //    .WithMany(f => f.ListFlights)
            //    .HasPrincipalKey(f => f.PlaneId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    
   
    }
}

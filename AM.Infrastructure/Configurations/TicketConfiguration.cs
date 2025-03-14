using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.PassengerFk, t.FlightFk });

            builder.HasOne(t => t.MyPassenger)
                .WithMany(p => p.ListTicket)
                .HasForeignKey(t => t.PassengerFk)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(t => t.MyFlight)
               .WithMany(p => p.ListTicket)
               .HasForeignKey(t => t.FlightFk)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

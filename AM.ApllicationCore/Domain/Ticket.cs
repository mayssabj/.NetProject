using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AM.ApllicationCore.Domain
{
    [PrimaryKey("FlightFk", "PassengerFk")]
    public class Ticket
    {
        public double prix { get; set; }
        public int siege { get; set; }
        public bool VIP { get; set; }
        public virtual Flight MyFlight { get; set; }
        public virtual Passenger MyPassenger { get; set; }
        [ForeignKey("MyFlight")]
        public int FlightFk { get; set; }
        [ForeignKey("MyPassenger")]
        public string PassengerFk { get; set; }
    }
}

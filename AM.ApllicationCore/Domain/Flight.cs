using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApllicationCore.Domain
{
    public class Flight
    {
        public string AirlineLogo { get; set; }
        public string? Departure { get; set; }
        public string? Destination { get; set; }
        public DateTime EffectiveArrival{ get; set; }
        public float EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        [ForeignKey("PlaneId")]
        public virtual Plane MyPlane { get; set; }
        //public ICollection<Passenger> ListPassengers { get; set; }
        public virtual ICollection<Ticket> ListTicket { get; set; }
        public override string ToString()
        {
            return "FlightId=" + this.FlightId + "Destination=" + this.Destination;
        }
    }
}

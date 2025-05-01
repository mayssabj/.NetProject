using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;

namespace AM.ApllicationCore.Interfaces
{
    public interface IServicePlane
    {
        public IList<Traveller> GetPassengers(Plane plane);
        public IList<Flight> GetFlights(int n);
        public bool IsAvailable(Flight flight, int n);
        public void DeleteOldPlanes();
        IList<Traveller> GetPassenger(Plane plane, DateTime date);
        public int GetPassengerCountByDateRange(Plane plane, DateTime startDate, DateTime endDate);
    }
}

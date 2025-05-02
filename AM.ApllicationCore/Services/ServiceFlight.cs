using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.EntityFrameworkCore;

namespace AM.ApllicationCore.Services
{
    public class ServiceFlight : Service<Flight>, IServiceFlight
    {
        private IUnitOfWork _unitOfWork ;
        public ServiceFlight(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }


        public IList<Traveller> GetPassenger(Domain.Plane plane, DateTime date)
        {
            return plane.ListFlights
                .Where(f => f.FlightDate.Date == date.Date)
                .SelectMany(f => f.ListTicket)
                .Select(t => t.MyPassenger)
                .OfType<Traveller>()
                .Distinct()
                .ToList();
        }

        public int GetPassengerCountByDateRange(Domain.Plane plane, DateTime startDate, DateTime endDate)
        {
            return plane.ListFlights
                .Where(f => f.FlightDate.Date >= startDate.Date && f.FlightDate.Date <= endDate.Date)
                .SelectMany(f => f.ListTicket)
                .Select(t => t.MyPassenger)
                .OfType<Traveller>()
                .Distinct()
                .Count();
        }

        

     

        //public IList<Staff> GetStaff(int id)
        //{
        //    var flight = GetById(id);

        //    if (flight == null || flight.ListTicket == null)
        //        return new List<Staff>();

        //    return flight.ListTicket
        //        .Select(t => t.MyPassenger)
        //        .OfType<Staff>()
        //        .Distinct()
        //        .ToList();
        //}
        //OU
        public IList<Staff> GetStaff(int flightId)
        {

            return GetById(flightId).ListTicket
                .Select(t => t.MyPassenger)
                .OfType<Staff>()
                .Distinct()
                .ToList();
        }

       
       
    }
}

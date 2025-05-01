using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;
using AM.ApllicationCore.Interfaces;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Microsoft.EntityFrameworkCore;

namespace AM.ApllicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        private IUnitOfWork _unitOfWork;
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IList<Traveller> GetPassengers(Plane plane)
        {
            return GetById(plane.PlaneId)
                .ListFlights
                .SelectMany(f => f.ListTicket)
                .Select(t => t.MyPassenger)
                .OfType<Traveller>()
                .Distinct()
                .ToList();
        }
        public IList<Flight> GetFlights(int n)
        {
            return GetAll().OrderByDescending(p => p.PlaneId)
                .Take(n)
                .SelectMany(f => f.ListFlights)
                .OrderBy(f => f.FlightDate)
                .ToList();

        }
        public bool IsAvailable(Flight flight, int n)
        {
            int capacity = flight.MyPlane.Capacity;
            int ticket = flight.ListTicket.Count;
            return n== capacity - ticket;
            
        }
        public void DeleteOldPlanes()
        {
            IList<Plane> planes = GetMany(p => (DateTime.Now.Year - p.ManufactureDate.Year) > 10).ToList();
            foreach (Plane plane in planes)
            {
                Delete(plane);
            }
        }
        public IList<Traveller> GetPassenger(Plane plane, DateTime date)
        {
            return plane.ListFlights
                .Where(f => f.FlightDate.Date == date.Date)
                .SelectMany(f => f.ListTicket)
                .Select(t => t.MyPassenger)
                .OfType<Traveller>()
                .Distinct()
                .ToList();
        }
        public int GetPassengerCountByDateRange(Plane plane, DateTime startDate, DateTime endDate)
        {
            return plane.ListFlights
                .Where(f => f.FlightDate.Date >= startDate.Date && f.FlightDate.Date <= endDate.Date) 
                .SelectMany(f => f.ListTicket)  
                .Select(t => t.MyPassenger)  
                .OfType<Traveller>()  
                .Distinct()  
                .Count();  
        }



        public void Add(Plane entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Plane entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Plane, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Plane Get(Expression<Func<Plane, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plane> GetAll()
        {
            throw new NotImplementedException();
        }

        public Plane GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plane> GetMany(Expression<Func<Plane, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Plane entity)
        {
            throw new NotImplementedException();
        }
    }
}

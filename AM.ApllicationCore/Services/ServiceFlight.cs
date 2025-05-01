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
            _unitOfWork = unitOfWork;
        }

        public void Add(Flight entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Flight entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Flight, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void DeleteOldPlanes()
        {
            throw new NotImplementedException();
        }

        public Flight Get(Expression<Func<Flight, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> GetAll()
        {
            throw new NotImplementedException();
        }

        public Flight GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> GetMany(Expression<Func<Flight, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IList<Traveller> GetPassengers(Domain.Plane plane)
        {
            throw new NotImplementedException();
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
      



        public void Update(Flight entity)
        {
            throw new NotImplementedException();
        }
       
    }
}

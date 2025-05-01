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

namespace AM.ApllicationCore.Services
{
    public class ServicePassenger : Service<Passenger>, IServicePassenger
    {
        private IUnitOfWork _unitOfWork;
        public ServicePassenger(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public void Add(Passenger entity)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(Passenger entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Passenger, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Passenger Get(Expression<Func<Passenger, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Passenger> GetAll()
        {
            throw new NotImplementedException();
        }

        public Passenger GetById(params object[] id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Passenger> GetMany(Expression<Func<Passenger, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Update(Passenger entity)
        {
            throw new NotImplementedException();
        }
    }
}

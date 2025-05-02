using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApllicationCore.Interfaces
{
    public interface IServiceFlight: IService<Flight>
    {
       IList<Staff> GetStaff(int id);
        

        IList<Traveller> GetPassenger(Plane plane, DateTime date);
        public int GetPassengerCountByDateRange(Plane plane, DateTime startDate, DateTime endDate);

    }
}

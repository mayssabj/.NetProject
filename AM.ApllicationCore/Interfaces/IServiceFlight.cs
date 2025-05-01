using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApllicationCore.Domain;

namespace AM.ApllicationCore.Interfaces
{
    public interface IServiceFlight
    {
       IList<Staff> GetStaff(int id);
       
    }
}

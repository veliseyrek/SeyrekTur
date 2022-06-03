using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Data.Abstract
{
   public interface ITicketRepository: IRepository<Ticket>
    {
        int GetCountBySeat(int routeId);
        List<int> GetSeat(int routeId);
        Ticket GetLastEntry();
        int GetId();
        string GetDate(int id);
        string GetHours(int id);
    }
}

using SeyrekTur.Data.Abstract;
using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Data.Concrete
{
    public class EfCoreTicketRepository : EfCoreGenericRepository<Ticket, TurContext>, ITicketRepository
    {
        public int GetCountBySeat(int routeId)
        {
            using (var context = new TurContext())
            {
                return context.Tickets
                    .Where(i => i.RouteId == routeId)
                    .Select(i => i.SeatNo)
                    .Count();
            }
        }

        public string GetDate(int id)
        {
            using (var context = new TurContext())
            {
                var lastticketdate = context.Routes
                    .Where(i => i.RouteId == id)
                    .Select(i => i.date)
                    .FirstOrDefault();

                return lastticketdate;
            }
        }

        public string GetHours(int id)
        {
            using (var context = new TurContext())
            {
                var lasttickethour = context.Routes
                    .Where(i => i.RouteId == id)
                    .Select(i => i.Time)
                    .FirstOrDefault();

                return lasttickethour;
            }
        }

        public int GetId()
        {
            using (var context = new TurContext())
            {
                var id = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .Select(i => i.RouteId)
                    .FirstOrDefault();
                return id;
            }
        }

        public Ticket GetLastEntry()
        {
            using (var context = new TurContext())
            {
                var lastticket = context.Tickets
                    .OrderByDescending(i => i.TicketId)
                    .FirstOrDefault();
                return lastticket;
            }
        }

        public List<int> GetSeat(int routeId)
        {
            using (var context = new TurContext())
            {
                var seat = context.Tickets
                    .Where(i => i.RouteId == routeId)
                    .Select(i => i.SeatNo)
                    .ToList();

                return seat;
            }
        }
    }
}

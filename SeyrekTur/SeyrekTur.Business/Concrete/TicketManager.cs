using SeyrekTur.Business.Abstract;
using SeyrekTur.Data.Abstract;
using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;

        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public void Create(Ticket entity)
        {
            _ticketRepository.Create(entity);
        }

        public void Delete(Ticket entity)
        {
            _ticketRepository.Delete(entity);
        }

        public List<Ticket> GetAll()
        {
            return _ticketRepository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id);
        }

        public int GetCountBySeat(int routeId)
        {
            return _ticketRepository.GetCountBySeat(routeId);
        }

        public string GetDate(int id)
        {
            return _ticketRepository.GetDate(id);
        }

        public string GetHour(int id)
        {
            return _ticketRepository.GetHours(id);
        }

        public int GetId()
        {
            return _ticketRepository.GetId();
        }

        public Ticket GetLastEntry()
        {
            return _ticketRepository.GetLastEntry();
        }

        public List<int> GetSeat(int routeId)
        {
            return _ticketRepository.GetSeat(routeId);
        }

        public void Update(Ticket entity)
        {
            _ticketRepository.Update(entity);
        }

        public void Update(Ticket entity, int[] ticketIds)
        {
            throw new NotImplementedException();
        }
    }
}

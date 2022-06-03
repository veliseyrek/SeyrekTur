using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeyrekTur.WebUI.Models
{
    public class TicketRoute
    {
        public List<Ticket> Tickets { get; set; }
        public List<Route> Routes { get; set; }
        public List<City> Cities { get; set; }
        public Route NewRoute { get; set; }
        public Ticket ticket { get; set; }
        public string hour { get; set; }
        public string date { get; set; }
    }
}

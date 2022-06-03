using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Entity
{
   public class Route
    {
        public int RouteId { get; set; }
        public string Start { get; set; }
        public string Route1 { get; set; }
        public string Route2 { get; set; }
        public string Route3 { get; set; }
        public string Finish { get; set; }
        public string date { get; set; }

        public string Time { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}

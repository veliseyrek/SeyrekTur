using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Data.Abstract
{
   public interface IRouteRepository : IRepository<Route>
    {
        string GetFrom(string from);
        string GetTo(string to);
        List<Route> GetTravel(string from, string to);
        int GetRouteByStrtFnsh(string start, string route1, string route2, string route3, string finish);
        Route GetRouteDetails(int id);
    }
}

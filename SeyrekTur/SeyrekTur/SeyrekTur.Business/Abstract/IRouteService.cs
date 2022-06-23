using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Business.Abstract
{
   public interface IRouteService
    {
        Route GetById(int id);
        List<Route> GetAll();
        void Create(Route entity);
        void Update(Route entity);
        void Delete(Route entity);

        string GetFrom(string from);
        string GetTo(string to);
        List<Route> GetTravel(string from, string to);
        int GetRouteBystrtFnsh(string start, string route1, string route2, string route3, string finish);
        Route GetRouteDetails(int id);

    }
}

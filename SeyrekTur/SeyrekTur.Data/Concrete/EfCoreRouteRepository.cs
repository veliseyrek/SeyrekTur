using Microsoft.EntityFrameworkCore;
using SeyrekTur.Data.Abstract;
using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Data.Concrete
{
    public class EfCoreRouteRepository : EfCoreGenericRepository<Route, TurContext>, IRouteRepository
    {
        public string GetFrom(string from)
        {
            using (var context = new TurContext())
            {
                var frm = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(from))
                    .Select(i => i.CityName)
                    .ToList();
                return frm[0];
            }
        }

        public int GetRouteByStrtFnsh(string start, string route1, string route2, string route3, string finish)
        {
            throw new NotImplementedException();
        }

        public Route GetRouteDetails(int id)
        {
            using (var context = new TurContext())
            {
                return context.Routes
                    .Where(i => i.RouteId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }

        public string GetTo(string to)
        {
            using (var context = new TurContext())
            {
                var t = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(to))
                    .Select(i => i.CityName)
                    .ToList();
                return t[0];
            }
        }

        public List<Route> GetTravel(string from, string to)
        {
            using (var context = new TurContext())
            {
                var frm = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(from))
                    .Select(i => i.CityName)
                    .ToList();
                var t = context.Cities
                    .Where(i => i.CityId == Convert.ToInt32(to))
                    .Select(i => i.CityName)
                    .ToList();
                var routes = context.Routes
                    .FromSqlRaw($"select * from Routes where ((Start='{frm[0]}' or route1='{t[0]}' or route2='{frm[0]}' or route3='{frm[0]}' ) and (Finish='{t[0]}' or route3='{t[0]}' or route2='{t[0]}' or route1='{t[0]}' )) ")
                    .ToList();

                return routes;

            }
        }
    }
}

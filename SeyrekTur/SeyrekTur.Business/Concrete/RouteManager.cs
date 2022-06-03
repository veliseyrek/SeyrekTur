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
    public class RouteManager : IRouteService
    {
        private IRouteRepository _routeRepository;

        public RouteManager(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }

        public void Create(Route entity)
        {
            _routeRepository.Create(entity);
        }

        public void Delete(Route entity)
        {
            _routeRepository.Delete(entity);
        }

        public List<Route> GetAll()
        {
            return _routeRepository.GetAll();
        }

        public Route GetById(int id)
        {
           return _routeRepository.GetById(id);
        }

        public string GetFrom(string from)
        {
            return _routeRepository.GetFrom(from);
        }

        public int GetRouteBystrtFnsh(string start, string route1, string route2, string route3, string finish)
        {
            return _routeRepository.GetRouteByStrtFnsh(start, route1, route2, route3, finish);
        }

        public Route GetRouteDetails(int id)
        {
            return _routeRepository.GetRouteDetails(id);
        }

        public string GetTo(string to)
        {
            return _routeRepository.GetTo(to);
        }

        public List<Route> GetTravel(string from, string to)
        {
            return _routeRepository.GetTravel(from, to);
        }

        public void Update(Route entity)
        {
            _routeRepository.Update(entity);
        }
    }
}

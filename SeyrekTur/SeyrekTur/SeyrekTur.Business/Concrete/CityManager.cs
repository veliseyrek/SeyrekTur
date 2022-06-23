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
    public class CityManager : ICityService
    {
        private ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public string cityname()
        {
            throw new NotImplementedException();
        }

        public void Create(City entity)
        {
            _cityRepository.Create(entity);
        }

        public void Delete(City entity)
        {
            _cityRepository.Delete(entity);
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            _cityRepository.Update(entity);
        }

        public void Update(City entity, int[] sehirIds)
        {
            throw new NotImplementedException();
        }
    }
}

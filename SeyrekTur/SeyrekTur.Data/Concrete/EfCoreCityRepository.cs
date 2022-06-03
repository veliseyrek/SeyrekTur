using SeyrekTur.Data.Abstract;
using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Data.Concrete
{
   public class EfCoreCityRepository : EfCoreGenericRepository<City, TurContext>, ICityRepository
    {
        public string cityname()
        {
            throw new NotImplementedException();
        }
    }
}

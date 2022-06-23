using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Data.Abstract
{
   public interface ICityRepository : IRepository<City>
    {
        string cityname();
    }
}

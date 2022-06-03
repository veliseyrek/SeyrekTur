using SeyrekTur.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyrekTur.Business.Abstract
{
    public interface IAdminService
    {
        Admin GetById(int id);
        List<Admin> GetAll();
        void Create(Admin entity);
        void Update(Admin entity);
        void Delete(Admin entity);
    }
}

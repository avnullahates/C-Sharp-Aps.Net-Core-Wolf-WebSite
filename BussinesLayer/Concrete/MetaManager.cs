using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class MetaManager : IMetaService
    {
        EfMetaDal _efMetaDal;

        public MetaManager(EfMetaDal efMetaDal)
        {
            _efMetaDal = efMetaDal;
        }

        public void TAdd(Meta t)
        {
            _efMetaDal.Insert(t);
        }

        public void TDelete(Meta t)
        {
            _efMetaDal.Delete(t);
        }

        public Meta TGetByID(int id)
        {
            return _efMetaDal.GetByID(id);
        }

        public List<Meta> TGetList()
        {
            return _efMetaDal.GetList();
        }

        public List<Meta> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Meta t)
        {
            _efMetaDal.Update(t);
        }
    }
}

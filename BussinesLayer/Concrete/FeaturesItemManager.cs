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
    public class FeaturesItemManager : IFeaturesItemService
    {
        IFeaturesItemDal _featuresItemDal;

        public FeaturesItemManager(IFeaturesItemDal featuresItemDal)
        {
            _featuresItemDal = featuresItemDal;
        }

        public void TAdd(FeaturesItem t)
        {
            _featuresItemDal.Insert(t);
        }

        public void TDelete(FeaturesItem t)
        {
            _featuresItemDal.Delete(t);
        }

        public FeaturesItem TGetByID(int id)
        {
            return _featuresItemDal.GetByID(id); ;
        }

        public List<FeaturesItem> TGetList()
        {
            return _featuresItemDal.GetList();
        }

        public List<FeaturesItem> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(FeaturesItem t)
        {
            _featuresItemDal.Update(t);
        }
    }
}

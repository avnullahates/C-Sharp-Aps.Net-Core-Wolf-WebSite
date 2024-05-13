using BussinesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class AboutUsManager : IAboutUsService
    {

        IAboutUsDal _efAboutDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _efAboutDal = aboutUsDal;
        }

        public void TAdd(AboutUs t)
        {
            _efAboutDal.Insert(t);
        }

        public void TDelete(AboutUs t)
        {
            _efAboutDal.Delete(t);
        }

        public AboutUs TGetByID(int id)
        {
            return _efAboutDal.GetByID(id);
        }

        public List<AboutUs> TGetList()
        {
            return _efAboutDal.GetList();
        }

        public List<AboutUs> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AboutUs t)
        {
            _efAboutDal.Update(t);
        }
    }
}

using BussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;

namespace BussinesLayer.Concrete
{
    public class SubAboutUsManager : ISubAboutUsService
    {
        ISubAboutUsDal _subaboutUsDal;

        public SubAboutUsManager(ISubAboutUsDal subaboutUsDal)
        {
            _subaboutUsDal = subaboutUsDal;
        }

        public void TAdd(SubAboutUs t)
        {
            _subaboutUsDal.Insert(t);
        }

        public void TDelete(SubAboutUs t)
        {
            _subaboutUsDal.Delete(t);
        }

        public SubAboutUs TGetByID(int id)
        {
            return _subaboutUsDal.GetByID(id);
        }

        public List<SubAboutUs> TGetList()
        {
            return _subaboutUsDal.GetList();
        }

        public List<SubAboutUs> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAboutUs t)
        {
            _subaboutUsDal.Update(t);
        }
    }
}

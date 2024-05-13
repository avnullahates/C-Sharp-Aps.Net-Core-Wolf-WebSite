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
    public class ReferenceManger : IReferenceService
    {
        IReferenceDal _referenceDal;

        public ReferenceManger(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public void TAdd(Reference t)
        {
            _referenceDal.Insert(t);
        }

        public void TDelete(Reference t)
        {
            _referenceDal.Delete(t);
        }

        public Reference TGetByID(int id)
        {
            return _referenceDal.GetByID(id);
        }

        public List<Reference> TGetList()
        {
            return _referenceDal.GetList();
        }

        public List<Reference> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reference t)
        {
            _referenceDal.Update(t);
        }
    }
}

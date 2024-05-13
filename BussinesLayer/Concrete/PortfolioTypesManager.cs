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
    public class PortfolioTypesManager : IPortfolioTypesService
    {
        IPortfolioTypesDal _portfolioTypesDal;

        public PortfolioTypesManager(IPortfolioTypesDal portfolioTypesDal)
        {
            _portfolioTypesDal = portfolioTypesDal;
        }

        public void TAdd(PortfolioTypes t)
        {
            _portfolioTypesDal.Insert(t);
        }

        public void TDelete(PortfolioTypes t)
        {
            _portfolioTypesDal.Delete(t);
        }

        public PortfolioTypes TGetByID(int id)
        {
            return _portfolioTypesDal.GetByID(id);
        }

        public List<PortfolioTypes> TGetList()
        {
            return _portfolioTypesDal.GetList();
        }

        public List<PortfolioTypes> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(PortfolioTypes t)
        {
            _portfolioTypesDal.Update(t);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace KorayWebsite.VıewComponents.Services
{
    public class ServicesList :ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager (new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }
    }
}

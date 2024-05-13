using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.VıewComponents.AboutUs
{
    public class AboutUsList :ViewComponent
    {

        AboutUsManager aboutUsManager = new AboutUsManager(new EfAboutUsDal());

        public IViewComponentResult Invoke()
        {
            var values = aboutUsManager.TGetList();
            return View(values);
        }
    }
}

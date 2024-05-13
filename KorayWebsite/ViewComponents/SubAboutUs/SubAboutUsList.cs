using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.VıewComponents.SubAboutUs
{
    public class SubAboutUsList :ViewComponent
    {

        SubAboutUsManager subAboutUsManager = new SubAboutUsManager(new EfSubAboutUsDal());

        public IViewComponentResult Invoke()
        {
            var values = subAboutUsManager.TGetList();
            return View(values);
        }
    }
}

using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.VıewComponents.Home
{
    public class HomeList :ViewComponent
    {
        HomeManager homeManager = new HomeManager(new EfHomeDal());

        public IViewComponentResult Invoke()
        {
            var values = homeManager.TGetList();
            return View(values);
        }
    }
}

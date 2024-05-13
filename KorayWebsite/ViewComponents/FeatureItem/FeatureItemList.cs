using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.VıewComponents.FeatureItem
{
    public class FeatureItemList : ViewComponent
    {
        FeaturesItemManager featuresItemManager = new FeaturesItemManager(new EfFeaturesItemDal());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {

            var values = featuresItemManager.TGetList();
            return View(values);
        }

    }
}

using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.VıewComponents.Meta
{
    public class MetaList :ViewComponent
    {
        MetaManager metaManager = new MetaManager(new EfMetaDal());

        public IViewComponentResult Invoke()
        {
            var values = metaManager.TGetList();
            return View(values);
        }

    }
}

using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace KorayWebsite.VıewComponents.Rerefence
{
    public class ReferenceList :ViewComponent
    {

        ReferenceManger referenceManger = new ReferenceManger(new EfReferenceDal());

        public IViewComponentResult Invoke()
        {
            var values = referenceManger.TGetList();
            return View(values);
        }
    }
}

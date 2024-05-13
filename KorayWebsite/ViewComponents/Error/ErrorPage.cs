using BussinesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.ViewComponents.Error
{
    public class ErrorPage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            return View();
        }
    }
}

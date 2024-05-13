using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace KorayWebsite.VıewComponents.Price
{
    public class PriceList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            return View();
        }

    }
}

using BussinesLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KorayWebsite.Controllers
{
    public class DefaultController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        Context c = new Context();
        ContactMessageManager contactMessageManager = new ContactMessageManager(new EfContactMessageDal());


        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }


        [Route("/services/{id}")]
        public PartialViewResult ServiceDetailList(int id)
        {
            var values = serviceManager.TGetByID(id);
            return PartialView(values);
        }

        public PartialViewResult HeaderPartialServices(int id)
        {
            var values = serviceManager.TGetByID(id);
            return PartialView();
        }

        public PartialViewResult SendMessage(ContactMessage m)
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Send(ContactMessage m)
        {
            m.Date= Convert.ToDateTime(DateTime.Now);
            m.Status = true;
            contactMessageManager.TAdd(m);
            var values = JsonConvert.SerializeObject(m);
            return Json(values);
        }
    }
}

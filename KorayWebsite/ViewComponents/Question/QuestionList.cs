using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.VıewComponents.Question
{
    public class QuestionList:ViewComponent
    {
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());

        public IViewComponentResult Invoke()
        {
            var values = questionManager.TGetList();
            return View(values);
        }
    }
}

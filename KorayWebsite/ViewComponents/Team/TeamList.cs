using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace KorayWebsite.VıewComponents.Team
{
    public class TeamList : ViewComponent
    {
        TeamManager teamManager = new TeamManager(new EfTeamDal());

        public IViewComponentResult Invoke()
        {
            var values = teamManager.TGetList();
            return View(values);
        }
    }
}

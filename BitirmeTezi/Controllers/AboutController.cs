using BusinessLayer.Concrete;
using DataAcceLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeTezi.Controllers
{
    public class AboutController : Controller
    {
        OurTeamManager Otm = new OurTeamManager(new EOurTeamRepository());
        public IActionResult Index()
        {
            var val = Otm.GetListWithStatus();
            return View(val);
        }
    }
}

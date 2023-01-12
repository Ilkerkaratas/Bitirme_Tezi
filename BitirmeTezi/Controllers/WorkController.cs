using BusinessLayer.Concrete;
using DataAcceLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;


namespace BitirmeTezi.Controllers
{
    public class WorkController : Controller
    {
        WorkManager Wm = new WorkManager(new EWorkRepository());
        public IActionResult Index()
        {
            var Val = Wm.GetListWithCategoryStatus();




            return View(Val);
        }
        public IActionResult WorkDetail(int id)
        {
            var val = Wm.GetByID(id);
            return View(val);
        }
    }
}

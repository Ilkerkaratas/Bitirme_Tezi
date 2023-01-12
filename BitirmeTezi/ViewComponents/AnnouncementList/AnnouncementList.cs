using BusinessLayer.Concrete;
using DataAcceLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeTezi.ViewComponents.AnnouncementList
{
    public class AnnouncementList:ViewComponent
    {
        AnnouncementManager Am = new AnnouncementManager(new EAnnouncementRepository());
        public IViewComponentResult Invoke()
        {
            var values = Am.GetListWithStatus();
            return View(values);
        }
    }
}

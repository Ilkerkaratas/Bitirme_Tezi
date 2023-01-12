using BusinessLayer.Concrete;
using DataAcceLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitirmeTezi.ViewComponents.OurService
{
    public class OurServiceList:ViewComponent
    {
        OurServiceManager cm = new OurServiceManager(new EOurServiceRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetListWithStatus();
            return View(values);
        }

    }
}

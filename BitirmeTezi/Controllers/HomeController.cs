using BitirmeTezi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BusinessLayer.Concrete;
using DataAcceLayer.EntityFramework;
using X.PagedList.Mvc;
using X.PagedList.Mvc.Core;
using Entitylayer;
using X.PagedList;

namespace BitirmeTezi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        WorkManager Wm = new WorkManager(new EWorkRepository());
        OurServiceManager Osm = new OurServiceManager(new EOurServiceRepository());
        
        public IActionResult Index()
        {
            var Val = Wm.GetListWithCategoryStatus();
            
            Val.Reverse();
            
            return View(Val);
        }
        

        
        
        public IActionResult OurServiceDetail(int id)
        {
            var val = Osm.GetById(id);
            return View(val);
        }

      
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
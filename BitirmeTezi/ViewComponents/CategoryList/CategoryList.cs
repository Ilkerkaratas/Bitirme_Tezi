using BusinessLayer.Concrete;
using DataAcceLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeTezi.ViewComponents.CategoryList
{
    public class CategoryList:ViewComponent
    {
       
            CategoryManager  cm = new CategoryManager(new ECategoryRepository());
            public IViewComponentResult Invoke()
            {
                var values = cm.GetListWithStatus();
                return View(values);
            }

      
    }
}

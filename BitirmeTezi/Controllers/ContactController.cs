using BusinessLayer.Concrete;
using DataAcceLayer.EntityFramework;
using Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeTezi.Controllers
{
    public class ContactController : Controller
    {
        
        ContactManager Cm = new ContactManager(new EContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (!ModelState.IsValid) { 
           
            }
            else {
                contact.ContactStatus = true;
                Cm.ContactAdd(contact);
            }
            return View();
        }
    }
}

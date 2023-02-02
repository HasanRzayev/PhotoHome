using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Data;
using PhotoHome.Models.Entity;

namespace PhotoHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NotificationController : Controller
    {

        private AppDbContext _base;
        public NotificationController(AppDbContext context)
        {
            _base = context;
        }
        public IActionResult Index()
        {

            var model = _base.Images.Include(a=>a.user).ToList().FindAll(a => a.Allow == false); ;
            
            return View(model);
        }

        public IActionResult Allow(Picture noti)
        {
            if (!ModelState.IsValid)
            {
                Picture notification = _base.Images.FirstOrDefault(a=>a.Id==noti.Id);

                notification.Allow = true;

                _base.SaveChanges();



            }
            return RedirectToAction("Index");

        }

        public IActionResult Not_Allow(Picture noti)
        {
            if (!ModelState.IsValid)
            {
                Picture notification = _base.Images.FirstOrDefault(a => a.Id == noti.Id);

                notification.Allow = false;
                _base.Images.Remove(notification);
                _base.SaveChanges();

            

                
            }
            return RedirectToAction("Index");

        }
    }
}

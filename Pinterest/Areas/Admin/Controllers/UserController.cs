using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoHome.Data;
using PhotoHome.Models.Entity;

namespace PhotoHome.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize]

    public class UserController : Controller
	{
        private AppDbContext _base;
        public UserController(AppDbContext context)
        {
            _base = context;
        }

        public IActionResult Index()
        {
            return View(_base.Users.ToList());
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User userdata)
        {
            if (!ModelState.IsValid)
            {
                User user = new User();
                user.LastName = userdata.LastName;
                user.FirstName = userdata.FirstName;
                user.Email = userdata.Email;
                user.UserName = userdata.UserName;
                _base.Users.Add(user);
                _base.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateUser(string Id)
        {
            var lazim = (_base.Users.ToList().Find(p => p.Id == Id));
            ViewBag.nomre = Id;
        
            return View(lazim);
        }

        [HttpPost, ActionName("UpdateCategory")]
        public IActionResult UpdateUser(User userdata)
        {
            if (userdata.FirstName != null)
            {
                User user = _base.Users.Find(userdata.Id);

                user.LastName = userdata.LastName;
                user.FirstName = userdata.FirstName;
                user.Email = userdata.Email;
                user.UserName = userdata.UserName;
                
                _base.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        public ActionResult DeleteUser(string Id)
        {
            _base.Users.Remove(_base.Users.ToList().Find(p => p.Id == Id));
            _base.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
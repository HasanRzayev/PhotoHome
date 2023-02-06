using Microsoft.AspNetCore.Mvc;

namespace PhotoHome.Controllers
{
    public class AdminLoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ReturnUrl = "/admin";
            return View();
        }
        //[HttpPost]
        //public IActionResult Index(string? returnUrl)
        //{
        //    ViewBag.ReturnUrl = returnUrl;
        //    return View("Index");
        //}
    }
}

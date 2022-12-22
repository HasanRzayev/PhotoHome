using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Data;
using PhotoHome.Models.Entity;
using Pinterest.Models;
using System.Diagnostics;

namespace Pinterest.Controllers
{
    public class HomeController : Controller
    {


        private AppDbContext baza;
        public HomeController(AppDbContext context)
        {
            baza = context;

        }
  
        public  IActionResult Index()
        {
            var list =  baza.Images.Include(p => p.catagory).ToList();
            return View(list);
        }

        public IActionResult About()
        {
            return View();
        } 
        
        public IActionResult Contact()
        {
            return View();
        } 
        
        public IActionResult Portfolio()
        {
            return View();
        } 
        
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
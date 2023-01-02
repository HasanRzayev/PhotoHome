
using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

using PhotoHome.Data;
using PhotoHome.Helpers;
using PhotoHome.IRepository;
using PhotoHome.Models;
using PhotoHome.Models.Entity;
using PhotoHome.Models.ViewModels;

using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace PhotoHome.Controllers
{


    public class UserController : Controller
    {
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly IConfiguration _configuration;
        private readonly IJWTManagerRepository _jWTManager;
        private AppDbContext _base;

        public UserController(IJWTManagerRepository jWTManager, AppDbContext context)
        {
            this._jWTManager = jWTManager;
            _base = context;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SignUp(SignupViewModel usersdata)
        {
            User user = usersdata;
            _base.Users.Add(user);
            _base.SaveChanges();
            return RedirectToAction("SignUp");
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(LoginViewModel usersdata)
        {
            if (_base.Users.FirstOrDefault(x => x.Email == usersdata.Email && x.Password == usersdata.Password)==null)
            {
                return RedirectToAction("LogIn");
            }
            var token = _jWTManager.Authenticate(_base.Users.FirstOrDefault(x => x.Email == usersdata.Email && x.Password == usersdata.Password));

            if (token == null)
            {
                return Unauthorized();
            }

            return RedirectToAction("Liked");
        }
        public IActionResult Created()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Liked()
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
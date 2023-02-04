
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Mail;
using EASendMail;
using SmtpClient = EASendMail.SmtpClient;

namespace PhotoHome.Controllers
{
    
    public class UserController : Controller
    {
        private AppDbContext _base;

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> rolemanager;
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> rolemanager, AppDbContext context)
        {
            _base = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.rolemanager = rolemanager;
        }


        [HttpPost]
        public async Task<IActionResult> SignUp(SignupViewModel usersdata)
        {
            string[] option = usersdata.Email.Split("@");
            var user = new User
            {
                Email = usersdata.Email,
                FirstName = usersdata.FirstName,
                LastName = usersdata.LastName,
                UserName = option[0],
                   
            };
            if (!await rolemanager.RoleExistsAsync("Client"))
            {
                await rolemanager.CreateAsync(new IdentityRole { Name = "Client" });
            }
  
            var result = await userManager.CreateAsync(user, usersdata.Password);
            var boss = await userManager.AddToRoleAsync(user, "Client");
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, true);
                var t = Task.Run(async delegate
                {
                    await Task.Delay(1000);

                    SmtpMail oMail = new SmtpMail("TryIt");

                    oMail.From = "photohome2023@gmail.com";
                    oMail.To = usersdata.Email;

                 
                    oMail.Subject = "Thanks for filling out our form! " +
                              "\nPhotoHome";

               
                    //oMail.ImportHtml("<html><body> <img  src=\"Thank.png\"> </body></html>",
                    //     "~\\images\\user", 
                    //     ImportHtmlBodyOptions.ImportLocalPictures | ImportHtmlBodyOptions.ImportCss);

                 
                    SmtpServer oServer = new SmtpServer("smtp.outlook.com");
                    oServer.Port = 587;

                    oServer.User = "photohome2023@gmail.com";
                    oServer.Password = "Photo_Home_2023";

                   
                    oServer.ConnectType = SmtpConnectType.ConnectTryTLS;

                  

                    Console.WriteLine("start to send email with embedded image...");

                    SmtpClient oSmtp = new SmtpClient();
                    oSmtp.SendMail(oServer, oMail);

                });
                t.Wait();
              
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in result.Errors)
                    ModelState.AddModelError(item.Code, item.Description);
            }

            return RedirectToAction("SignUp");

        }


        [HttpPost]
        public async Task<IActionResult> Authenticate(LoginViewModel usersdata, string? returnUrl)
        {
            var user = await userManager.FindByEmailAsync(usersdata.Email);
            if (user != null)
            {
                if (await userManager.CheckPasswordAsync(user, usersdata.Password))
                {
                    await signInManager.SignInAsync(user, true);
                    if (!string.IsNullOrWhiteSpace(returnUrl))
                    {
                        //var token = _jWTManager.Authenticate(user);

                        //if (token == null)
                        //{
                        //    return Unauthorized();
                        //}
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
            }

            return RedirectToAction("LogIn");
        }

      

        public IActionResult LogOut()
        {
            signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
        public IActionResult Created()
        {
            var claim = (ClaimsIdentity)User.Identity;
            var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
            var list = _base.Users.First(a=>a.Id==claims.Value);
            var model = _base.Images.ToList().FindAll(a => a.Allow == true && a.user_id == claims.Value);
            ViewBag.images = model;
            return View(list);
            
        }
        public IActionResult LogIn(string? returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied(string? returnUrl)
        {
            return RedirectToAction("LogIn", "User", returnUrl);
        }
        public IActionResult SignUp()
        {
            return View();
        }
   
        public IActionResult Liked()
        {
            var claim = (ClaimsIdentity)User.Identity;
            var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
            var list = _base.Users.First(a => a.Id == claims.Value);

            var model = _base.Image_Likes.ToList().FindAll(a => a.user_id == claims.Value);
            var image_list = new List<string>();

            foreach (var item in model)
            {
                image_list.Add(_base.Images.First(a => a.Id == item.Image_Id).ImageUrl);
            }
            ViewBag.Images = image_list;
            return View(list);
        }

        public IActionResult Settings()
		{
            var claim = (ClaimsIdentity)User.Identity;
            var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
            var user = _base.Users.First(a => a.Id == claims.Value);

            return View(user);
        }



        [HttpPost]

        public IActionResult Save(User userdata)
        {
                var claim = (ClaimsIdentity)User.Identity;
                var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
                var user = _base.Users.First(a => a.Id == claims.Value);
                user.FirstName = userdata.FirstName;
                user.LastName = userdata.LastName;
                user.UserName = userdata.UserName;
                user.Email = userdata.Email;
                user.About = userdata.About;
                _base.SaveChanges();
            
            //WebClient webClient = new WebClient();
            //string path = @"C:\Users\Hasan\Downloads";
            //string fileName = Path.GetFileName(Link);
            //webClient.DownloadFile(Link, path + "\\" + fileName);

            return RedirectToAction("Settings");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Data;
using PhotoHome.Helpers;
using PhotoHome.Models;
using PhotoHome.Models.Entity;
using PhotoHome.Models.ViewModels;
using System;
using System.Diagnostics;
using System.Security.Claims;

namespace PhotoHome.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private AppDbContext _base;
        public static Cloudinary cloudinary;
        public const string CLOUD_NAME = "dhtcecrpa";
        public const string API_KEY = "621668164995499";
        public const string API_SECRET = "iLcKxUn6rR_cq9qWiTOV8e9H2VY";

        private readonly UserManager<User> userManager;
        public HomeController(AppDbContext context, UserManager<User> userManager)
        {
            _base = context;
            this.userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var list = _base.Images.Include(p => p.catagory).ToList();
            return View(list);
        }
        [AllowAnonymous]
        public IActionResult About()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Contact()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Portfolio()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Create()
        {
            //if ()
            //{

            //    return RedirectToAction("LogIn");
            //}
            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //if (identity == null)
            //{
            //    return RedirectToAction("LogIn");
            //}
            ViewBag.Categories = new SelectList(_base.Catagories, "Id", "Name");
            //ViewBag.Categories = _base.Catagories.ToList();
            return View();
        }

        public void uploadImage(string imagePath, AddImageViewModel image)
        {

            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(imagePath)
                };

                var uploadResult = cloudinary.Upload(uploadParams);

                var claim = (ClaimsIdentity)User.Identity;
                var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
                Picture _image = new Picture();
                _image.Title = image.Title;
                _image.Description = image.Description;
                _image.catagory_id = image.catagory_id;
                _image.LikeCount = image.LikeCount;
                _image.DownloadCount = image.DownloadCount;
                _image.user_id = claims.Value;
                _image.ImageUrl = uploadResult.SecureUri.ToString();
                _base.Images.Add(_image);
                _base.SaveChanges();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //[HttpPost, ActionName("AddImage")]
        public async Task<IActionResult> AddImage(AddImageViewModel image)
        {

            var path = await UploadFileHelper.UploadFile(image.ImageUrl);


            Account account = new(CLOUD_NAME, API_KEY, API_SECRET);

            cloudinary = new Cloudinary(account);


            string imagePath = path;

            uploadImage(imagePath, image);




            return RedirectToAction("Create");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.VisualBasic;
using PhotoHome.Data;
using PhotoHome.Helpers;
using PhotoHome.Models;
using PhotoHome.Models.Entity;
using PhotoHome.Models.ViewModels;
using PhotoHome.Repository;
using System;
using System.Diagnostics;
using System.Net;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;
using PhotoHome.Helpers;
using System.Linq;
using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using EASendMail;

namespace PhotoHome.Controllers
{
	[Authorize(Roles = "Client")]

	public class HomeController : Controller
	{
		private AppDbContext _base;
		public static Cloudinary cloudinary;
		public const string CLOUD_NAME = "dhtcecrpa";
		public const string API_KEY = "621668164995499";
		public const string API_SECRET = "iLcKxUn6rR_cq9qWiTOV8e9H2VY";
		private ImageRepository imageRepository;
		private readonly UserManager<User> userManager;
		private const int pageSize = 15;
		private static List<string> image_tags;
		public const int ImageMinimumBytes = 512;
		public List<string> Image_Tags
		{
			get { return image_tags; }
			set { image_tags = value; }
		}

		public HomeController(AppDbContext context, UserManager<User> userManager)
		{
			_base = context;
			this.userManager = userManager;
			Image_Tags = new List<string>();

		}


		[HttpGet]
		[AllowAnonymous]
		public ActionResult ImageList(int? pageNumber, string? search, string? search_type)
		{

			imageRepository = new ImageRepository(_base);
			var claim = (ClaimsIdentity)User.Identity;
			var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
			var model = new List<Picture>();

			model = imageRepository.GetImage(pageNumber, search, search_type);
			return PartialView("ImageList", model);

		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Index(string searchPattern)
		{
			var model = _base.Image_Tags.Include(p => p.Image).Where(it => it.Tag.Name.Contains(CapitalizeHelper.CapitalizeText(searchPattern))).Select(it => it.Image).ToList();

			ViewBag.Category = _base.Catagories.ToList();
			ViewBag.ActiveMenu = "index";

			return View("Index", model);
		}

		[AllowAnonymous]
		public IActionResult SearchPage(string searchPattern)
		{
			var model = _base.Image_Tags.Include(p => p.Image).Where(it => it.Tag.Name.Contains(CapitalizeHelper.CapitalizeText(searchPattern))).Select(it => it.Image).ToList();

			ViewBag.Category = _base.Catagories.ToList();

			return View("Index", model);
		}


		[AllowAnonymous]
		public IActionResult SearchCatagory(string searchPattern)
		{
			var model = _base.Images.Include(a => a.catagory).Where(a => a.catagory.Name == searchPattern).ToList();

			ViewBag.Category = _base.Catagories.ToList();

			return View("Index", model);
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Index()
		{
			//imageRepository = new ImageRepository(_base);

			//var claim = (ClaimsIdentity)User.Identity;
			//var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
			//var model = new List<string>();

			//if (claims != null)
			//{
			//	model = imageRepository.GetImages(1, claims.Value);
			//}
			//else
			//{
			//	model = imageRepository.GetImages(1);
			//}

			//ViewBag.Category = _base.Catagories.ToList();
			//ViewBag.ActiveMenu = "index";

			//return View(model);

			//___________________________________________________
			imageRepository = new ImageRepository(_base);
			var model = new List<Picture>();
			var claim = (ClaimsIdentity)User.Identity;
			var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
			model = imageRepository.GetImage(0, null, null);

			ViewBag.Category = _base.Catagories.ToList();
			ViewBag.ActiveMenu = "index";

			if (claims != null)
			{
				ViewBag.user = _base.Users.First(a => a.Id == claims.Value);
			}
			return View(model);
		}

		[AllowAnonymous]
		public IActionResult About()
		{
			ViewBag.ActiveMenu = "about";

			return View();
		}

		[AllowAnonymous]
		public IActionResult Contact()
		{
			ViewBag.ActiveMenu = "contact";
			//var claim = (ClaimsIdentity)User.Identity;
			//var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
			//var model = _base.Users.FirstOrDefault(n => n.Id == claims.Value);

			return View();
		}

		//[AllowAnonymous]
		//[HttpPost]
  //      public IActionResult SendData(User usersdata)
  //      {
  //          var t = Task.Run(async delegate
  //          {
  //              try
  //              {
  //                  await Task.Delay(1000);

  //                  SmtpMail oMail = new SmtpMail("TryIt");

  //                  oMail.From = "photohome2023@gmail.com";
  //                  oMail.To = usersdata.Email;

  //                  var imgUrl = "https://www.yourSite.com/Images/cp-map.jpg";

  //                  oMail.Subject = $"Thank you '{usersdata.FirstName}' for filling out our form! " +
  //                            "\nPhotoHome";
					

  //                  //oMail.ImportHtml("<html><body> <img  src='https://www.yourSite.com/Images/cp-map.jpg' /> </body></html>",
  //                  //	 "~\\images\\user",
  //                  //	 ImportHtmlBodyOptions.ImportLocalPictures | ImportHtmlBodyOptions.ImportCss);
  //                  //oMail.HtmlBody = $"<html><body> <p> '{usersdata.Message}' </p> </body></html>";

  //                  SmtpServer oServer = new SmtpServer("smtp.outlook.com");
  //                  oServer.Port = 587;

  //                  oServer.User = "photohome2023@gmail.com";
  //                  //oServer.Password = "Photo_Home_2023";


  //                  oServer.ConnectType = SmtpConnectType.ConnectTryTLS;



  //                  Console.WriteLine("start to send email with embedded image...");

  //                  SmtpClient oSmtp = new SmtpClient();
  //                  oSmtp.SendMail(oServer, oMail);
  //              }
  //              catch (Exception)
  //              {

  //                  throw;
  //              }


  //          });
  //          t.Wait();

  //          return RedirectToAction("Contact");
  //      }


        [AllowAnonymous]
		public IActionResult Services()
		{
			ViewBag.ActiveMenu = "services";

			return View();
		}

		//      [HttpGet]
		//      [AllowAnonymous]
		//public List<Picture> Search(string? search)
		//{
		// //         var tag =  _base.Tags.Include(p => p.Image_Tags).Where(p => p.Name.Contains(CapitalizeHelper.CapitalizeText(search))).ToList();

		//	//var model = _base.Image_Tags.Include(p => p.Image).ToList().FindAll(x => x.Tag_Id == tag[0].Id);

		//	//var list = new List<Picture>();

		//	//foreach (var item in model)
		//	//{
		//	//	list.Add(item.Image);
		//	//}

		//	//var images = new List<Picture>();

		//	//foreach (var item in list)
		//	//{
		//	//	images.Add(item);
		//	//}

		//	//return images;

		//      }

		[HttpGet]
		[AllowAnonymous]
		public IActionResult ImageInfo(string Id)
		{
			if (Id.Contains("%2F")) Id = Id.Replace("%2F", "/");

			var option = _base.Images.Include(n => n.user).Include(n => n.catagory).FirstOrDefault(n => n.ImageUrl == Id);
			var id = option.Id;

			var relatedImages = _base.Images.Include(i => i.catagory).Where(i => i.catagory_id == option.catagory_id && i.Id != id).ToList();

			var list = _base.Image_Tags.ToList().FindAll(c => c.Image_Id == id);
			var model = new List<Tag>();

			foreach (var item in list)
			{
				model.Add(_base.Tags.FirstOrDefault(a => a.Id == item.Tag_Id));
			}

			ViewBag.Tags = (model);
			ViewBag.RelatedImages = relatedImages;

			return View(option);
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Download(string Link)
		{
			if (ModelState.IsValid)
			{
				Picture option = _base.Images.First(a => a.ImageUrl == Link);
				option.DownloadCount++;

				_base.SaveChanges();
			}
			return RedirectToAction("Index");
		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult Like(string Link)
		{
			var claim = (ClaimsIdentity)User.Identity;

			if (claim == null)
			{
				return RedirectToAction("LogIn", "User");
			}
			if (ModelState.IsValid)
			{
				var claims = claim.FindFirst(ClaimTypes.NameIdentifier);

				User user = _base.Users.First(a => a.Id == claims.Value);
				Picture option = _base.Images.First(a => a.ImageUrl == Link);
				var import = new Image_Like { Image_Id = option.Id, user_id = claims.Value };

				if (!_base.Image_Likes.Contains(import))
				{
					_base.Image_Likes.Add(import);
					option.LikeCount = option.LikeCount + 1;
				}
				else
				{
					_base.Image_Likes.Remove(import);
					option.LikeCount = option.LikeCount - 1;
				}

				_base.SaveChanges();
			}

			return RedirectToAction("Index");
		}

		[HttpPost]
		[AllowAnonymous]
		//[ValidateAntiForgeryToken]
		public async Task AddTag(List<string> list)
		{
			var t = Task.Run(async delegate
			{

				Image_Tags = new List<string>();
				foreach (var item in list)
				{
					Image_Tags.Add(item);
				}
			});
			t.Wait(); // Wait for the task to finish


		}

		[HttpPost]
		[AllowAnonymous]
		public IActionResult RemoveImage(string Link)
		{
			var claim = (ClaimsIdentity)User.Identity;

			if (claim == null)
			{
				return RedirectToAction("LogIn", "User");
			}
			if (ModelState.IsValid)
			{
				var claims = claim.FindFirst(ClaimTypes.NameIdentifier);

				User user = _base.Users.First(a => a.Id == claims.Value);
				Picture option = _base.Images.First(a => a.ImageUrl == Link);

				var import = _base.Images.FirstOrDefault(a => a.user_id == user.Id && a.Id == option.Id);

				_base.Images.Remove(option);
				_base.SaveChanges();
			}

			return RedirectToAction("Created");
		}

		//!allow anonymus yazmisam ki login e helelik ehtiyac qalmasin
		[AllowAnonymous]
		public IActionResult Create()
		{
			ViewBag.Categories = new SelectList(_base.Catagories, "Id", "Name");


			ViewBag.ActiveMenu = "create";

			return View();
		}


		public void UploadImage(string imagePath, AddImageViewModel image)
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
				_image.Allow = false;




				_base.Images.Add(_image);
				_base.SaveChanges();

				foreach (var item in Image_Tags)
				{
					if (_base.Tags.FirstOrDefault(a => a.Name == item) == null)
					{
						_base.Tags.Add(new Tag { Name = item });
					}
					_base.SaveChanges();
					int tag_id = _base.Tags.FirstOrDefault(a => a.Name == item).Id;
					int image_id = _base.Images.FirstOrDefault(a => a.ImageUrl == _image.ImageUrl).Id;
					_base.Image_Tags.Add(new Image_Tag { Image_Id = image_id, Tag_Id = tag_id });
				}


				_base.SaveChanges();



			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public async Task<IActionResult> AddImage(AddImageViewModel image)
		{
			var path = await UploadFileHelper.UploadFile(image.ImageUrl);

			Account account = new(CLOUD_NAME, API_KEY, API_SECRET);

			cloudinary = new Cloudinary(account);

			string imagePath = path;

			UploadImage(imagePath, image);

			return RedirectToAction("Create");
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}



	}

}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Data;
using PhotoHome.Models.Entity;

namespace PhotoHome.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ImageController : Controller
	{
        private AppDbContext _base;
        public ImageController(AppDbContext context)
        {
            _base = context;

        }

        public IActionResult Index()
        {
            return View(_base.Tags.ToList());
        }

        public IActionResult AddImage()
        {
            ViewBag.catagories = _base.Catagories.Include(a => a.Images).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Tag catalogue)
        {
            if (!ModelState.IsValid)
            {
                Tag lazim = new Tag();
                lazim.Name = catalogue.Name;
                _base.Tags.Add(lazim);
                _base.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult UpdateImage(int Id)
        {
            var lazim = (_base.Tags.ToList().Find(p => p.Id == Id));
            ViewBag.catagories = _base.Catagories.Include(a=>a.Images).ToList();
            return View(lazim);
        }
        [HttpPost, ActionName("UpdateCategory")]
        public IActionResult UpdateImage(Tag catalogue)
        {

            if (catalogue.Name != null)
            {

                Tag lazim = _base.Tags.Find(catalogue.Id);
                lazim.Name = catalogue.Name;
                _base.SaveChanges();
            }
            return RedirectToAction("Index");
        }



        public ActionResult DeleteImage(int Id)
        {
            //var lazim = baza.Products.ToList().Find(p => p.catalogue_id == Id);
            //if (baza.Products.First())
            //{

            //}
            _base.Tags.Remove(_base.Tags.ToList().Find(p => p.Id == Id));
            _base.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
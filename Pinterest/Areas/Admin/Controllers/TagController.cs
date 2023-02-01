using Microsoft.AspNetCore.Mvc;
using PhotoHome.Data;
using PhotoHome.Models.Entity;

namespace PhotoHome.Areas.Admin.Controllers
{
	[Area("Admin")]
  
	public class TagController : Controller
	{
        private AppDbContext _base;
        public TagController(AppDbContext context)
        {
            _base = context;

        }

        public IActionResult Index()
        {
            return View(_base.Tags.ToList());
        }

        public IActionResult AddTag()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTag(Tag catalogue)
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
        public IActionResult UpdateTag(int Id)
        {
            var lazim = (_base.Tags.ToList().Find(p => p.Id == Id));
            ViewBag.nomre = Id;
            return View(lazim);
        }
        [HttpPost, ActionName("UpdateCategory")]
        public IActionResult UpdateTag(Tag catalogue)
        {

            if (catalogue.Name != null)
            {

                Tag lazim = _base.Tags.Find(catalogue.Id);
                lazim.Name = catalogue.Name;
                _base.SaveChanges();
            }
            return RedirectToAction("Index");
        }



        public ActionResult DeleteTag(int Id)
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
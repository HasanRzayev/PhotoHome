using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PhotoHome.Data;
using PhotoHome.Models.Entity;

namespace PhotoHome.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize(Roles ="Admin")]
	public class CategoryController : Controller
	{
        private AppDbContext _base;
        public CategoryController(AppDbContext context)
        {
            _base = context;
         
        }

        public IActionResult Index()
		{
			return View(_base.Catagories.ToList());
		}

        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCatagory(Catagory catalogue)
        {
            if (!ModelState.IsValid)
            {
                Catagory lazim = new Catagory();
                lazim.Name = catalogue.Name;
                _base.Catagories.Add(lazim);
                _base.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult UpdateCategory(int Id)
        {
            var lazim = (_base.Catagories.ToList().Find(p => p.Id == Id));
            ViewBag.nomre = Id;
            return View(lazim);
        }
        [HttpPost, ActionName("UpdateCategory")]
        public IActionResult UpdateCategory(Catagory catalogue)
        {

            if (catalogue.Name != null)
            {

                Catagory lazim = _base.Catagories.Find(catalogue.Id);
                lazim.Name = catalogue.Name;
                _base.SaveChanges();
            }
            return RedirectToAction("Index");
        }



        public ActionResult DeleteCategory(int Id)
        {
            //var lazim = baza.Products.ToList().Find(p => p.catalogue_id == Id);
            //if (baza.Products.First())
            //{

            //}
            _base.Catagories.Remove(_base.Catagories.ToList().Find(p => p.Id == Id));
            _base.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

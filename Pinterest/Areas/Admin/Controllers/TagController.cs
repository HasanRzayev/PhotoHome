using Microsoft.AspNetCore.Mvc;

namespace PhotoHome.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class TagController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
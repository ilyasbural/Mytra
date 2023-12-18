using Microsoft.AspNetCore.Mvc;

namespace Mytra.Presentation.Areas.User.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

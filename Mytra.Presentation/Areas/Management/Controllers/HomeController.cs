using Microsoft.AspNetCore.Mvc;

namespace Mytra.Presentation.Areas.Management.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

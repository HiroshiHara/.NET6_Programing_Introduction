using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class HelloController : Controller
	{
		public IActionResult Index()
		{
			var model = new HelloModel();
			model.Name = "Hiroshi Hara";
			model.Now = DateTime.Now;
			return View(model);
		}
	}
}

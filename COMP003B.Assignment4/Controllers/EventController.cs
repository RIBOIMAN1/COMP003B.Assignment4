using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
	public class EventController : Controller
	{
		public IActionResult Register()
		{
			return View(new EventRegistration());
		}

		[HttpPost]
		public IActionResult Register(EventRegistration model)
		{
			if (ModelState.IsValid)
			{
				return View("Success", model);
			}
			return View(model);
		}
	}
}

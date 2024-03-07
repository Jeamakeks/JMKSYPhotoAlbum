using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhotoAlbum.Models;

namespace PhotoAlbum.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

	// Action method for navigating to Album1.cshtml
	public ActionResult NavigateToAlbum1()
	{
		// Redirect to Album1 action
		return RedirectToAction("Album1");
	}

	// Action method to render Album1.cshtml view
	public ActionResult Album1()
	{
		return View("~/Views/Albums/Album1.cshtml");
	}
}

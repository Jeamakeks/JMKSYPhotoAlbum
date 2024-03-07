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

	// Action method for navigating to Page1.cshtml
	public ActionResult NavigateToPage1()
	{
		// Redirect to Page1 action
		return RedirectToAction("Page1");
	}

	// Action method to render Page1.cshtml view
	public ActionResult Page1()
	{
		return View("~/Views/Pages/Page1.cshtml");
	}
}

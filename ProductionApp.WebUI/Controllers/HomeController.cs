﻿namespace ProductionApp.WebUI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "Home", new { area = "Admin" });
    }
}

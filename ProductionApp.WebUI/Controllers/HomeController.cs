using Microsoft.AspNetCore.Mvc;

namespace ProductionApp.WebUI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

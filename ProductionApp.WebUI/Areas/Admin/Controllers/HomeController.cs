using Microsoft.AspNetCore.Mvc;
using ProductionApp.Common.InfoMessages;

namespace ProductionApp.WebUI.Areas.Admin.Controllers;

[Area(AreaInfo.Admin)]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        TempData["MenuActive"] = "Dashboard";

        return View();
    }
}

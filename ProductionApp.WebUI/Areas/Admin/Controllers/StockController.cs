using Microsoft.AspNetCore.Mvc;

namespace ProductionApp.WebUI.Areas.Admin.Controllers;

public class StockController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

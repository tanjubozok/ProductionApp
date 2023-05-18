using Microsoft.AspNetCore.Mvc;
using ProductionApp.Common.InfoMessages;

namespace ProductionApp.WebUI.Areas.Admin.Controllers;

[Area(AreaInfo.Admin)]
public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

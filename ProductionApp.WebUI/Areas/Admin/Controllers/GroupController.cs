using Microsoft.AspNetCore.Mvc;
using ProductionApp.Service.Abstract;

namespace ProductionApp.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
public class GroupController : Controller
{
    private readonly IGroupService _groupService;

    public GroupController(IGroupService groupService)
    {
        _groupService = groupService;
    }

    public async Task<IActionResult> List()
    {
        var result = await _groupService.GetAllAsync();
        return View(result.Data);
    }
}
 
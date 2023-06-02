namespace ProductionApp.WebUI.Areas.Admin.Controllers;

[Area(AreaInfo.Admin)]
public class GroupController : Controller
{
    private readonly IGroupService _groupService;
    private readonly INotyfService _notifyService;

    public GroupController(IGroupService groupService, INotyfService notifyService)
    {
        _groupService = groupService;
        _notifyService = notifyService;
    }

    public async Task<IActionResult> List()
    {
        TempData["MenuActive"] = "Group";

        var result = await _groupService.GetAllAsync();
        return View(result.Data);
    }

    public async Task<IActionResult> Create()
    {
        TempData["MenuActive"] = "Group";

        var code = await _groupService.GenerateGroupCodeAsync();

        return View(new GroupAddDto()
        {
            Code = code
        });
    }

    [HttpPost]
    [ValidModel]
    public async Task<IActionResult> Create(GroupAddDto dto)
    {
        var result = await _groupService.AddAsync(dto);
        if (result.ResponseTypes == ResponseType.Success)
        {
            _notifyService.Success("Added");
            return RedirectToAction("List");
        }
        _notifyService.Error(result.Message);

        return View(dto);
    }

    public async Task<IActionResult> Edit(int id)
    {
        TempData["MenuActive"] = "Group";

        var result = await _groupService.GetByIdAsync(id);
        if (result.ResponseTypes == ResponseType.Success)
            return View(result.Data);

        _notifyService.Error(result.Message);
        return RedirectToAction("List");
    }

    [HttpPost]
    [ValidModel]
    public async Task<IActionResult> Edit(GroupUpdateDto dto)
    {
        var result = await _groupService.UpdateAsync(dto);
        if (result.ResponseTypes == ResponseType.Success)
        {
            _notifyService.Success("Updated");
            return RedirectToAction("List");
        }
        _notifyService.Error(result.Message);

        return View(dto);
    }
}

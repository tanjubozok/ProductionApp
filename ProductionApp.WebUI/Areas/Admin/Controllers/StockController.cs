namespace ProductionApp.WebUI.Areas.Admin.Controllers;

[Area(AreaInfo.Admin)]
public class StockController : Controller
{
    private readonly IStockService _stockService;
    private readonly IGroupService _groupService;
    private readonly INotyfService _notifyService;

    public StockController(IStockService stockService, IGroupService groupService, INotyfService notifyService)
    {
        _stockService = stockService;
        _groupService = groupService;
        _notifyService = notifyService;
    }

    public async Task<IActionResult> List()
    {
        TempData["MenuActive"] = "Stock";

        var result = await _stockService.GetAllAsync();
        return View(result.Data);
    }

    public async Task<IActionResult> Create()
    {
        TempData["MenuActive"] = "Stock";

        var groupList = await _groupService.GetAllAsync();
        ViewBag.Groups = new SelectList(groupList.Data, "Id", "Name");

        return View(new StockAddDto());
    }

    [HttpPost]
    [ValidModel]
    public async Task<IActionResult> Create(StockAddDto dto)
    {
        var dataResult = await _stockService.AddAsync(dto);
        if (dataResult.ResponseTypes == ResponseType.Success)
        {
            _notifyService.Success("Eklendi");
            return RedirectToAction("List");
        }
        _notifyService.Error(dataResult.Message);

        var result = await _groupService.GetAllAsync();
        ViewBag.Groups = new SelectList(result.Data, "Id", "Name");

        return View(dto);
    }

    public async Task<IActionResult> Edit(int id)
    {
        TempData["MenuActive"] = "Stock";

        var result = await _stockService.GetByIdAsync(id);
        if (result.ResponseTypes == ResponseType.Success)
        {
            var groupList = await _groupService.GetAllAsync();
            ViewBag.Groups = new SelectList(groupList.Data, "Id", "Name", result.Data!.GroupId);

            return View(result.Data);
        }
        _notifyService.Error(result.Message);
        return RedirectToAction("List");
    }

    [HttpPost]
    [ValidModel]
    public async Task<IActionResult> Edit(StockUpdateDto dto)
    {
        var result = await _stockService.UpdateAsync(dto);
        if (result.ResponseTypes == ResponseType.Success)
        {
            _notifyService.Success("Güncellendi");
            return RedirectToAction("List");
        }
        _notifyService.Error(result.Message);

        var groupList = await _groupService.GetAllAsync();
        ViewBag.Groups = new SelectList(groupList.Data, "Id", "Name", dto.GroupId);

        return View(dto);
    }
}

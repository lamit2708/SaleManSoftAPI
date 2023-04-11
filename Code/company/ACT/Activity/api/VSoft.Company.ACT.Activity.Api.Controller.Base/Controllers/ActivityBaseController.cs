using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ACT.Activity.Business.Services;
using VSoft.Company.ACT.Activity.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.ACT.Activity.Api.Controller.Base.Controllers;

public abstract class ActivityBaseController : ControllerBase
{
    protected IActivityMgmtBus Bus { get; private set; }

    public ActivityBaseController(IActivityMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IActivityActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IActivityActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IActivityActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] ActivityTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetTableByKeySearch(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IActivityActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] ActivityInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IActivityActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] ActivityInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IActivityActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] ActivitySaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IActivityActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] ActivityUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IActivityActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] ActivityUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IActivityActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] ActivityDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IActivityActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] ActivityDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

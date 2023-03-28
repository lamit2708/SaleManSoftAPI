using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRI.Priority.Business.Services;
using VSoft.Company.PRI.Priority.Business.Dto.Request;
using VSoft.Company.PRI.Priority.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.PRI.Priority.Api.Controller.Base.Controllers;

public abstract class PriorityBaseController : ControllerBase
{
    protected IPriorityMgmtBus Bus { get; private set; }

    public PriorityBaseController(IPriorityMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IPriorityActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IPriorityActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IPriorityActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] PriorityInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IPriorityActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] PriorityInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IPriorityActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] PrioritySaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IPriorityActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] PriorityUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IPriorityActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] PriorityUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IPriorityActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] PriorityDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IPriorityActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] PriorityDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

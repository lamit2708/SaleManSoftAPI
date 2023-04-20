using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DEA.Deal.Business.Services;
using VSoft.Company.DEA.Deal.Business.Dto.Request;
using VSoft.Company.DEA.Deal.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DEA.Deal.Api.Controller.Base.Controllers;

public abstract class DealBaseController : ControllerBase
{
    protected IDealMgmtBus Bus { get; private set; }

    public DealBaseController(IDealMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IDealActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IDealActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IDealActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] DealTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetViewByKeySearch(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] DealInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] DealInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] DealSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] DealUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] DealUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] DealDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] DealDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

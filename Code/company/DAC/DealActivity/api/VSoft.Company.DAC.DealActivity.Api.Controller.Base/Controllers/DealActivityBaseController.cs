using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DAC.DealActivity.Business.Services;
using VSoft.Company.DAC.DealActivity.Business.Dto.Request;
using VSoft.Company.DAC.DealActivity.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DAC.DealActivity.Api.Controller.Base.Controllers;

public abstract class DealActivityBaseController : ControllerBase
{
    protected IDealActivityMgmtBus Bus { get; private set; }

    public DealActivityBaseController(IDealActivityMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IDealActivityActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IDealActivityActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealActivityActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] DealActivityInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealActivityActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] DealActivityInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealActivityActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] DealActivitySaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealActivityActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] DealActivityUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealActivityActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] DealActivityUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealActivityActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] DealActivityDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealActivityActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] DealActivityDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

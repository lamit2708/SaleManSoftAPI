using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DSH.DealStepHistory.Business.Services;
using VSoft.Company.DSH.DealStepHistory.Business.Dto.Request;
using VSoft.Company.DSH.DealStepHistory.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DSH.DealStepHistory.Api.Controller.Base.Controllers;

public abstract class DealStepHistoryBaseController : ControllerBase
{
    protected IDealStepHistoryMgmtBus Bus { get; private set; }

    public DealStepHistoryBaseController(IDealStepHistoryMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IDealStepHistoryActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IDealStepHistoryActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealStepHistoryActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] DealStepHistoryInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealStepHistoryActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] DealStepHistoryInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealStepHistoryActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] DealStepHistorySaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealStepHistoryActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] DealStepHistoryUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealStepHistoryActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] DealStepHistoryUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealStepHistoryActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] DealStepHistoryDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealStepHistoryActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] DealStepHistoryDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

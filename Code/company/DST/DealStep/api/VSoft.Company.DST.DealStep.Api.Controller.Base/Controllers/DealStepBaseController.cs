using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DST.DealStep.Business.Services;
using VSoft.Company.DST.DealStep.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DST.DealStep.Api.Controller.Base.Controllers;

public abstract class DealStepBaseController : ControllerBase
{
    protected IDealStepMgmtBus Bus { get; private set; }

    public DealStepBaseController(IDealStepMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IDealStepActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IDealStepActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealStepActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] DealStepInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealStepActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] DealStepInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealStepActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] DealStepSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealStepActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] DealStepUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealStepActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] DealStepUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealStepActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] DealStepDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealStepActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] DealStepDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

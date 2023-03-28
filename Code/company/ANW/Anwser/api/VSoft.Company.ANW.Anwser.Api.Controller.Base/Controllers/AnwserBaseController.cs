using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ANW.Anwser.Business.Services;
using VSoft.Company.ANW.Anwser.Business.Dto.Request;
using VSoft.Company.ANW.Anwser.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.ANW.Anwser.Api.Controller.Base.Controllers;

public abstract class AnwserBaseController : ControllerBase
{
    protected IAnwserMgmtBus Bus { get; private set; }

    public AnwserBaseController(IAnwserMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IAnwserActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IAnwserActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IAnwserActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] AnwserInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IAnwserActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] AnwserInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IAnwserActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] AnwserSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IAnwserActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] AnwserUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IAnwserActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] AnwserUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IAnwserActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] AnwserDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IAnwserActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] AnwserDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

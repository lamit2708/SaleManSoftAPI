using Microsoft.AspNetCore.Mvc;
using VSoft.Company.CSO.CustomerSource.Business.Services;
using VSoft.Company.CSO.CustomerSource.Business.Dto.Request;
using VSoft.Company.CSO.CustomerSource.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.CSO.CustomerSource.Api.Controller.Base.Controllers;

public abstract class CustomerSourceBaseController : ControllerBase
{
    protected ICustomerSourceMgmtBus Bus { get; private set; }

    public CustomerSourceBaseController(ICustomerSourceMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(ICustomerSourceActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(ICustomerSourceActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerSourceActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] CustomerSourceInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerSourceActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] CustomerSourceInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerSourceActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] CustomerSourceSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ICustomerSourceActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] CustomerSourceUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ICustomerSourceActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] CustomerSourceUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ICustomerSourceActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] CustomerSourceDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ICustomerSourceActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] CustomerSourceDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

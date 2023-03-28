using Microsoft.AspNetCore.Mvc;
using VSoft.Company.UCU.UserCustomer.Business.Services;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Request;
using VSoft.Company.UCU.UserCustomer.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.UCU.UserCustomer.Api.Controller.Base.Controllers;

public abstract class UserCustomerBaseController : ControllerBase
{
    protected IUserCustomerMgmtBus Bus { get; private set; }

    public UserCustomerBaseController(IUserCustomerMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IUserCustomerActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IUserCustomerActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserCustomerActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] UserCustomerInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserCustomerActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] UserCustomerInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserCustomerActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] UserCustomerSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IUserCustomerActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] UserCustomerUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IUserCustomerActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] UserCustomerUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IUserCustomerActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] UserCustomerDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IUserCustomerActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] UserCustomerDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

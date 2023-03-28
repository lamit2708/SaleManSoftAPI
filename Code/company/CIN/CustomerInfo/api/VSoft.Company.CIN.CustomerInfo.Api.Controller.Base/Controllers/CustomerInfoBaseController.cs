using Microsoft.AspNetCore.Mvc;
using VSoft.Company.CIN.CustomerInfo.Business.Services;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.CIN.CustomerInfo.Api.Controller.Base.Controllers;

public abstract class CustomerInfoBaseController : ControllerBase
{
    protected ICustomerInfoMgmtBus Bus { get; private set; }

    public CustomerInfoBaseController(ICustomerInfoMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(ICustomerInfoActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(ICustomerInfoActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerInfoActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] CustomerInfoInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerInfoActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] CustomerInfoInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ICustomerInfoActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] CustomerInfoSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ICustomerInfoActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] CustomerInfoUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ICustomerInfoActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] CustomerInfoUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ICustomerInfoActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] CustomerInfoDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ICustomerInfoActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] CustomerInfoDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

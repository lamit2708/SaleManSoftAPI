using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ORD.Order.Business.Services;
using VSoft.Company.ORD.Order.Business.Dto.Request;
using VSoft.Company.ORD.Order.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.ORD.Order.Api.Controller.Base.Controllers;

public abstract class OrderBaseController : ControllerBase
{
    protected IOrderMgmtBus Bus { get; private set; }

    public OrderBaseController(IOrderMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IOrderActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IOrderActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IOrderActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] OrderInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IOrderActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] OrderInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IOrderActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] OrderSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IOrderActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] OrderUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IOrderActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] OrderUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IOrderActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] OrderDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IOrderActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] OrderDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

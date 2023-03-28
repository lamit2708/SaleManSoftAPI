using Microsoft.AspNetCore.Mvc;
using VSoft.Company.POR.ProductOrder.Business.Services;
using VSoft.Company.POR.ProductOrder.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.POR.ProductOrder.Api.Controller.Base.Controllers;

public abstract class ProductOrderBaseController : ControllerBase
{
    protected IProductOrderMgmtBus Bus { get; private set; }

    public ProductOrderBaseController(IProductOrderMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IProductOrderActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IProductOrderActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductOrderActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] ProductOrderInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductOrderActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] ProductOrderInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductOrderActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] ProductOrderSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductOrderActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] ProductOrderUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductOrderActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] ProductOrderUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductOrderActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] ProductOrderDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductOrderActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] ProductOrderDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

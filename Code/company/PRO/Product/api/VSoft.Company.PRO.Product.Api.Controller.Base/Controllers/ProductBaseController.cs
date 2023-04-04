using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRO.Product.Business.Services;
using VSoft.Company.PRO.Product.Business.Dto.Request;
using VSoft.Company.PRO.Product.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;


namespace VSoft.Company.PRO.Product.Api.Controller.Base.Controllers;

public abstract class ProductBaseController : ControllerBase
{
    protected IProductMgmtBus Bus { get; private set; }

    public ProductBaseController(IProductMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IProductActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IProductActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }
    [HttpGet(nameof(IProductActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] ProductTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetTableByKeySearch(dtosRequest);
        return Ok(res);
    }
    [HttpPost(nameof(IProductActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] ProductInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] ProductInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] ProductSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] ProductUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] ProductUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] ProductDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] ProductDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRC.ProductCategory.Business.Services;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.PRC.ProductCategory.Api.Controller.Base.Controllers;

public abstract class ProductCategoryBaseController : ControllerBase
{
    protected IProductCategoryMgmtBus Bus { get; private set; }

    public ProductCategoryBaseController(IProductCategoryMgmtBus bus)
    {
        Bus = bus;
    }

    [HttpGet(nameof(IProductCategoryActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IProductCategoryActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductCategoryActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] ProductCategoryInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductCategoryActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] ProductCategoryInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductCategoryActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] ProductCategorySaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductCategoryActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] ProductCategoryUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductCategoryActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] ProductCategoryUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductCategoryActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] ProductCategoryDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductCategoryActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] ProductCategoryDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

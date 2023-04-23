using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRF.ProductFeature.Business.Services;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Response;

namespace VSoft.Company.PRF.ProductFeature.Api.Controller.Base.Controllers;

public abstract class ProductFeatureBaseController : ControllerBase
{
    protected IProductFeatureMgmtBus Bus { get; private set; }

    public ProductFeatureBaseController(IProductFeatureMgmtBus bus)
    {
        Bus = bus;
    }

    [HttpGet(nameof(IProductFeatureActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IProductFeatureActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IProductFeatureActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] ProductFeatureTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetTableByKeySearch(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductFeatureActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] ProductFeatureInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductFeatureActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] ProductFeatureInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IProductFeatureActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] ProductFeatureSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductFeatureActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] ProductFeatureUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IProductFeatureActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] ProductFeatureUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductFeatureActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] ProductFeatureDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IProductFeatureActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] ProductFeatureDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IProductFeatureActionName.GetAll))]
    public async Task<IActionResult> FindAllAsync()
    {
        var res = await Bus.GetAll();
        return Ok(res);
    }
}

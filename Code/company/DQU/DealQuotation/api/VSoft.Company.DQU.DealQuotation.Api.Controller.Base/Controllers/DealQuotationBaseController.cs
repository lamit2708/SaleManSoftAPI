using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DQU.DealQuotation.Business.Services;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.DQU.DealQuotation.Api.Controller.Base.Controllers;

public abstract class DealQuotationBaseController : ControllerBase
{
    protected IDealQuotationMgmtBus Bus { get; private set; }

    public DealQuotationBaseController(IDealQuotationMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IDealQuotationActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IDealQuotationActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealQuotationActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] DealQuotationInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealQuotationActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] DealQuotationInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IDealQuotationActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] DealQuotationSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealQuotationActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] DealQuotationUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IDealQuotationActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] DealQuotationUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealQuotationActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] DealQuotationDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IDealQuotationActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] DealQuotationDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

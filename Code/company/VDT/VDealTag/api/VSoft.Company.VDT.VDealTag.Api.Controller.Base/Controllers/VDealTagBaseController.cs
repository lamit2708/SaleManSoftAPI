using Microsoft.AspNetCore.Mvc;
using VSoft.Company.VDT.VDealTag.Business.Services;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.VDT.VDealTag.Api.Controller.Base.Controllers;

public abstract class VDealTagBaseController : ControllerBase
{
    protected IVDealTagMgmtBus Bus { get; private set; }

    public VDealTagBaseController(IVDealTagMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IVDealTagActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IVDealTagActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IVDealTagActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] VDealTagTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetTableByKeySearch(dtosRequest);
        return Ok(res);
    }
}

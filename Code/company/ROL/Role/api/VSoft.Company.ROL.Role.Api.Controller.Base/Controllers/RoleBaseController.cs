using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ROL.Role.Business.Services;
using VSoft.Company.ROL.Role.Business.Dto.Request;
using VSoft.Company.ROL.Role.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.ROL.Role.Api.Controller.Base.Controllers;

public abstract class RoleBaseController : ControllerBase
{
    protected IRoleMgmtBus Bus { get; private set; }

    public RoleBaseController(IRoleMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IRoleActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IRoleActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IRoleActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] RoleInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IRoleActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] RoleInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IRoleActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] RoleSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IRoleActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] RoleUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IRoleActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] RoleUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IRoleActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] RoleDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IRoleActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] RoleDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

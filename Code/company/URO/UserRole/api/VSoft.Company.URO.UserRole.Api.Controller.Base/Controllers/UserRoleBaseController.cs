using Microsoft.AspNetCore.Mvc;
using VSoft.Company.URO.UserRole.Business.Services;
using VSoft.Company.URO.UserRole.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.URO.UserRole.Api.Controller.Base.Controllers;

public abstract class UserRoleBaseController : ControllerBase
{
    protected IUserRoleMgmtBus Bus { get; private set; }

    public UserRoleBaseController(IUserRoleMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IUserRoleActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByLong dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IUserRoleActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByLongs dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserRoleActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] UserRoleInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserRoleActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] UserRoleInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserRoleActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] UserRoleSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IUserRoleActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] UserRoleUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IUserRoleActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] UserRoleUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IUserRoleActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] UserRoleDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IUserRoleActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] UserRoleDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

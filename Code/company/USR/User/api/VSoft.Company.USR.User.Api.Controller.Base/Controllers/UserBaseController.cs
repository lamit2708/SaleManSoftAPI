using Microsoft.AspNetCore.Mvc;
using VSoft.Company.USR.User.Business.Services;
using VSoft.Company.USR.User.Business.Dto.Request;
using VSoft.Company.USR.User.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.USR.User.Api.Controller.Base.Controllers;

public abstract class UserBaseController : ControllerBase
{
    protected IUserMgmtBus Bus { get; private set; }

    public UserBaseController(IUserMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(IUserActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IUserActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromQuery] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpGet(nameof(IUserActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] UserTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetTableByKeySearch(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] UserInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] UserInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(IUserActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] UserSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IUserActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] UserUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(IUserActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] UserUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IUserActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] UserDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(IUserActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] UserDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

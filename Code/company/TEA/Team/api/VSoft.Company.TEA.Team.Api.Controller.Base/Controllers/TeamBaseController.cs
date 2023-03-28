using Microsoft.AspNetCore.Mvc;
using VSoft.Company.TEA.Team.Business.Services;
using VSoft.Company.TEA.Team.Business.Dto.Request;
using VSoft.Company.TEA.Team.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.TEA.Team.Api.Controller.Base.Controllers;

public abstract class TeamBaseController : ControllerBase
{
    protected ITeamMgmtBus Bus { get; private set; }

    public TeamBaseController(ITeamMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(ITeamActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(ITeamActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ITeamActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] TeamInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ITeamActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] TeamInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ITeamActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] TeamSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ITeamActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] TeamUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ITeamActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] TeamUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ITeamActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] TeamDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ITeamActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] TeamDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

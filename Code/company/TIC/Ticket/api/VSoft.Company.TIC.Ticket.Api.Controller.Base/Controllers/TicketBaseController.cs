using Microsoft.AspNetCore.Mvc;
using VSoft.Company.TIC.Ticket.Business.Services;
using VSoft.Company.TIC.Ticket.Business.Dto.Request;
using VSoft.Company.TIC.Ticket.Api.Cfg.Routes;
using VegunSoft.Framework.Business.Dto.Request;

namespace VSoft.Company.TIC.Ticket.Api.Controller.Base.Controllers;

public abstract class TicketBaseController : ControllerBase
{
    protected ITicketMgmtBus Bus { get; private set; }

    public TicketBaseController(ITicketMgmtBus bus)
    {
        Bus = bus;
    }    

    [HttpGet(nameof(ITicketActionName.FindOne))]
    public async Task<IActionResult> FindAsync([FromQuery] MDtoRequestFindByInt dtoRequest)
    {
        var res = await Bus.FindAsync(dtoRequest);
        return Ok(res);
    }

    [HttpGet(nameof(ITicketActionName.FindRange))]
    public async Task<IActionResult> FindRangeAsync([FromBody] MDtoRequestFindRangeByInts dtosRequest)
    {
        var res = await Bus.FindRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ITicketActionName.CreateOne))]
    public async Task<IActionResult> CreateAsync([FromBody] TicketInsertDtoRequest dtoRequest)
    {
        var res = await Bus.CreateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ITicketActionName.CreateRange))]
    public async Task<IActionResult> CreateRangeAsync([FromBody] TicketInsertRangeDtoRequest dtosRequest)
    {
        var res = await Bus.CreateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPost(nameof(ITicketActionName.SaveRange))]
    public async Task<IActionResult> SaveRangeAsync([FromBody] TicketSaveRangeDtoRequest dtosRequest)
    {
        var res = await Bus.SaveRangeTransactionAsync(dtosRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ITicketActionName.UpdateOne))]
    public async Task<IActionResult> UpdateAsync([FromBody] TicketUpdateDtoRequest dtoRequest)
    {
        var res = await Bus.UpdateAsync(dtoRequest);
        return Ok(res);
    }

    [HttpPut(nameof(ITicketActionName.UpdateRange))]
    public async Task<IActionResult> UpdateRangeAsync([FromBody] TicketUpdateRangeDtoRequest dtosRequest)
    {
        var res = await Bus.UpdateRangeAsync(dtosRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ITicketActionName.DeleteOne))]
    public async Task<IActionResult> DeleteAsync([FromBody] TicketDeleteDtoRequest dtoRequest)
    {
        var res = await Bus.DeleteAsync(dtoRequest);
        return Ok(res);
    }

    [HttpDelete(nameof(ITicketActionName.DeleteRange))]
    public async Task<IActionResult> DeleteRangeAsync([FromBody] TicketDeleteRangeDtoRequest dtosRequest)
    {
        var res = await Bus.DeleteRangeAsync(dtosRequest);
        return Ok(res);
    }
}

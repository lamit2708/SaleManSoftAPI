using Microsoft.AspNetCore.Mvc;
using VSoft.Company.TIC.Ticket.Business.Services;
using VSoft.Company.TIC.Ticket.Api.Controller.Base.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using VSoft.Company.TIC.Ticket.Api.Cfg.Routes;

namespace VSoft.Company.TIC.Ticket.Api.Controller.Controllers;

[Route($"{nameof(ITicketControllerPath.Api)}/{nameof(ITicketControllerPath.Ticket)}")]
[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class TicketController : TicketBaseController
{
    public TicketController(ITicketMgmtBus bus) : base(bus)
    {
       
    }
}

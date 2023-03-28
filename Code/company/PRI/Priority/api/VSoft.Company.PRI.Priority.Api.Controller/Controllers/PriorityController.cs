using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRI.Priority.Business.Services;
using VSoft.Company.PRI.Priority.Api.Controller.Base.Controllers;
using VSoft.Company.PRI.Priority.Api.Cfg.Routes;

namespace VSoft.Company.PRI.Priority.Api.Controller.Controllers;

[Route($"{nameof(IPriorityControllerPath.Api)}/{nameof(IPriorityControllerPath.Priority)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class PriorityController : PriorityBaseController
{
    public PriorityController(IPriorityMgmtBus bus) : base(bus)
    {
       
    }
}

using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DEA.Deal.Business.Services;
using VSoft.Company.DEA.Deal.Api.Controller.Base.Controllers;
using VSoft.Company.DEA.Deal.Api.Cfg.Routes;

namespace VSoft.Company.DEA.Deal.Api.Controller.Controllers;

[Route($"{nameof(IDealControllerPath.Api)}/{nameof(IDealControllerPath.Deal)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class DealController : DealBaseController
{
    public DealController(IDealMgmtBus bus) : base(bus)
    {
       
    }
}

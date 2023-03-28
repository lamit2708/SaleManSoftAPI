using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ACT.Activity.Business.Services;
using VSoft.Company.ACT.Activity.Api.Controller.Base.Controllers;
using VSoft.Company.ACT.Activity.Api.Cfg.Routes;

namespace VSoft.Company.ACT.Activity.Api.Controller.Controllers;

[Route($"{nameof(IActivityControllerPath.Api)}/{nameof(IActivityControllerPath.Activity)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class ActivityController : ActivityBaseController
{
    public ActivityController(IActivityMgmtBus bus) : base(bus)
    {
       
    }
}

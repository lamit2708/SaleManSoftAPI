using Microsoft.AspNetCore.Mvc;
using VSoft.Company.TEA.Team.Business.Services;
using VSoft.Company.TEA.Team.Api.Controller.Base.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using VSoft.Company.TEA.Team.Api.Cfg.Routes;

namespace VSoft.Company.TEA.Team.Api.Controller.Controllers;

[Route($"{nameof(ITeamControllerPath.Api)}/{nameof(ITeamControllerPath.Team)}")]
[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class TeamController : TeamBaseController
{
    public TeamController(ITeamMgmtBus bus) : base(bus)
    {
       
    }
}

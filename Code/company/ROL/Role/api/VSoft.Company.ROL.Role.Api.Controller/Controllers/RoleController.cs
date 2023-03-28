using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ROL.Role.Business.Services;
using VSoft.Company.ROL.Role.Api.Controller.Base.Controllers;
using VSoft.Company.ROL.Role.Api.Cfg.Routes;

namespace VSoft.Company.ROL.Role.Api.Controller.Controllers;

[Route($"{nameof(IRoleControllerPath.Api)}/{nameof(IRoleControllerPath.Role)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class RoleController : RoleBaseController
{
    public RoleController(IRoleMgmtBus bus) : base(bus)
    {
       
    }
}

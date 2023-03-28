using Microsoft.AspNetCore.Mvc;
using VSoft.Company.URO.UserRole.Business.Services;
using VSoft.Company.URO.UserRole.Api.Controller.Base.Controllers;
using VSoft.Company.URO.UserRole.Api.Cfg.Routes;

namespace VSoft.Company.URO.UserRole.Api.Controller.Controllers;

[Route($"{nameof(IUserRoleControllerPath.Api)}/{nameof(IUserRoleControllerPath.UserRole)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class UserRoleController : UserRoleBaseController
{
    public UserRoleController(IUserRoleMgmtBus bus) : base(bus)
    {
       
    }
}

using Microsoft.AspNetCore.Mvc;
using VSoft.Company.USR.User.Business.Services;
using VSoft.Company.USR.User.Api.Controller.Base.Controllers;
using VSoft.Company.USR.User.Api.Cfg.Routes;

namespace VSoft.Company.USR.User.Api.Controller.Controllers;

[Route($"{nameof(IUserControllerPath.Api)}/{nameof(IUserControllerPath.User)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class UserController : UserBaseController
{
    public UserController(IUserMgmtBus bus) : base(bus)
    {
       
    }
}

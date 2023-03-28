using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ANW.Anwser.Business.Services;
using VSoft.Company.ANW.Anwser.Api.Controller.Base.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using VSoft.Company.ANW.Anwser.Api.Cfg.Routes;

namespace VSoft.Company.ANW.Anwser.Api.Controller.Controllers;

[Route($"{nameof(IAnwserControllerPath.Api)}/{nameof(IAnwserControllerPath.Anwser)}")]
[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class AnwserController : AnwserBaseController
{
    public AnwserController(IAnwserMgmtBus bus) : base(bus)
    {
       
    }
}

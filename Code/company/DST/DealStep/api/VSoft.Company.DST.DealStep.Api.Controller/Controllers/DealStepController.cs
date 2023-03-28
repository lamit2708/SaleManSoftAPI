using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DST.DealStep.Business.Services;
using VSoft.Company.DST.DealStep.Api.Controller.Base.Controllers;
using VSoft.Company.DST.DealStep.Api.Cfg.Routes;

namespace VSoft.Company.DST.DealStep.Api.Controller.Controllers;

[Route($"{nameof(IDealStepControllerPath.Api)}/{nameof(IDealStepControllerPath.DealStep)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class DealStepController : DealStepBaseController
{
    public DealStepController(IDealStepMgmtBus bus) : base(bus)
    {
       
    }
}

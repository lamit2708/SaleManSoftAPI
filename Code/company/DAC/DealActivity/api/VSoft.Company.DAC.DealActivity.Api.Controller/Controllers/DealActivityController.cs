using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DAC.DealActivity.Business.Services;
using VSoft.Company.DAC.DealActivity.Api.Controller.Base.Controllers;
using VSoft.Company.DAC.DealActivity.Api.Cfg.Routes;

namespace VSoft.Company.DAC.DealActivity.Api.Controller.Controllers;

[Route($"{nameof(IDealActivityControllerPath.Api)}/{nameof(IDealActivityControllerPath.DealActivity)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class DealActivityController : DealActivityBaseController
{
    public DealActivityController(IDealActivityMgmtBus bus) : base(bus)
    {
       
    }
}

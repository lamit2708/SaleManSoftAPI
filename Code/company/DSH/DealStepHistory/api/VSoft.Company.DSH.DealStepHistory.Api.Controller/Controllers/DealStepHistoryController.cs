using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DSH.DealStepHistory.Business.Services;
using VSoft.Company.DSH.DealStepHistory.Api.Controller.Base.Controllers;
using VSoft.Company.DSH.DealStepHistory.Api.Cfg.Routes;

namespace VSoft.Company.DSH.DealStepHistory.Api.Controller.Controllers;

[Route($"{nameof(IDealStepHistoryControllerPath.Api)}/{nameof(IDealStepHistoryControllerPath.DealStepHistory)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class DealStepHistoryController : DealStepHistoryBaseController
{
    public DealStepHistoryController(IDealStepHistoryMgmtBus bus) : base(bus)
    {
       
    }
}

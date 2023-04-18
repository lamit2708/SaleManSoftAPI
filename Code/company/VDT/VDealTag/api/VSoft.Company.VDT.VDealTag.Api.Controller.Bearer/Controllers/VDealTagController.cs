using Microsoft.AspNetCore.Mvc;
using VSoft.Company.VDT.VDealTag.Business.Services;
using VSoft.Company.VDT.VDealTag.Api.Controller.Base.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using VSoft.Company.VDT.VDealTag.Api.Cfg.Routes;

namespace VSoft.Company.VDT.VDealTag.Api.Controller.Controllers;

[Route($"{nameof(IVDealTagControllerPath.Api)}/{nameof(IVDealTagControllerPath.VDealTag)}")]
[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class VDealTagController : VDealTagBaseController
{
    public VDealTagController(IVDealTagMgmtBus bus) : base(bus)
    {
       
    }
}

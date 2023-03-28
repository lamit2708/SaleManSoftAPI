using Microsoft.AspNetCore.Mvc;
using VSoft.Company.DQU.DealQuotation.Business.Services;
using VSoft.Company.DQU.DealQuotation.Api.Controller.Base.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using VSoft.Company.DQU.DealQuotation.Api.Cfg.Routes;

namespace VSoft.Company.DQU.DealQuotation.Api.Controller.Controllers;

[Route($"{nameof(IDealQuotationControllerPath.Api)}/{nameof(IDealQuotationControllerPath.DealQuotation)}")]
[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class DealQuotationController : DealQuotationBaseController
{
    public DealQuotationController(IDealQuotationMgmtBus bus) : base(bus)
    {
       
    }
}

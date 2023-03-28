using Microsoft.AspNetCore.Mvc;
using VSoft.Company.CIN.CustomerInfo.Business.Services;
using VSoft.Company.CIN.CustomerInfo.Api.Controller.Base.Controllers;
using VSoft.Company.CIN.CustomerInfo.Api.Cfg.Routes;

namespace VSoft.Company.CIN.CustomerInfo.Api.Controller.Controllers;

[Route($"{nameof(ICustomerInfoControllerPath.Api)}/{nameof(ICustomerInfoControllerPath.CustomerInfo)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class CustomerInfoController : CustomerInfoBaseController
{
    public CustomerInfoController(ICustomerInfoMgmtBus bus) : base(bus)
    {
       
    }
}

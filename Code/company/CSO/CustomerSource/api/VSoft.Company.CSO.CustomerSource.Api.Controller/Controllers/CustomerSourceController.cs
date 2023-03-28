using Microsoft.AspNetCore.Mvc;
using VSoft.Company.CSO.CustomerSource.Business.Services;
using VSoft.Company.CSO.CustomerSource.Api.Controller.Base.Controllers;
using VSoft.Company.CSO.CustomerSource.Api.Cfg.Routes;

namespace VSoft.Company.CSO.CustomerSource.Api.Controller.Controllers;

[Route($"{nameof(ICustomerSourceControllerPath.Api)}/{nameof(ICustomerSourceControllerPath.CustomerSource)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class CustomerSourceController : CustomerSourceBaseController
{
    public CustomerSourceController(ICustomerSourceMgmtBus bus) : base(bus)
    {
       
    }
}

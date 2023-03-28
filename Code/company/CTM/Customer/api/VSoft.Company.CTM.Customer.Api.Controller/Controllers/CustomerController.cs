using Microsoft.AspNetCore.Mvc;
using VSoft.Company.CTM.Customer.Business.Services;
using VSoft.Company.CTM.Customer.Api.Controller.Base.Controllers;
using VSoft.Company.CTM.Customer.Api.Cfg.Routes;

namespace VSoft.Company.CTM.Customer.Api.Controller.Controllers;

[Route($"{nameof(ICustomerControllerPath.Api)}/{nameof(ICustomerControllerPath.Customer)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class CustomerController : CustomerBaseController
{
    public CustomerController(ICustomerMgmtBus bus) : base(bus)
    {
       
    }
}

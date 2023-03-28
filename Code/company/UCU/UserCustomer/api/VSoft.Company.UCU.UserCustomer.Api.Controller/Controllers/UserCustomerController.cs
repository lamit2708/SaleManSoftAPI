using Microsoft.AspNetCore.Mvc;
using VSoft.Company.UCU.UserCustomer.Business.Services;
using VSoft.Company.UCU.UserCustomer.Api.Controller.Base.Controllers;
using VSoft.Company.UCU.UserCustomer.Api.Cfg.Routes;

namespace VSoft.Company.UCU.UserCustomer.Api.Controller.Controllers;

[Route($"{nameof(IUserCustomerControllerPath.Api)}/{nameof(IUserCustomerControllerPath.UserCustomer)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class UserCustomerController : UserCustomerBaseController
{
    public UserCustomerController(IUserCustomerMgmtBus bus) : base(bus)
    {
       
    }
}

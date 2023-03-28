using Microsoft.AspNetCore.Mvc;
using VSoft.Company.ORD.Order.Business.Services;
using VSoft.Company.ORD.Order.Api.Controller.Base.Controllers;
using VSoft.Company.ORD.Order.Api.Cfg.Routes;

namespace VSoft.Company.ORD.Order.Api.Controller.Controllers;

[Route($"{nameof(IOrderControllerPath.Api)}/{nameof(IOrderControllerPath.Order)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class OrderController : OrderBaseController
{
    public OrderController(IOrderMgmtBus bus) : base(bus)
    {
       
    }
}

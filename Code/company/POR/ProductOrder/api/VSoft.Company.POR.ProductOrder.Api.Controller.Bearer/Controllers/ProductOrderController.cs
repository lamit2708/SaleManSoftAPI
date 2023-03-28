using Microsoft.AspNetCore.Mvc;
using VSoft.Company.POR.ProductOrder.Business.Services;
using VSoft.Company.POR.ProductOrder.Api.Controller.Base.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using VSoft.Company.POR.ProductOrder.Api.Cfg.Routes;

namespace VSoft.Company.POR.ProductOrder.Api.Controller.Controllers;

[Route($"{nameof(IProductOrderControllerPath.Api)}/{nameof(IProductOrderControllerPath.ProductOrder)}")]
[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class ProductOrderController : ProductOrderBaseController
{
    public ProductOrderController(IProductOrderMgmtBus bus) : base(bus)
    {
       
    }
}

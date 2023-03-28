using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRO.Product.Business.Services;
using VSoft.Company.PRO.Product.Api.Controller.Base.Controllers;
using VSoft.Company.PRO.Product.Api.Cfg.Routes;

namespace VSoft.Company.PRO.Product.Api.Controller.Controllers;

[Route($"{nameof(IProductControllerPath.Api)}/{nameof(IProductControllerPath.Product)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class ProductController : ProductBaseController
{
    public ProductController(IProductMgmtBus bus) : base(bus)
    {
       
    }
}

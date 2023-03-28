using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRC.ProductCategory.Business.Services;
using VSoft.Company.PRC.ProductCategory.Api.Controller.Base.Controllers;
using VSoft.Company.PRC.ProductCategory.Api.Cfg.Routes;

namespace VSoft.Company.PRC.ProductCategory.Api.Controller.Controllers;

[Route($"{nameof(IProductCategoryControllerPath.Api)}/{nameof(IProductCategoryControllerPath.ProductCategory)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class ProductCategoryController : ProductCategoryBaseController
{
    public ProductCategoryController(IProductCategoryMgmtBus bus) : base(bus)
    {

    }
}

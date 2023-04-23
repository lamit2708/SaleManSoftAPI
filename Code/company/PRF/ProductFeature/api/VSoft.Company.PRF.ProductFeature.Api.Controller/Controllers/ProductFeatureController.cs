using Microsoft.AspNetCore.Mvc;
using VSoft.Company.PRF.ProductFeature.Business.Services;
using VSoft.Company.PRF.ProductFeature.Api.Controller.Base.Controllers;
using VSoft.Company.PRF.ProductFeature.Api.Cfg.Routes;

namespace VSoft.Company.PRF.ProductFeature.Api.Controller.Controllers;

[Route($"{nameof(IProductFeatureControllerPath.Api)}/{nameof(IProductFeatureControllerPath.ProductFeature)}")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
public class ProductFeatureController : ProductFeatureBaseController
{
    public ProductFeatureController(IProductFeatureMgmtBus bus) : base(bus)
    {

    }
}

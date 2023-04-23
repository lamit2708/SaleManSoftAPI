using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.PRF.ProductFeature.Api.Cfg.Routes
{
    public interface IProductFeatureControllerPath : IApiControllerPath
    {
        string? ProductFeature { get; set; }
    }
}

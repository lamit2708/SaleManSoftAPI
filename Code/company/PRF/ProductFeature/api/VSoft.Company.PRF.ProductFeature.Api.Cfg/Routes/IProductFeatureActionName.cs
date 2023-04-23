using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.PRF.ProductFeature.Api.Cfg.Routes
{
    public interface IProductFeatureActionName : IApiActionName
    {
        string? FindTable { get; set; }
    }
}

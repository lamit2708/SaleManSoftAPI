using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.PRO.Product.Api.Cfg.Routes
{
    public interface IProductControllerPath: IApiControllerPath
    {
        string? Product { get; set; }
    }
}

using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.POR.ProductOrder.Api.Cfg.Routes
{
    public interface IProductOrderControllerPath: IApiControllerPath
    {
        string? ProductOrder { get; set; }
    }
}

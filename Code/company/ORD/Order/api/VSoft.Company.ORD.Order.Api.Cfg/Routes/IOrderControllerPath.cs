using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.ORD.Order.Api.Cfg.Routes
{
    public interface IOrderControllerPath: IApiControllerPath
    {
        string? Order { get; set; }
    }
}

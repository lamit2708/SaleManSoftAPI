using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.DEA.Deal.Api.Cfg.Routes
{
    public interface IDealControllerPath: IApiControllerPath
    {
        string? Deal { get; set; }
    }
}

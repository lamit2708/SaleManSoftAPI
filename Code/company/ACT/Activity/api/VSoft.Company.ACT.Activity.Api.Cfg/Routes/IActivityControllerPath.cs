using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.ACT.Activity.Api.Cfg.Routes
{
    public interface IActivityControllerPath: IApiControllerPath
    {
        string? Activity { get; set; }
    }
}

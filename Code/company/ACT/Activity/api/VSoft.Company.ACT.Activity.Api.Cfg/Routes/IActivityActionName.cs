using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.ACT.Activity.Api.Cfg.Routes
{
    public interface IActivityActionName: IApiActionName
    {
        string? FindTable { get; set; }
    }
}

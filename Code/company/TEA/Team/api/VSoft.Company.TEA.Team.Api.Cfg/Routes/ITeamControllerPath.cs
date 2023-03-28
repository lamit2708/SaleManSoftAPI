using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.TEA.Team.Api.Cfg.Routes
{
    public interface ITeamControllerPath: IApiControllerPath
    {
        string? Team { get; set; }
    }
}

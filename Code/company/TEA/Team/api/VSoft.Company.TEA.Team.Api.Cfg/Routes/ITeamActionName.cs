using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.TEA.Team.Api.Cfg.Routes
{
    public interface ITeamActionName: IApiActionName
    {
        string? FindTable { get; set; }
    }
}

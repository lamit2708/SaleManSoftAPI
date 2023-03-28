using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.USR.User.Api.Cfg.Routes
{
    public interface IUserControllerPath: IApiControllerPath
    {
        string? User { get; set; }
    }
}

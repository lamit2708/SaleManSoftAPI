using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.ROL.Role.Api.Cfg.Routes
{
    public interface IRoleControllerPath: IApiControllerPath
    {
        string? Role { get; set; }
    }
}

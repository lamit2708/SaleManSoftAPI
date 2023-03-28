using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.URO.UserRole.Api.Cfg.Routes
{
    public interface IUserRoleControllerPath: IApiControllerPath
    {
        string? UserRole { get; set; }
    }
}

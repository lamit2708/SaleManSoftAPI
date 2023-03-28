using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.PRI.Priority.Api.Cfg.Routes
{
    public interface IPriorityControllerPath: IApiControllerPath
    {
        string? Priority { get; set; }
    }
}

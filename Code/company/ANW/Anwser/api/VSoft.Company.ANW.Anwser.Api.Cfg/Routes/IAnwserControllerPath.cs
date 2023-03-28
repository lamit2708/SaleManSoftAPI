using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.ANW.Anwser.Api.Cfg.Routes
{
    public interface IAnwserControllerPath: IApiControllerPath
    {
        string? Anwser { get; set; }
    }
}

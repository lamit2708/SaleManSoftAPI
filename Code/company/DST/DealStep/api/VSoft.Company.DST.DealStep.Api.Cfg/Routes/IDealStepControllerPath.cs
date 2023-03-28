using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.DST.DealStep.Api.Cfg.Routes
{
    public interface IDealStepControllerPath: IApiControllerPath
    {
        string? DealStep { get; set; }
    }
}

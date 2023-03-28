using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.DSH.DealStepHistory.Api.Cfg.Routes
{
    public interface IDealStepHistoryControllerPath: IApiControllerPath
    {
        string? DealStepHistory { get; set; }
    }
}

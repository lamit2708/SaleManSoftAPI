using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.VDT.VDealTag.Api.Cfg.Routes
{
    public interface IVDealTagControllerPath: IApiControllerPath
    {
        string? VDealTag { get; set; }
    }
}

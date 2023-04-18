using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.VDT.VDealTag.Api.Cfg.Routes
{
    public interface IVDealTagActionName: IApiActionName
    {
        string? FindTable { get; set; }
    }
}

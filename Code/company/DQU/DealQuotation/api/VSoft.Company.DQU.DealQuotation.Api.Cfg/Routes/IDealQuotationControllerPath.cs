using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.DQU.DealQuotation.Api.Cfg.Routes
{
    public interface IDealQuotationControllerPath: IApiControllerPath
    {
        string? DealQuotation { get; set; }
    }
}

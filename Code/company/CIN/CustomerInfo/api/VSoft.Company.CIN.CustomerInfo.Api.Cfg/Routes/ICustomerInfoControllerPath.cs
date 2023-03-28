using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.CIN.CustomerInfo.Api.Cfg.Routes
{
    public interface ICustomerInfoControllerPath: IApiControllerPath
    {
        string? CustomerInfo { get; set; }
    }
}

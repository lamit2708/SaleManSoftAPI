using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.CSO.CustomerSource.Api.Cfg.Routes
{
    public interface ICustomerSourceControllerPath: IApiControllerPath
    {
        string? CustomerSource { get; set; }
    }
}

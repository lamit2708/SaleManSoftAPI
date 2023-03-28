using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.CTM.Customer.Api.Cfg.Routes
{
    public interface ICustomerControllerPath: IApiControllerPath
    {
        string? Customer { get; set; }
    }
}

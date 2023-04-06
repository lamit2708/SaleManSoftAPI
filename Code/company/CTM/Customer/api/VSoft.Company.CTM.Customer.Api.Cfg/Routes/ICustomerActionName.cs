using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.CTM.Customer.Api.Cfg.Routes
{
    public interface ICustomerActionName: IApiActionName
    {
        string? FindTable { get; set; }
    }
}

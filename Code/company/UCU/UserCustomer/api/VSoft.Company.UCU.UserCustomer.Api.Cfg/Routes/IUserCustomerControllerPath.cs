using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.UCU.UserCustomer.Api.Cfg.Routes
{
    public interface IUserCustomerControllerPath: IApiControllerPath
    {
        string? UserCustomer { get; set; }
    }
}

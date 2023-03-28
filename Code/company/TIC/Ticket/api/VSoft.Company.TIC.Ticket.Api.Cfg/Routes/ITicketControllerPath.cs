using VegunSoft.Framework.Api.Route.Bases;

namespace VSoft.Company.TIC.Ticket.Api.Cfg.Routes
{
    public interface ITicketControllerPath: IApiControllerPath
    {
        string? Ticket { get; set; }
    }
}

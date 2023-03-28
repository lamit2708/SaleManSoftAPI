using VegunSoft.Framework.Api.DtoClient.Cfg.Models;

namespace VSoft.Company.TIC.Ticket.Client.Models
{
    public class MTicketClient: MClientConfigKeys
    {
        public override string SectionKey { get; set; } = "Ticket";
    }
}

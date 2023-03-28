using VegunSoft.Framework.Api.DtoClient.Cfg.Models;

namespace VSoft.Company.ORD.Order.Client.Models
{
    public class MOrderClient: MClientConfigKeys
    {
        public override string SectionKey { get; set; } = "Order";
    }
}

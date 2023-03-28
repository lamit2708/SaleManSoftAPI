using VegunSoft.Framework.Api.DtoClient.Cfg.Models;

namespace VSoft.Company.POR.ProductOrder.Client.Models
{
    public class MProductOrderClient: MClientConfigKeys
    {
        public override string SectionKey { get; set; } = "ProductOrder";
    }
}

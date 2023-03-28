using VegunSoft.Framework.Api.DtoClient.Cfg.Models;

namespace VSoft.Company.USR.User.Client.Models
{
    public class MUserClient: MClientConfigKeys
    {
        public override string SectionKey { get; set; } = "User";
    }
}

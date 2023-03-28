using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.TEA.Team.Data.Entity.Models
{
    public class MTeamEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}

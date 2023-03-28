using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.DST.DealStep.Data.Entity.Models
{
    public class MDealStepEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }
    }
}

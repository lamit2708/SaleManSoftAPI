using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.PRI.Priority.Data.Entity.Models
{
    public class MPriorityEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}

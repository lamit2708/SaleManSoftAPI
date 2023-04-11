using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.ACT.Activity.Data.Entity.Models
{
    public class MActivityEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Content { get; set; }
        public string? ActivityType { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string? ToWho { get; set; }
        public string? SubType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedUser { get; set; }
    }
}

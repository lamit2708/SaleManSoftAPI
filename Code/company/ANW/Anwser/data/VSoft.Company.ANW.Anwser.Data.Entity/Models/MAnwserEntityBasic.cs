using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.ANW.Anwser.Data.Entity.Models
{
    public class MAnwserEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public string Content { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        public long QuestionId { get; set; }
    }
}

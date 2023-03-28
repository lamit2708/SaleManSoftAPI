using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.QUE.Question.Data.Entity.Models
{
    public class MQuestionEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public string Description { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public int TicketId { get; set; }
    }
}

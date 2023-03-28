
namespace VSoft.Company.QUE.Question.Business.Dto.Data
{
    public class QuestionDto
    {
        public long Id { get; set; }

        public string Description { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public int TicketId { get; set; }

        public override string ToString()
        {
            return $"{Id} / {TicketId}";
        }
    }
}

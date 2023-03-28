namespace VSoft.Company.ANW.Anwser.Business.Dto.Data
{
    public class AnwserDto
    {
        public long Id { get; set; }

        public string Content { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        public long QuestionId { get; set; }

        public override string ToString()
        {
            return $"{Id} / {QuestionId}";
        }
    }
}

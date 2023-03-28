namespace VSoft.Company.DAC.DealActivity.Business.Dto.Data
{
    public class DealActivityDto
    {
        public int Id { get; set; }

        public long DealId { get; set; }

        public int ActivityId { get; set; }

        public string Subject { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        public override string ToString()
        {
            return $"{Id} / {DealId}";
        }
    }
}

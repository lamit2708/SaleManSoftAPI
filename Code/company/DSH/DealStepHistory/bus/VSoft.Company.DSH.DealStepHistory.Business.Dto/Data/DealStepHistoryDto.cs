namespace VSoft.Company.DSH.DealStepHistory.Business.Dto.Data
{
    public class DealStepHistoryDto
    {
        public long Id { get; set; }

        public int DealStepId { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }

        public override string ToString()
        {
            return $"{Id} / {DealStepId}";
        }
    }
}

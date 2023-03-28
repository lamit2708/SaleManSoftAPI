using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.DSH.DealStepHistory.Data.Entity.Models
{
    public class MDealStepHistoryEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public int DealStepId { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }
    }
}

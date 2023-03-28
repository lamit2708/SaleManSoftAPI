using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.DAC.DealActivity.Data.Entity.Models
{
    public class MDealActivityEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public long DealId { get; set; }

        public int ActivityId { get; set; }

        public string Subject { get; set; } = null!;

        public string Content { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
    }
}

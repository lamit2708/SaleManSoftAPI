using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSoft.Company.ORD.Order.Business.Dto.Data
{
    public class OrderDto
    {
        public int Id { get; set; }

        public long CustomerId { get; set; }

        public int UserId { get; set; }
        public long DealId { get; set; }

        public DateTime? CreatedDate { get; set; }
        public bool IsDraft { get; set; }

        public override string ToString()
        {
            return $"{Id} / {CustomerId}";
        }
    }
}

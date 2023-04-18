using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.VDT.VDealTag.Data.Entity.Models
{
    public class MVDealTagEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }
        public string? DealName { get; set; }
        public long CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public double PridictPrice { get; set; }
        public int DealStepId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.CTM.Customer.Data.Entity.Models
{
    public class MCustomerEntityBasic : IIdEntity<long>
    {
        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Address { get; set; }

        /// <summary>
        /// True: Male, False: Female
        /// </summary>
        public bool? Gender { get; set; } = false;

        public int? PriorityId { get; set; }

        public long? CustomerInfoId { get; set; }

        public bool IsBought { get; set; }

        public string? Keyword { get; set; }
    }
}

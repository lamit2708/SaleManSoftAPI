
using VegunSoft.Framework.Entity.Key.Base;

namespace VSoft.Company.TIC.Ticket.Data.Entity.Models
{
    public class MTicketEntityBasic : IIdEntity<int>
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public long CustomerId { get; set; }
    }
}

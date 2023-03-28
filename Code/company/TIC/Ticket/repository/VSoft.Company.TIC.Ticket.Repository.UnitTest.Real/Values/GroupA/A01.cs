using VSoft.Company.TIC.Ticket.Data.Entity.Models;
using VSoft.Company.TIC.Ticket.Repository.UnitTest.Bases;

namespace VSoft.Company.TIC.Ticket.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MTicketEntity Entity => new MTicketEntity()
        {
            Id = 1,
        };
    }
}

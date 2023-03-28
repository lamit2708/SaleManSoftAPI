using VSoft.Company.TIC.Ticket.Business.Dto.Data;
using VSoft.Company.TIC.Ticket.Business.UnitTest.Bases;

namespace VSoft.Company.TIC.Ticket.Business.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override TicketDto Dto => new TicketDto()
        {
         
            //Name = "Đặng Thế Nhân",
            Id = 1
        };
    }
}

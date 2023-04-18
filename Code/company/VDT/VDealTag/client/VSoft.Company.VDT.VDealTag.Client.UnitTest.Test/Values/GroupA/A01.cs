using VSoft.Company.VDT.VDealTag.Business.Dto.Data;
using VSoft.Company.VDT.VDealTag.Client.UnitTest.Bases;

namespace VSoft.Company.VDT.VDealTag.Client.UnitTest.Test.Values.GroupA
{
    public class A01 : TestDto
    {
        protected override VDealTagDto Dto => new VDealTagDto()
        {
            CustomerName = "Đặng Thế Nhân",
        };
    }
}

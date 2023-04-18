using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
using VSoft.Company.VDT.VDealTag.Repository.UnitTest.Bases;

namespace VSoft.Company.VDT.VDealTag.Repository.UnitTest.Real.Values.GroupA
{
    public class A01 : TestEntity
    {
        protected override MVDealTagEntity Entity => new MVDealTagEntity()
        {
            //Id = 63452,
          
            CustomerName = "Đặng Thế Nhân",
           
        };
    }
}

using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ORD.Order.Business.Dto.Data;
using VSoft.Company.ORD.Order.Business.Dto.Request;
using VSoft.Company.ORD.Order.Business.UnitTest.Bases;

namespace VSoft.Company.ORD.Order.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal : TestOrderMgmt
    {
        [TestMethod]
        [DataRow(1)]
        public async Task FindAsync(int id)
        {
            await TestFindAsync(new MDtoRequestFindByInt()
            {
                Id = id,
            });
        }

        [TestMethod]
        [DataRow(63494, 63495, 63496)]
        public async Task FindRangeAsync(int id1, int id2, int id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByInts()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }

        [TestMethod]
        [DataRow(1, 1, 1,true)]
        public async Task TestCreate(long customerId, int userId, long dealId, bool isDraft)
        {
            var e = new OrderDto();
            e.CustomerId = customerId;
            e.UserId = userId;
            e.DealId = dealId;
            e.IsDraft = isDraft;

            await TestCreateAsync(new OrderInsertDtoRequest()
            {
                Data = e
            });
        }

        //[TestMethod]
        //[DataRow(1,1, 1, 1, true)]
        //public async Task TestUpdate()
        //{
        //    await TestUpdateAsync(new OrderUpdateDtoRequest()
        //    {
        //        Data = new OrderDto()
        //        {
                   
        //        }
        //    });
        //}

        [TestMethod]
        [DataRow(1)]
        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new OrderDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
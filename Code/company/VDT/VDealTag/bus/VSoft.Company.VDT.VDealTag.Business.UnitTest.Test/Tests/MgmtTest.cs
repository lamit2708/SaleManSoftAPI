using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.UnitTest.Bases;

namespace VSoft.Company.VDT.VDealTag.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtTest : TestVDealTagMgmt
    {

        [TestMethod]
        [DataRow(1, DisplayName = "Case 1")]
        [DataRow("1fbdbe39-a443-4403-bb81-d4c070f18762", DisplayName = "Case 2")]
        public async Task GetFullNameByIdAsync(int id)
        {
            await TestGetFullNameByIdAsync(new MDtoRequestFindByLong()
            {
                Id = id
            });
        }

        [TestMethod]
        [DataRow(63454)]
        [DataRow(63492)]
        [DataRow(63493)]
        public async Task FindAsync(int id)
        {
            await TestFindAsync(new MDtoRequestFindByLong()
            {
                Id = id,
            });
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        public async Task FindRangeAsync(long id1, long id2, long id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByLongs()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }
    }
}
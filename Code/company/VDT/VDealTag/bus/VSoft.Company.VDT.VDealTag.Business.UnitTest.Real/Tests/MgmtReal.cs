using System.Globalization;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Data;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.UnitTest.Bases;

namespace VSoft.Company.VDT.VDealTag.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal: TestVDealTagMgmt
    {
        [TestMethod]
        [DataRow(63491)]
        [DataRow(63492)]
        [DataRow(63493)]
        public async Task FindAsync(long id)
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
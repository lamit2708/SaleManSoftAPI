using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Api.UnitTest.Client.Bases;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Client.UnitTest.Test.Values.GroupA;

namespace VSoft.Company.VDT.VDealTag.Client.UnitTest.Test.Tests;

[TestClass]
public class MgmtTest : TestMgmtClient
{
    [TestMethod]
    [DataRow("DRV1-9084", DisplayName = "Case 1")]
    [DataRow("1fbdbe39-a443-4403-bb81-d4c070f18762", DisplayName = "Case 2")]
    public async Task FindAsync(string id)
    {
        await TestFindAsync(new MDtoRequestFindByString()
        {
            Id = id,
            ShowExMessage = true,
            ShowExContent = true,
            LangCode= "VN",           
        });
    }

    [TestMethod]
    [DataRow(63454, 63452, 63496)]
    public async Task FindRangeAsync(int id1, int id2, int id3)
    {
        await TestFindRangeAsync(new MDtoRequestFindRangeByStrings()
        {
            Ids = new[] { id1.ToString(), id2.ToString(), id3.ToString() },
        });
    }
}
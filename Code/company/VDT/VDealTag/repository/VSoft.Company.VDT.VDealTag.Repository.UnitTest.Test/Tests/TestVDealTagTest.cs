using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
using VSoft.Company.VDT.VDealTag.Repository.UnitTest.Bases;
using VSoft.Company.VDT.VDealTag.Repository.UnitTest.Test.Values.GroupA;

namespace VSoft.Company.VDT.VDealTag.Repository.UnitTest.Test.Tests;

[TestClass]
public class TestVDealTagTest : TestMgmtEntities
{

    protected override string TestName { get; set; } = "Test";

    [TestMethod]
    [DataRow(1, DisplayName = "Case 1")]
    [DataRow(2, DisplayName = "Case 2")]
        
    public async Task GetFullNameByIdAsync(int id)
    {
        await TestGetFullNameByIdAsync(id);
       
    }
    [TestMethod]
    [DataRow(1, DisplayName = "Case 1")]
    [DataRow(2, DisplayName = "Case 2")]
    public async Task GetVDealTagByNameAsync(string name)
    {
        
        await RunTest("TestGetByIdAsync", async (r, log) =>
        {
            var e = await (r?.GetVDealTagsByNameAsync(name) ?? Task.FromResult(new List<MVDealTagEntity>()));
            log(e.FirstOrDefault()?.CustomerName ?? string.Empty);
        });
    }


    [TestMethod]
    [DataRow(1, DisplayName = "GetByIdAsync > 1")]
    [DataRow(2, DisplayName = "GetByIdAsync > 2")]
    public async Task GetByIdAsync(int id)
    {
        await TestGetByIdAsync(id);
    }
}
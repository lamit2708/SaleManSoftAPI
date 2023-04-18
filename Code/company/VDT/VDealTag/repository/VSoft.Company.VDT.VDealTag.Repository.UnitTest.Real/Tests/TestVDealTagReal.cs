using Google.Protobuf.WellKnownTypes;
using System.Globalization;
using System.Reflection;
using VSoft.Company.VDT.VDealTag.Data.Entity.Models;
using VSoft.Company.VDT.VDealTag.Repository.UnitTest.Bases;
using VSoft.Company.VDT.VDealTag.Repository.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.VDT.VDealTag.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestVDealTagReal : TestMgmtEntities
{
	protected override string TestName { get; set; } = "Real";

	[TestMethod]
	[DataRow(5, DisplayName = "GetByIdAsync > 1")]
	[DataRow(6, DisplayName = "GetByIdAsync > 2")]
	public async Task GetByIdAsync(long id)
	{
		await TestGetByIdAsync(id);
	}

	[TestMethod]
	[DataRow("l")]
	[DataRow("phat")]
	public async Task GetVDealTagByNameAsync(string name)
	{

		await RunTest("GetVDealTagByNameAsync", async (r, log) =>
		{
			var e = await (r?.GetVDealTagsByNameAsync(name) ?? Task.FromResult(new List<MVDealTagEntity>()));
			e.ForEach(x => log(x.CustomerName));
			//log(e.FirstOrDefault()?.Name ?? string.Empty);
		});
	}
}
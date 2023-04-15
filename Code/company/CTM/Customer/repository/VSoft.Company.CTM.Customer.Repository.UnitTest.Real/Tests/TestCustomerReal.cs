using Google.Protobuf.WellKnownTypes;
using System.Globalization;
using System.Reflection;
using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.UnitTest.Bases;
using VSoft.Company.CTM.Customer.Repository.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.CTM.Customer.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestCustomerReal : TestMgmtEntities
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
	[DataRow("Lê Ngọc Lan", "0434634266", "lanngoc@gmail.com", "66 Phạm Văn Đồng, TP Thủ Đức", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
	public async Task CreateAsync(string fullName, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
	{
		var e = new A01().GetCreateEntity();
		e.Name = fullName;
		e.Phone = phone;
		e.Email = email;
		e.Address = address;
		e.Gender = gender;
		e.BirthDate = DateTime.ParseExact(birthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
		e.PriorityId = priorityId;
		e.CustomerSourceId = customerSourceId;
		e.IsMarrage = isMarrage;
		e.Hobby = hobby;
		e.Job = job;
		e.IsBought = isBought;
		await TestCreateAsync(e);
	}

	[TestMethod]
	// [DataRow("Đặng Thế Nhân1", "35049843957", "aaa@gmail.com")]
	// [DataRow("Lê Vũ Lâm1", "02345332565", "abc@yahoo.com")]
	[DataRow("Lê Ngọc Lan", "0434634266", "lanngoc@gmail.com", "66 Phạm Văn Đồng, TP Thủ Đức", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
	public async Task CreateWithKeywordAsync(string fullName, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
	{
		var e = new A01().GetCreateEntity();
		e.Name = fullName;
		e.Phone = phone;
		e.Email = email;
		e.Address = address;
		e.Gender = gender;
		e.BirthDate = DateTime.ParseExact(birthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
		e.PriorityId = priorityId;
		e.CustomerSourceId = customerSourceId;
		e.IsMarrage = isMarrage;
		e.Hobby = hobby;
		e.Job = job;
		e.IsBought = isBought;
		await RunTest("CreateWithKeywordAsync", async (r, l) =>
		{
			var res = r?.CreateWithKeyword(e);
			LogEntity(res, l);
		});
	}

	[TestMethod]
	[DataRow(25, "Nguyễn Thị Tuyết", "0434634277", "tuyetthi@gmail.com", "77 Lý Thường Kiệt,Q10, TP HCM", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
	[DataRow(26, "Lê Ngọc Lan", "0434634266", "lanngoc@gmail.com", "66 Phạm Văn Đồng, TP Thủ Đức", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
	public async Task UpdateAsync(long id, string fullName, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
	{
		await TestUpdateAsync(new MCustomerEntity()
		{
			Id = id,
			Name = fullName,
			Phone = phone,
			Email = email,
			Address = address,
			Gender = gender,
			BirthDate = DateTime.ParseExact(birthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture),
			PriorityId = priorityId,
			CustomerSourceId = customerSourceId,
			IsMarrage = isMarrage,
			Hobby = hobby,
			Job = job,
			IsBought = isBought,
		});
	}
	[TestMethod]
	[DataRow(25, "Nguyễn Thị Tuyết", "0434634277", "tuyetthi@gmail.com", "77 Lý Thường Kiệt,Q10, TP HCM", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
	[DataRow(26, "Lê Ngọc Lan", "0434634266", "lanngoc@gmail.com", "66 Phạm Văn Đồng, TP Thủ Đức", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
	public async Task UpdateWithKeywordAsync(long id, string fullName, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
	{
		var newEntity = new MCustomerEntity()
		{
			Id = id,
			Name = fullName,
			Phone = phone,
			Email = email,
			Address = address,
			Gender = gender,
			BirthDate = DateTime.ParseExact(birthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture),
			PriorityId = priorityId,
			CustomerSourceId = customerSourceId,
			IsMarrage = isMarrage,
			Hobby = hobby,
			Job = job,
			IsBought = isBought,
		};
		await RunTest("TestUpdateCustomer", async (r, l) =>
		{
			// var dbEntity = await (r?.GetByIdAsync(newEntity.Id) ?? Task.FromResult<MCustomerEntity?>(null));

			var e = r?.UpdateWithKeyword(newEntity);
			LogEntity(e, l);
			return;

			l($"Id: {newEntity?.Id} update false!");
		});
	}

	[TestMethod]
	[DataRow(1)]
	public async Task DeleteAsync(long id)
	{

		await TestDeleteAsync(id);
	}

	[TestMethod]
	[DataRow("l")]
	[DataRow("phat")]
	public async Task GetCustomerByNameAsync(string name)
	{

		await RunTest("GetCustomerByNameAsync", async (r, log) =>
		{
			var e = await (r?.GetCustomersByNameAsync(name) ?? Task.FromResult(new List<MCustomerEntity>()));
			e.ForEach(x => log(x.Name));
			//log(e.FirstOrDefault()?.Name ?? string.Empty);
		});
	}
}
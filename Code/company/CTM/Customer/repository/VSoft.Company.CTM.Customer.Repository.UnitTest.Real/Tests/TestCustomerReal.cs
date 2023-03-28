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
    [DataRow("Đặng Thế Nhân", "3504984957", "aaa@gmail.com")]
    [DataRow("Lê Vũ Lâm", "0234532565", "abc@yahoo.com")]
    [DataRow("Nguyễn Tấn Phát", "54235235236", "xyz@gmail.com")]
    public async Task CreateAsync(string fullName, string phone, string email)
    {
        var e = new A01().GetCreateEntity();
        e.Name = fullName;
        e.Phone = phone;
        e.Email = email;

        await TestCreateAsync(e);
    }

    [TestMethod]
    // [DataRow("Đặng Thế Nhân1", "35049843957", "aaa@gmail.com")]
    // [DataRow("Lê Vũ Lâm1", "02345332565", "abc@yahoo.com")]
    [DataRow("Nguyễn Tấn Phát2", "5434634858", "xyz133@gmail.com")]
    public async Task CreateWithKeywordAsync(string fullName, string phone, string email)
    {
        var e = new A01().GetCreateEntity();
        e.Name = fullName;
        e.Phone = phone;
        e.Email = email;

        await RunTest("CreateWithKeywordAsync", async (r, l) =>
        {
            var res = r?.CreateWithKeyword(e);
            LogEntity(res, l);
        });
    }

    [TestMethod]
    [DataRow(4, "Đặng Thế Nhân", "@3504984957", "aaa@gmail.com")]
    [DataRow(5, "Lê Vũ Lâm", "@0234532565", "abc@yahoo.com")]
    [DataRow(6, "Nguyễn Tấn Phát", "@54235235236", "xyz@gmail.com")]
    public async Task UpdateAsync(long id, string fullName, string phone, string email)
    {
        await TestUpdateAsync(new MCustomerEntity()
        {
            Id = id,
            Name = fullName,
            Phone = phone,
            Email = email,
            Address = "default",
        });
    }
    [TestMethod]
    [DataRow(1, "Đặng Thế Nhân55", "@3504984957", "aaa@gmail.com")]
    [DataRow(2, "Lê Vũ Lâm55", "@0234532565", "abc@yahoo.com")]
    [DataRow(3, "Nguyễn Tấn Phát55", "@54235235236", "xyz@gmail.com")]
    public async Task UpdateWithKeywordAsync(long id, string fullName, string phone, string email)
    {
        var newEntity = new MCustomerEntity()
        {
            Id = id,
            Name = fullName,
            Phone = phone,
            Email = email,
            Address = "default",
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
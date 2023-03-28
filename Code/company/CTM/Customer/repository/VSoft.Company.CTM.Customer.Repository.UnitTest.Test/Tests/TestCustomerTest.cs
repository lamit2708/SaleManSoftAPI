using VSoft.Company.CTM.Customer.Data.Entity.Models;
using VSoft.Company.CTM.Customer.Repository.UnitTest.Bases;
using VSoft.Company.CTM.Customer.Repository.UnitTest.Test.Values.GroupA;

namespace VSoft.Company.CTM.Customer.Repository.UnitTest.Test.Tests;

[TestClass]
public class TestCustomerTest : TestMgmtEntities
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
    public async Task GetCustomerByNameAsync(string name)
    {
        
        await RunTest("TestGetByIdAsync", async (r, log) =>
        {
            var e = await (r?.GetCustomersByNameAsync(name) ?? Task.FromResult(new List<MCustomerEntity>()));
            log(e.FirstOrDefault()?.Name ?? string.Empty);
        });
    }


    [TestMethod]
    [DataRow(1, DisplayName = "GetByIdAsync > 1")]
    [DataRow(2, DisplayName = "GetByIdAsync > 2")]
    public async Task GetByIdAsync(int id)
    {
        await TestGetByIdAsync(id);
    }

    [TestMethod]
    [DataRow("Đặng Thế Nhân")]
    [DataRow("Lê Vũ Lâm")]
    [DataRow("Nguyễn Tấn Phát")]
    public async Task CreateAsync(string fullName)
    {
        var e = new A01().GetCreateEntity();
        e.Name = fullName;
      
        await TestCreateAsync(e);
    }

    [TestMethod]
    [DataRow("Diễn giải 1", "Diễn giải 2", "Diễn giải 3")]
    public async Task CreateRangeAsync(string note1, string note2, string note3)
    {
        var e1 = new A01().GetCreateEntity(note1);
        var e2 = new A01().GetCreateEntity(note2);
        var e3 = new A01().GetCreateEntity(note3);       
        await TestCreateRangeAsync(e1, e2, e3);
    }

    [TestMethod]
    [DataRow(1, "Name 1")]
    [DataRow(2, "Name 2")]
   
    public async Task UpdateAsync(int id, string fullName)
    {
        var e = new A01().GetUpdateEntity(id, fullName);
        await TestUpdateAsync(e);
    }

    [TestMethod]
    [DataRow("63482 / Diễn giải 11", "63483 / Diễn giải 22", "63484 / Diễn giải 33")]
    public async Task UpdateRangeAsync(string data1, string data2, string data3)
    {
        var e1 = new A01().GetUpdateEntityFromData(data1);
        var e2 = new A01().GetUpdateEntityFromData(data2);
        var e3 = new A01().GetUpdateEntityFromData(data3);
        await TestUpdateRangeAsync(e1, e2, e3);
    }

    [TestMethod]
    [DataRow("Diễn giải A", "Diễn giải B", "63473 / Diễn giải 111", "63474 / Diễn giải 222", "63475 / Diễn giải 333", 1, 2)]
    public async Task SaveRangeAsync(string note1, string note2, string data1, string data2, string data3, long id1, long id2)
    {
        var ec1 = new A01().GetCreateEntity(note1);
        var ec2 = new A01().GetCreateEntity(note2);
        var eu1 = new A01().GetUpdateEntityFromData(data1);
        var eu2 = new A01().GetUpdateEntityFromData(data2);
        var eu3 = new A01().GetUpdateEntityFromData(data3);
        await TestSaveRangeAsync(new[] { ec1, ec2 }, new[] { eu1, eu2, eu3 }, new[] { id1, id2 });
    }

    [TestMethod]
    [DataRow("Diễn giải A1", "Diễn giải B1", "63473 / Diễn giải 1", "63474 / Diễn giải 2", "63475 / Diễn giải 3", 63478, 63479)]
    public async Task SaveRangeTransactionAsync(string note1, string note2, string data1, string data2, string data3, long id1, long id2)
    {
        var ec1 = new A01().GetCreateEntity(note1);
        var ec2 = new A01().GetCreateEntity(note2);
        var eu1 = new A01().GetUpdateEntityFromData(data1);
        var eu2 = new A01().GetUpdateEntityFromData(data2);
        var eu3 = new A01().GetUpdateEntityFromData(data3);
        await TestSaveRangeTransactionAsync(new[] { ec1, ec2 }, new[] { eu1, eu2, eu3 }, new[] { id1, id2 });
    }

    [TestMethod]
    [DataRow(63470)]
    [DataRow(63471)]
    [DataRow(63472)]
    public async Task DeleteAsync(int id)
    {
        await TestDeleteAsync(id);
    }

    [TestMethod]
    [DataRow(1, 2, 3)]
    public async Task DeleteRangeAsync(int id1, int id2, int id3)
    {
        await TestDeleteRangeAsync(id1, id2, id3);
    }
}
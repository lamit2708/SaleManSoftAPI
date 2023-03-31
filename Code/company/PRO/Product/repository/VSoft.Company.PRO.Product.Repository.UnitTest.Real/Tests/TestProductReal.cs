using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using VSoft.Company.PRO.Product.Data.Entity.Models;
using VSoft.Company.PRO.Product.Repository.UnitTest.Bases;
using VSoft.Company.PRO.Product.Repository.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.PRO.Product.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestProductReal : TestMgmtEntities
{
    protected override string TestName { get; set; } = "Real";

    [TestMethod]
    [DataRow(5, DisplayName = "GetByIdAsync > 1")]
    [DataRow(6, DisplayName = "GetByIdAsync > 2")]
    public async Task GetByIdAsync(int id)
    {
        await TestGetByIdAsync(id);
    }

    [TestMethod]
    [DataRow("Đặng Thế Nhân","3504984957","aaa@gmail.com")]
    [DataRow("Lê Vũ Lâm","0234532565","abc@yahoo.com")]
    [DataRow("Nguyễn Tấn Phát","54235235236","xyz@gmail.com")]
    public async Task CreateAsync(string fullName, string phone, string email)
    {
        var e = new A01().GetCreateEntity();
        e.Name = fullName;
        //e.Phone = phone;
        //e.Email = email;

        await TestCreateAsync(e);
    }

    [TestMethod]
    [DataRow(4,"Đặng Thế Nhân", "@3504984957", "aaa@gmail.com")]
    [DataRow(5,"Lê Vũ Lâm", "@0234532565", "abc@yahoo.com")]
    [DataRow(6,"Nguyễn Tấn Phát", "@54235235236", "xyz@gmail.com")]
    public async Task UpdateAsync(int id,string fullName, string phone, string email)
    {
        await TestUpdateAsync(new MProductEntity()
        {
            Id= id,
            Name= fullName,
            //Phone= phone,
            //Email= email,
            //Address="default",
        });
    }


    [TestMethod]
    [DataRow(1)]
    public async Task DeleteAsync(long id)
    {
        
        await TestDeleteAsync(id);
    }

    [TestMethod]
    // [DataRow("Đặng Thế Nhân1", "35049843957", "aaa@gmail.com")]
    // [DataRow("Lê Vũ Lâm1", "02345332565", "abc@yahoo.com")]
    [DataRow("Phần mềm tính tiền", "abc xyz", 20000,1)]
    public async Task CreateWithKeywordAsync(string fullName, string description, double price,int quantity)
    {
        var e = new A01().GetCreateEntity();
        e.Name = fullName;
        e.Description = description;
        e.Price = price;
        e.Quantity = quantity;
       

        await RunTest("CreateWithKeywordAsync", async (r, l) =>
        {
            var res = r?.CreateWithKeyword(e);
            LogEntity(res, l);
        });
    }
}
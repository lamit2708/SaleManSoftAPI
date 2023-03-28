using VSoft.Company.URO.UserRole.Data.Entity.Models;
using VSoft.Company.URO.UserRole.Repository.UnitTest.Bases;
using VSoft.Company.URO.UserRole.Repository.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.URO.UserRole.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestUserRoleReal : TestMgmtEntities
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
    [DataRow("Đặng Thế Nhân","3504984957","aaa@gmail.com")]
    [DataRow("Lê Vũ Lâm","0234532565","abc@yahoo.com")]
    [DataRow("Nguyễn Tấn Phát","54235235236","xyz@gmail.com")]
    public async Task CreateAsync(string fullName, string phone, string email)
    {
        var e = new A01().GetCreateEntity();
        //e.Name = fullName;
        //e.Phone = phone;
        //e.Email = email;

        await TestCreateAsync(e);
    }

    [TestMethod]
    [DataRow(4,"Đặng Thế Nhân", "@3504984957", "aaa@gmail.com")]
    [DataRow(5,"Lê Vũ Lâm", "@0234532565", "abc@yahoo.com")]
    [DataRow(6,"Nguyễn Tấn Phát", "@54235235236", "xyz@gmail.com")]
    public async Task UpdateAsync(long id,string fullName, string phone, string email)
    {
        await TestUpdateAsync(new MUserRoleEntity()
        {
            Id= id,
            //Name= fullName,
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
}
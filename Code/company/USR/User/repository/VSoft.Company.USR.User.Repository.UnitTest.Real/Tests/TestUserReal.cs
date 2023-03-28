using VSoft.Company.USR.User.Data.Entity.Models;
using VSoft.Company.USR.User.Repository.UnitTest.Bases;
using VSoft.Company.USR.User.Repository.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.USR.User.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestUserReal : TestMgmtEntities
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
    [DataRow("Đặng Thế Nhân","3504984957","nhan","123","aaa@gmail.com")]
    [DataRow("Lê Vũ Lâm","0234532565","lam","123","abc@yahoo.com")]
    [DataRow("Nguyễn Tấn Phát","54235235236","phat","123","xyz@gmail.com")]
    public async Task CreateAsync(string fullName, string phone,string username, string password, string email)
    {
        var e = new A01().GetCreateEntity();
        e.Name = fullName;
        e.Phone = phone;
        e.Username = username;
        e.Password = password;
        e.Email = email;
        e.TeamId = null;

        await TestCreateAsync(e);
    }

    [TestMethod]
    [DataRow(1,"Đặng Thế Nhân", "3504984957", "nhan111", "123456", "aaa@gmail.com")]
    [DataRow(2, "Lê Vũ Lâm", "0234532565", "lam111", "123456", "abc@yahoo.com")]
    [DataRow(3, "Nguyễn Tấn Phát", "54235235236", "phat111", "123456", "xyz@gmail.com")]
    public async Task UpdateAsync(int id,string fullName, string phone,string username, string password, string email)
    {
        await TestUpdateAsync(new MUserEntity()
        {
            Id= id,
            Name= fullName,
            Phone= phone,
            Username= username,
            Password= password,
            Email= email,
          
        });
    }


    [TestMethod]
    [DataRow(1)]
    public async Task DeleteAsync(int id)
    {
        
        await TestDeleteAsync(id);
    }
}
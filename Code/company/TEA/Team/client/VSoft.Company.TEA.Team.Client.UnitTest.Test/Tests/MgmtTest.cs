using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.TEA.Team.Api.UnitTest.Client.Bases;
using VSoft.Company.TEA.Team.Business.Dto.Request;
using VSoft.Company.TEA.Team.Client.UnitTest.Test.Values.GroupA;

namespace VSoft.Company.TEA.Team.Client.UnitTest.Test.Tests;

[TestClass]
public class MgmtTest : TestMgmtClient
{
    [TestMethod]
    [DataRow("DRV1-9084", DisplayName = "Case 1")]
    [DataRow("1fbdbe39-a443-4403-bb81-d4c070f18762", DisplayName = "Case 2")]
    public async Task FindAsync(string id)
    {
        await TestFindAsync(new MDtoRequestFindByInt()
        {
            Id = Int32.Parse(id),
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

    [TestMethod]
    [DataRow("Đặng Thế Nhân", "Ghi chú X1")]
    [DataRow("Lê Vũ Lâm", "Ghi chú X2")]
    [DataRow("Nguyễn Tấn Phát", "Ghi chú X3")]
    public async Task CreateAsync(string name, string desc)
    {
        var dto = new A01().GetCreateDto();
        //dto.FullName = name;
        
        await TestCreateAsync(new TeamInsertDtoRequest()
        {
            Data = dto
        });
    }

    [TestMethod]
    [DataRow("Diễn giải 1", "Diễn giải 2", "Diễn giải 3")]
    public async Task CreateRangeAsync(string note1, string note2, string note3)
    {
        var d1 = new A01().GetCreateDto(note1);
        var d2 = new A01().GetCreateDto(note2);
        var d3 = new A01().GetCreateDto(note3);
        await TestCreateRangeAsync(new TeamInsertRangeDtoRequest()
        {
            Data = new[] { d1, d2, d3 }

        });
    }

    [TestMethod]
    [DataRow(1, "Diễn giải 111", "Ghi chú 11")]
    [DataRow(2, "Diễn giải 212", "Ghi chú 22")]
    [DataRow(3, "Diễn giải 313", "Ghi chú 33")]
    public async Task UpdateAsync(int id, string note, string description)
    {
        var dto = new A01().GetUpdateDto(id, note, description);
        await TestUpdateAsync(new TeamUpdateDtoRequest()
        {
            Data = dto
        });
    }

    [TestMethod]
    [DataRow("63494 / Diễn giải 11", "63495 / Diễn giải 22", "63496 / Diễn giải 33")]
    public async Task UpdateRangeAsync(string data1, string data2, string data3)
    {
        var d1 = new A01().GetUpdateDtoFromData(data1);
        var d2 = new A01().GetUpdateDtoFromData(data2);
        var d3 = new A01().GetUpdateDtoFromData(data3);
        await TestUpdateRangeAsync(new TeamUpdateRangeDtoRequest()
        {
            Data = new[] { d1, d2, d3 }
        });
    }

    [TestMethod]
    [DataRow(63491)]
    [DataRow(63492)]
    [DataRow(63493)]
    public async Task DeleteAsync(int id)
    {
        await TestDeleteAsync(new TeamDeleteDtoRequest()
        {
            Id = id,
        });
    }

    [TestMethod]
    [DataRow(63494, 63495, 63496)]
    public async Task DeleteRangeAsync(int id1, int id2, int id3)
    {
        await TestDeleteRangeAsync(new TeamDeleteRangeDtoRequest()
        {
            Ids = new[] { id1, id2, id3 },
        });
    }


    [TestMethod]
    [DataRow("Diễn giải A1", "Diễn giải B1", "63473 / Diễn giải 111", "63474 / Diễn giải 222", "63475 / Diễn giải 333", 63497, 63498)]
    public async Task SaveRangeAsync(string note1, string note2, string data1, string data2, string data3, int id1, int id2)
    {
        var ec1 = new A01().GetCreateDto(note1);
        var ec2 = new A01().GetCreateDto(note2);
        var eu1 = new A01().GetUpdateDtoFromData(data1);
        var eu2 = new A01().GetUpdateDtoFromData(data2);
        var eu3 = new A01().GetUpdateDtoFromData(data3);
        await TestSaveRangeAsync(new TeamSaveRangeDtoRequest()
        {
            CreateData = new[] { ec1, ec2 },
            UpdateData = new[] { eu1, eu2, eu3 },
            DeleteIds = new[] { id1, id2 },
        });
    }
}
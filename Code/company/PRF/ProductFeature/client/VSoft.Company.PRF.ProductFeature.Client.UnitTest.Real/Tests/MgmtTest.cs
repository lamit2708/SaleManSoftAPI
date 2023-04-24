using System.Diagnostics;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Api.UnitTest.Client.Bases;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Data;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Client.UnitTest.Real.Values.GroupA;

namespace VSoft.Company.PRF.ProductFeature.Client.UnitTest.Real;

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
            LangCode = "VN",
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
    [DataRow("Quản lý hàng tồn kho 123", "Giúp phân tích tồn kho, và tình hình kinh doanh theo thời gian (ERP)", 40000000, 1)]
    //[DataRow("Báo cáo tồn kho", "Tự động phản ánh tăng giảm hàng hóa trong bán hàng, mua hàng, sản xuất và lưu kho", 30000000, 1)]
    //[DataRow("Quản lý sản phẩm", "Giúp phân tích mối quan hệ giữa khách hàng và sản phẩm ví dụ dòng sản phẩm nào bán chạy, khách hàng có độ tuổi nào, khu vực nào, giới tính nào, trình độ học vấn ra sao(CRM)", 20000000, 2)]
    //[DataRow("Quản lý sản phẩm", "Quản lý sản phẩm có mô hình giá, Tax, ship (EComerce)", 50000000, 3)]
    //[DataRow("Tính tiền", "Giúp nhân viên tính tiền, in hóa đơn", 10000000, 1)]

    public async Task CreateAsync(string name, string description, double price, int productId)
    {
        //var dto = new A01().GetCreateDto();
        //dto.FullName = name;
        var dto = new ProductFeatureDto() {
            Name = name,
            Description = description,
            Price = price,
            ProductId = productId
        };
        
       

        await TestCreateAsync(new ProductFeatureInsertDtoRequest()
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
        await TestCreateRangeAsync(new ProductFeatureInsertRangeDtoRequest()
        {
            Data = new[] { d1, d2, d3 }

        });
    }

    [TestMethod]
    [DataRow(2, "Quản lý hàng tồn kho", "Giúp phân tích tồn kho, và tình hình kinh doanh theo thời gian (ERP)", 40000000, 1)]
    //[DataRow(3, "Báo cáo tồn kho", "Tự động phản ánh tăng giảm hàng hóa trong bán hàng, mua hàng, sản xuất và lưu kho", 30000000, 1)]
    //[DataRow(4, "Quản lý sản phẩm", "Giúp phân tích mối quan hệ giữa khách hàng và sản phẩm ví dụ dòng sản phẩm nào bán chạy, khách hàng có độ tuổi nào, khu vực nào, giới tính nào, trình độ học vấn ra sao(CRM)", 20000000, 2)]
    //[DataRow(5, "Quản lý sản phẩm", "Quản lý sản phẩm có mô hình giá, Tax, ship (EComerce)", 50000000, 3)]
    public async Task UpdateAsync(int id, string name, string description, double price, int productId)
    {
        //var dto = new A01().GetUpdateDto(id, note, description);
        var dto = new ProductFeatureDto()
        {
            Id = id,
            Name = name,
            ProductId = productId,
            Description = description,
            Price = price,
        };
        await TestUpdateAsync(new ProductFeatureUpdateDtoRequest()
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
        await TestUpdateRangeAsync(new ProductFeatureUpdateRangeDtoRequest()
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
        await TestDeleteAsync(new ProductFeatureDeleteDtoRequest()
        {
            Id = id,
        });
    }

    [TestMethod]
    [DataRow(63494, 63495, 63496)]
    public async Task DeleteRangeAsync(int id1, int id2, int id3)
    {
        await TestDeleteRangeAsync(new ProductFeatureDeleteRangeDtoRequest()
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
        await TestSaveRangeAsync(new ProductFeatureSaveRangeDtoRequest()
        {
            CreateData = new[] { ec1, ec2 },
            UpdateData = new[] { eu1, eu2, eu3 },
            DeleteIds = new[] { id1, id2 },
        });
    }
}
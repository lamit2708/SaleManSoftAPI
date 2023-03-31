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
    [DataRow(1, "Hệ thống quản lý nhân viên, chấm công",200000000, 1,1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.","")]
    [DataRow(2, "Hệ thống chăm sóc khách hàng",100000000, 1,1, "Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.","")]
    //[DataRow(3, "Nguyễn Tấn Phát","54235235236","xyz@gmail.com")]
    [DataRow(3,"Hệ thống quản lý phòng trọ", 20000000,1,1, "Mọi thông tin về khách thuê trọ chi tiết có thể lưu trữ khi sử dụng phần mềm quản lý nhà trọ. Từ thông tin cá nhân tới hợp đồng cho thuê (giá cả, phí dịch vụ, thời gian, tiền cọc, số người ở…).","")]
    [DataRow(4, "Hệ thống quản lý trung tâm ngoại ngữ", 20000000, 1, 1, "Phần mềm quản lý có thể đóng vai trò như một trợ thủ đắc lực giúp ban lãnh đạo trung tâm có thể nắm bắt được tình hình doanh nghiệp, tình trạng học viên,có thể đưa ra nhận xét cái nhìn tổng quan cho chất lượng giảng dạy và đào tạo của các giảng viên.", "")]
    [DataRow(5, "Hệ thống quản lý quán cà phê", 20000000, 1, 1, "Phần mềm quản lý quán cafe giúp tính tiền, quản lý kho, quản lý dữ liệu khách hàng, quản lý nhân viên.", "")]
    [DataRow(6, "Hệ thống quản lý nhà hàng", 100000000, 1, 1, "Phần mềm quản lý bàn, hỗ trợ in bếp, quản lý nhân viên, quản lý kho", "")]
    public async Task CreateAsync(int id, string name, double price, int quantity, int categoryId, string description, string keyword)
    {
        var e = new A01().GetCreateEntity();
        e.Id = id;
        e.Name = name;
        e.Price =price;
        e.Quantity =quantity;
        e.CategoryId = categoryId;
        e.Description = description;
        e.Keyword = keyword;



        await TestCreateAsync(e);
    }

    [TestMethod]
    [DataRow(4,"Đặng Thế Nhân", "@3504984957", "aaa@gmail.com")]
    [DataRow(5,"Lê Vũ Lâm", "@0234532565", "abc@yahoo.com")]
    [DataRow(6,"Nguyễn Tấn Phát", "@54235235236", "xyz@gmail.com")]
    public async Task UpdateAsync(int id, string name, double price, int quantity, int categoryId, string description, string keyword)
    {
        await TestUpdateAsync(new MProductEntity()
        {
            Id= id,
            Name= name,
            Price= price,
            Quantity = 100,
            CategoryId = categoryId,
            Description= description,
            Keyword= keyword,
 
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
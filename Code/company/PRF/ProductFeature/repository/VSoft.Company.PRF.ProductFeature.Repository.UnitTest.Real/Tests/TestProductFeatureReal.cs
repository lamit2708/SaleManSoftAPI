using System.Globalization;
using System.Reflection;
using VSoft.Company.PRF.ProductFeature.Data.Entity.Models;
using VSoft.Company.PRF.ProductFeature.Repository.UnitTest.Bases;
using VSoft.Company.PRF.ProductFeature.Repository.UnitTest.Real.Values.GroupA;
using static Google.Protobuf.WellKnownTypes.Field.Types;

namespace VSoft.Company.PRF.ProductFeature.Repository.UnitTest.Real.Tests;

[TestClass]
public class TestProductFeatureReal : TestMgmtEntities
{
    protected override string TestName { get; set; } = "Real";

    [TestMethod]
    [DataRow(5, DisplayName = "GetByIdAsync > 1")]
    [DataRow(6, DisplayName = "GetByIdAsync > 2")]
    public async Task GetByIdAsync(int id)
    {
        await TestGetByIdAsync(id);
    }
    //+CRM: Analysis được mối quan hệ giữa khách hàng và sản phẩm, ví dụ khách hàng thích loại sản phẩm nào, style nào, bán chạy, độ tuổi bao nhiêu, địa phương nơi ở, giới tính, trình độ học vấn;
    //+ERP: Phân tích tồn kho, và tình hình kinh doanh theo thời gian;
    //+EComerce: Product phải có mô hình giá; Tax, ship;
    [TestMethod]
    
    [DataRow("Quản lý hàng tồn kho", "Giúp phân tích tồn kho, và tình hình kinh doanh theo thời gian (ERP)", 40000000, 1)]
    [DataRow("Báo cáo tồn kho", "Tự động phản ánh tăng giảm hàng hóa trong bán hàng, mua hàng, sản xuất và lưu kho", 30000000, 1)]
    [DataRow("Quản lý sản phẩm", "Giúp phân tích mối quan hệ giữa khách hàng và sản phẩm ví dụ dòng sản phẩm nào bán chạy, khách hàng có độ tuổi nào, khu vực nào, giới tính nào, trình độ học vấn ra sao(CRM)", 20000000, 2)]
    [DataRow("Quản lý sản phẩm", "Quản lý sản phẩm có mô hình giá, Tax, ship (EComerce)", 50000000, 3)]
    [DataRow("Tính tiền", "Giúp nhân viên tính tiền, in hóa đơn", 10000000, 1)]
    public async Task CreateAsync(string name, string description, double price, int productId)
    {
        await TestCreateAsync(new MProductFeatureEntity()
        {
            Name = name,
            ProductId = productId,
            Description = description,
            Price = price,

        });

    }

    [TestMethod]
    [DataRow(2,"Quản lý hàng tồn kho", "Giúp phân tích tồn kho, và tình hình kinh doanh theo thời gian (ERP)", 40000000, 1)]
    [DataRow(3,"Báo cáo tồn kho", "Tự động phản ánh tăng giảm hàng hóa trong bán hàng, mua hàng, sản xuất và lưu kho", 30000000, 1)]
    [DataRow(4,"Quản lý sản phẩm", "Giúp phân tích mối quan hệ giữa khách hàng và sản phẩm ví dụ dòng sản phẩm nào bán chạy, khách hàng có độ tuổi nào, khu vực nào, giới tính nào, trình độ học vấn ra sao(CRM)", 20000000, 2)]
    [DataRow(5,"Quản lý sản phẩm", "Quản lý sản phẩm có mô hình giá, Tax, ship (EComerce)", 50000000, 3)]
    public async Task UpdateAsync(int id, string name, string description, double price, int productId)
    {
        await TestUpdateAsync(new MProductFeatureEntity()
        {
            Id = id,
            Name = name,
            ProductId = productId,
            Description = description,
            Price = price,
        });
    }


    [TestMethod]
    [DataRow(1)]
    public async Task DeleteAsync(long id)
    {

        await TestDeleteAsync(id);
    }
}
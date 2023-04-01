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
    [DataRow(1, "Hệ thống quản lý nhân viên, chấm công", 200000000, 1, 1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.", "")]
    [DataRow(2, "Hệ thống chăm sóc khách hàng", 100000000, 1, 1, "Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.", "")]
    [DataRow(3, "Hệ thống quản lý phòng trọ", 20000000, 1, 1, "Mọi thông tin về khách thuê trọ chi tiết có thể lưu trữ khi sử dụng phần mềm quản lý nhà trọ. Từ thông tin cá nhân tới hợp đồng cho thuê (giá cả, phí dịch vụ, thời gian, tiền cọc, số người ở…).", "")]
    [DataRow(4, "Hệ thống quản lý trung tâm ngoại ngữ", 20000000, 1, 1, "Phần mềm quản lý giúp ban lãnh đạo có thể nắm bắt được tình hình trung tâm, tình trạng học viên, đưa ra cái nhìn tổng quan cho chất lượng giảng dạy của các giảng viên.", "")]
    [DataRow(5, "Hệ thống quản lý quán cà phê", 20000000, 1, 1, "Phần mềm quản lý quán cafe giúp tính tiền, quản lý kho, quản lý dữ liệu khách hàng, quản lý nhân viên.", "")]
    [DataRow(6, "Hệ thống quản lý nhà hàng", 100000000, 1, 1, "Phần mềm quản lý bàn, hỗ trợ in bếp, quản lý nhân viên, quản lý kho", "")]
    [DataRow(7, "Thiết kế website bất động sản", 50000000, 1, 2, "Website bất động sản là 1 hệ thống hỗ trợ trong các chiến lược marketing online, và là công cụ bán hàng đơn giản, hiệu quả.", "")]
    [DataRow(8, "Thiết kế website Forum, tin tức, rao vặt", 15000000, 1, 2, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử", "")]
    [DataRow(9, "Thiết kế website thương mại điện tử", 20000000, 1, 2, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử", "")]
    [DataRow(10, "Thiết kế website quản trị, giới thiệu doanh nghiệp", 20000000, 1, 2, "Website giới thiệu sản phẩm, dịch vụ, nhân sự, thế mạnh công ty, giúp quảng bá thương hiệu và tìm khách hàng hiệu quả", "")]
    [DataRow(11, "App thanh toán ví điện tử", 100000000, 1, 3, "App liên kết với nhiều ngân hàng tại Việt Nam và bạn dễ dàng nạp tiền vào ví một cách đơn giản và nhanh chóng, giúp nạp nạp thẻ điện thoại, thanh toán tiền điện nước, mua sắm online,...", "")]
    [DataRow(12, "App đặt vé du lịch", 20000000, 1, 3, "App đặt vé máy bay, vé tàu, xe; Đặt phòng khách sạn, homestay tuỳ thích; Đặt dịch vụ đưa đón sân bay; Đặt các vé tham quan với mức giá ưu đãi; Đặt tour du lịch chuyên nghiệp nâng cao trải nghiệm người dùng…", "")]
    [DataRow(13, "Nâng cấp hệ thống ERP", 100000000, 1, 4, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống ERP", "")]
    [DataRow(14, "Nâng cấp hệ thống CRM", 50000000, 1, 4, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống CRM", "")]
    [DataRow(15, "Nâng cấp hệ thống thương mại điện tử", 50000000, 1, 4, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử", "")]
    [DataRow(16, "Dịch vụ SEO", 3000000, 1, 5, "Cung cấp dịch vụ SEO tổng thể chuyên nghiệp. Phục vụ chủ yếu đối tượng khách hàng là công ty, doanh nghiệp lớn, vừa & nhỏ (SME) tại HCM & toàn quốc", "")]
    [DataRow(17, "Dịch vụ chạy quảng cáo Youtube, Facebook, Google Ads", 4000000, 1, 5, "Thực hiện hoạt động các hoạt động quảng cáo Digital Marketing trên các kênh YouTube, Facebook, Google Ads sẽ giúp các doanh nghiệp tiếp cận đông đảo khách hàng tiềm năng.", "")]
    [DataRow(18, "Quản trị nội dung, viết bài", 5000000, 1, 5, "Content Marketing là quá trình tạo ra và chia sẻ những nội dung có ý nghĩa một cách liên tục đến một đối tượng cụ thể, để đạt được mục tiêu tiếp thị theo từng giai đoạn khác nhau của doanh nghiệp.", "")]
    public async Task CreateSeedDataAsync(int id, string name, double price, int quantity, int categoryId, string description, string keyword)
    {
        var e = new A01().GetCreateEntity();
        e.Id = id;
        e.Name = name;
        e.Price = price;
        e.Quantity = quantity;
        e.CategoryId = categoryId;
        e.Description = description;
        e.Keyword = keyword;

        await TestCreateAsync(e);
    }
    [TestMethod]
    [DataRow( "Hệ thống quản lý nhân viên, chấm công", 200000000, 1, 1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.", "")]
    public async Task CreateAsync( string name, double price, int quantity, int categoryId, string description, string keyword)
    {
        var e = new A01().GetCreateEntity();
        e.Name = name;
        e.Price = price;
        e.Quantity = quantity;
        e.CategoryId = categoryId;
        e.Description = description;
        e.Keyword = keyword;

        await TestCreateAsync(e);
    }

    [TestMethod]
    [DataRow(1, "Hệ thống quản lý nhân viên, chấm công", 200000000, 1, 1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.", "")]
    [DataRow(2, "Hệ thống chăm sóc khách hàng", 100000000, 1, 1, "Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.", "")]
    [DataRow(3, "Hệ thống quản lý phòng trọ", 20000000, 1, 1, "Mọi thông tin về khách thuê trọ chi tiết có thể lưu trữ khi sử dụng phần mềm quản lý nhà trọ. Từ thông tin cá nhân tới hợp đồng cho thuê (giá cả, phí dịch vụ, thời gian, tiền cọc, số người ở…).", "")]
    [DataRow(4, "Hệ thống quản lý trung tâm ngoại ngữ", 20000000, 1, 1, "Phần mềm quản lý giúp ban lãnh đạo có thể nắm bắt được tình hình trung tâm, tình trạng học viên, đưa ra cái nhìn tổng quan cho chất lượng giảng dạy của các giảng viên.", "")]
    [DataRow(5, "Hệ thống quản lý quán cà phê", 20000000, 1, 1, "Phần mềm quản lý quán cafe giúp tính tiền, quản lý kho, quản lý dữ liệu khách hàng, quản lý nhân viên.", "")]
    [DataRow(6, "Hệ thống quản lý nhà hàng", 100000000, 1, 1, "Phần mềm quản lý bàn, hỗ trợ in bếp, quản lý nhân viên, quản lý kho", "")]
    [DataRow(7, "Thiết kế website bất động sản", 50000000, 1, 2, "Website bất động sản là 1 hệ thống hỗ trợ trong các chiến lược marketing online, và là công cụ bán hàng đơn giản, hiệu quả.", "")]
    [DataRow(8, "Thiết kế website Forum, tin tức, rao vặt", 15000000, 1, 2, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử", "")]
    [DataRow(9, "Thiết kế website thương mại điện tử", 20000000, 1, 2, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử", "")]
    [DataRow(10, "Thiết kế website quản trị, giới thiệu doanh nghiệp", 20000000, 1, 2, "Website giới thiệu sản phẩm, dịch vụ, nhân sự, thế mạnh công ty, giúp quảng bá thương hiệu và tìm khách hàng hiệu quả", "")]
    [DataRow(11, "App thanh toán ví điện tử", 100000000, 1, 3, "App liên kết với nhiều ngân hàng tại Việt Nam và bạn dễ dàng nạp tiền vào ví một cách đơn giản và nhanh chóng, giúp nạp nạp thẻ điện thoại, thanh toán tiền điện nước, mua sắm online,...", "")]
    [DataRow(12, "App đặt vé du lịch", 20000000, 1, 3, "App đặt vé máy bay, vé tàu, xe; Đặt phòng khách sạn, homestay tuỳ thích; Đặt dịch vụ đưa đón sân bay; Đặt các vé tham quan với mức giá ưu đãi; Đặt tour du lịch chuyên nghiệp nâng cao trải nghiệm người dùng…", "")]
    [DataRow(13, "Nâng cấp hệ thống ERP", 100000000, 1, 4, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống ERP", "")]
    [DataRow(14, "Nâng cấp hệ thống CRM", 50000000, 1, 4, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống CRM", "")]
    [DataRow(15, "Nâng cấp hệ thống thương mại điện tử", 50000000, 1, 4, "Hỗ trợ nâng cấp cải tiến các chức năng của hệ thống thương mại điện tử", "")]
    [DataRow(16, "Dịch vụ SEO", 3000000, 1, 5, "Cung cấp dịch vụ SEO tổng thể chuyên nghiệp. Phục vụ chủ yếu đối tượng khách hàng là công ty, doanh nghiệp lớn, vừa & nhỏ (SME) tại HCM & toàn quốc", "")]
    [DataRow(17, "Dịch vụ chạy quảng cáo Youtube, Facebook, Google Ads", 4000000, 1, 5, "Thực hiện hoạt động các hoạt động quảng cáo Digital Marketing trên các kênh YouTube, Facebook, Google Ads sẽ giúp các doanh nghiệp tiếp cận đông đảo khách hàng tiềm năng.", "")]
    [DataRow(18, "Quản trị nội dung, viết bài", 5000000, 1, 5, "Content Marketing là quá trình tạo ra và chia sẻ những nội dung có ý nghĩa một cách liên tục đến một đối tượng cụ thể, để đạt được mục tiêu tiếp thị theo từng giai đoạn khác nhau của doanh nghiệp.", "")]

    public async Task UpdateAsync(int id, string name, double price, int quantity, int categoryId, string description, string keyword)
    {
        await TestUpdateAsync(new MProductEntity()
        {
            Id = id,
            Name = name,
            Price = price,
            Quantity = quantity,
            CategoryId = categoryId,
            Description = description,
            Keyword = keyword,

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
    [DataRow("Phần mềm tính tiền", "abc xyz", 20000, 1)]
    public async Task CreateWithKeywordAsync(string fullName, string description, double price, int quantity)
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
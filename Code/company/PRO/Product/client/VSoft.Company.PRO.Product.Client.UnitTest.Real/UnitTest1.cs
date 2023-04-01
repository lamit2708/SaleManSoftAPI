using VSoft.Company.PRO.Product.Api.UnitTest.Client.Bases;
using VSoft.Company.PRO.Product.Business.Dto.Data;
using VSoft.Company.PRO.Product.Business.Dto.Request;


namespace VSoft.Company.PRO.Product.Api.UnitTest.Client.Real
{
    [TestClass]
    public class UnitTest1 : TestMgmtClient
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

       

        [TestMethod]
        [DataRow("Hệ thống quản lý nhân viên, chấm công", 200000000, 1, 1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.", "")]
        [DataRow("Hệ thống chăm sóc khách hàng", 100000000, 1, 1, "Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.", "")]
        [DataRow("Hệ thống quản lý phòng trọ", 20000000, 1, 1, "Mọi thông tin về khách thuê trọ chi tiết có thể lưu trữ khi sử dụng phần mềm quản lý nhà trọ. Từ thông tin cá nhân tới hợp đồng cho thuê (giá cả, phí dịch vụ, thời gian, tiền cọc, số người ở…).", "")]
        public async Task TestCreate(string name, double price, int quantity, int categoryId, string description, string keyword)
        {
            var e = new ProductDto();
            e.Name = name;
            e.Price = price;
            e.Quantity = quantity;
            e.CategoryId = categoryId;
            e.Description = description;
            e.Keyword = keyword;
            await TestCreateAsync(new ProductInsertDtoRequest()
            {
                Data = e
            });
        }

        [TestMethod]
        [DataRow(1, "Hệ thống quản lý nhân viên, chấm công", 200000000, 1, 1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.", "")]
        [DataRow(2, "Hệ thống chăm sóc khách hàng", 100000000, 1, 1, "Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.", "")]
        [DataRow(3, "Hệ thống quản lý phòng trọ", 20000000, 1, 1, "Mọi thông tin về khách thuê trọ chi tiết có thể lưu trữ khi sử dụng phần mềm quản lý nhà trọ. Từ thông tin cá nhân tới hợp đồng cho thuê (giá cả, phí dịch vụ, thời gian, tiền cọc, số người ở…).", "")]

        public async Task TestUpdate(int id, string name, double price, int quantity, int categoryId, string description, string keyword)
        {
            await TestUpdateAsync(new ProductUpdateDtoRequest()
            {
                Data = new ProductDto()
                {
                    Id = id,
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    CategoryId = categoryId,
                    Description = description,
                    Keyword = keyword,
                }
            });
        }

        [TestMethod]
        [DataRow(25)]
        [DataRow(26)]
        [DataRow(27)]
        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new ProductDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
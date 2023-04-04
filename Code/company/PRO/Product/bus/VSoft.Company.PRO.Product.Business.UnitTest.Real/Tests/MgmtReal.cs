using System.Xml.Linq;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRO.Product.Business.Dto.Data;
using VSoft.Company.PRO.Product.Business.Dto.Request;
using VSoft.Company.PRO.Product.Business.UnitTest.Bases;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace VSoft.Company.PRO.Product.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal : TestProductMgmt
    {
        [TestMethod]
        [DataRow(63491)]
        [DataRow(63492)]
        [DataRow(63493)]
        public async Task FindAsync(int id)
        {
            await TestFindAsync(new MDtoRequestFindByInt()
            {
                Id = id,
            });
        }

        [TestMethod]
        [DataRow(63494, 63495, 63496)]
        public async Task FindRangeAsync(int id1, int id2, int id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByInts()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }

        [TestMethod]
        [DataRow( "Hệ thống quản lý nhân viên, chấm công 3333", 200000000, 1, 1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.")]
        [DataRow( "Hệ thống chăm sóc khách hàng 3333", 100000000, 1, 1, "Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.")]
       
        public async Task TestCreate(string name, double price, int quantity, int categoryId, string description)
        {
            var e = new ProductDto();
            e.Name = name;
            e.Price = price;
            e.Quantity = quantity;
            e.CategoryId = categoryId;
            e.Description = description;
            await TestCreateAsync(new ProductInsertDtoRequest()
            {
                Data = e
            });
        }
        [TestMethod]
        [DataRow(1, "Hệ thống quản lý nhân viên, chấm công", 200000000, 1, 1, "Hệ thống giúp thu thập, giải quyết, lưu trữ, truyền đạt, phân phối các thông tin có liên quan đến nguồn nhân lực trong công ty để hỗ trợ cho việc ra quyết định.")]
        [DataRow(2, "Hệ thống chăm sóc khách hàng", 100000000, 1, 1, "Hệ thống CRM như một kho lưu trữ duy nhất để kết hợp các hoạt động bán hàng, tiếp thị, hỗ trợ khách hàng, giúp hợp lý hóa quy trình, chính sách và nhân lực trong một nền tảng.")]
        [DataRow(3, "Hệ thống quản lý phòng trọ", 20000000, 1, 1, "Mọi thông tin về khách thuê trọ chi tiết có thể lưu trữ khi sử dụng phần mềm quản lý nhà trọ. Từ thông tin cá nhân tới hợp đồng cho thuê (giá cả, phí dịch vụ, thời gian, tiền cọc, số người ở…).")]

        public async Task TestUpdate(int id, string name, double price, int quantity, int categoryId, string description)
        {
            
            var e = new ProductDto();
            e.Id    = id;
            e.Name = name;
            e.Price = price;
            e.Quantity = quantity;
            e.CategoryId = categoryId;
            e.Description = description;
            await TestUpdateAsync(new ProductUpdateDtoRequest()
            {
                Data = e
            });
        }


        [TestMethod]
        [DataRow(53)]

        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new ProductDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
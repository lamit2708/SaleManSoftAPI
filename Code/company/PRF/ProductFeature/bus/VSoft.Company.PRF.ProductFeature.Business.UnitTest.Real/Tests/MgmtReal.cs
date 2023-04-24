using System.Xml.Linq;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Data;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.UnitTest.Bases;

namespace VSoft.Company.PRF.ProductFeature.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal : TestProductFeatureMgmt
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

        [DataRow("Quản lý hàng tồn kho", "Giúp phân tích tồn kho, và tình hình kinh doanh theo thời gian (ERP)", 40000000, 1)]
        //[DataRow("Báo cáo tồn kho", "Tự động phản ánh tăng giảm hàng hóa trong bán hàng, mua hàng, sản xuất và lưu kho", 30000000, 1)]
        //[DataRow("Quản lý sản phẩm", "Giúp phân tích mối quan hệ giữa khách hàng và sản phẩm ví dụ dòng sản phẩm nào bán chạy, khách hàng có độ tuổi nào, khu vực nào, giới tính nào, trình độ học vấn ra sao(CRM)", 20000000, 2)]
        //[DataRow("Quản lý sản phẩm", "Quản lý sản phẩm có mô hình giá, Tax, ship (EComerce)", 50000000, 3)]
        //[DataRow("Tính tiền", "Giúp nhân viên tính tiền, in hóa đơn", 10000000, 1)]

        public async Task TestCreate(string name, string description, double price, int productId)
        {
            var e = new ProductFeatureDto();
            e.Name = name;
            e.ProductId = productId;
            e.Description = description;
            e.Price = price;
            await TestCreateAsync(new ProductFeatureInsertDtoRequest()
            {
                Data = e
            });
        }

        [TestMethod]
        [DataRow(2, "Quản lý hàng tồn kho", "Giúp phân tích tồn kho, và tình hình kinh doanh theo thời gian (ERP)", 40000000, 1)]
        [DataRow(3, "Báo cáo tồn kho", "Tự động phản ánh tăng giảm hàng hóa trong bán hàng, mua hàng, sản xuất và lưu kho", 30000000, 1)]
        [DataRow(4, "Quản lý sản phẩm", "Giúp phân tích mối quan hệ giữa khách hàng và sản phẩm ví dụ dòng sản phẩm nào bán chạy, khách hàng có độ tuổi nào, khu vực nào, giới tính nào, trình độ học vấn ra sao(CRM)", 20000000, 2)]
        [DataRow(5, "Quản lý sản phẩm", "Quản lý sản phẩm có mô hình giá, Tax, ship (EComerce)", 50000000, 3)]

        public async Task TestUpdate(int id, string name, string description, double price, int productId)
        {
            await TestUpdateAsync(new ProductFeatureUpdateDtoRequest()
            {
                Data = new ProductFeatureDto()
                {
                    Id = id,
                    Name = name,
                    ProductId = productId,
                    Description = description,
                    Price = price,
                }
            });
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new ProductFeatureDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
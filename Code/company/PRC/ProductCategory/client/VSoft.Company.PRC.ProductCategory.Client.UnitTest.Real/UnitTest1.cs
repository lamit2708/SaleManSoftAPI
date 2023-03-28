using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Api.UnitTest.Client.Bases;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Client.UnitTest.Test.Values.GroupA;
namespace VSoft.Company.PRC.ProductCategory.Api.UnitTest.Client.Real
{
    [TestClass]
    public class UnitTest1 : TestMgmtClient
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        public async Task FindRangeAsync(int id1, int id2, int id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByStrings()
            {
                Ids = new[] { id1.ToString(), id2.ToString(), id3.ToString() },
            });
        }

        [TestMethod]
        [DataRow("Thiết kế phần mềm")]
        [DataRow("Thiết kế website")]
        [DataRow("Thiết kế ứng dụng mobile")]
        [DataRow("Xây dựng hệ thống quản lý")]
        [DataRow("Dịch vụ Marketing")]
        public async Task CreateAsync(string name)
        {
            var dto = new A01().GetCreateDto();
            dto.Name = name;

            await TestCreateAsync(new ProductCategoryInsertDtoRequest()
            {
                Data = dto
            });
        }
        [TestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(12)]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(15)]
        [DataRow(16)]
        [DataRow(17)]
        [DataRow(18)]
        [DataRow(19)]
        [DataRow(20)]

        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new ProductCategoryDeleteDtoRequest()
            {
                Id = id,
            });
        }

        [TestMethod]
        [DataRow(1, "Thiết kế phần mềm")]
        [DataRow(2, "Thiết kế website")]
        [DataRow(3, "Thiết kế ứng dụng mobile")]
        [DataRow(4, "Xây dựng hệ thống quản lý")]
        [DataRow(5, "Dịch vụ Marketing")]
        public async Task UpdateAsync(int id, string name)
        {
            var dto = new A01().GetUpdateDto(id, name);
            await TestUpdateAsync(new ProductCategoryUpdateDtoRequest()
            {
                Data = dto
            });
        }
    }
}
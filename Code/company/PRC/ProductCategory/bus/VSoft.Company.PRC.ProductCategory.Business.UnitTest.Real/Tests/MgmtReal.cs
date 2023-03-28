using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Data;
using VSoft.Company.PRC.ProductCategory.Business.Dto.Request;
using VSoft.Company.PRC.ProductCategory.Business.UnitTest.Bases;

namespace VSoft.Company.PRC.ProductCategory.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal : TestProductCategoryMgmt
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public async Task FindAsync(int id)
        {
            await TestFindAsync(new MDtoRequestFindByInt()
            {
                Id = id,
            });
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        public async Task FindRangeAsync(int id1, int id2, int id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByInts()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }


        [TestMethod]
        [DataRow("Phần mềm")]
        [DataRow("Dự án web")]
        [DataRow("Dự án mobile")]
        public async Task TestCreate(string name)
        {
            var e = new ProductCategoryDto();
            e.Name = name;
           
            await TestCreateAsync(new ProductCategoryInsertDtoRequest()
            {
                Data = e
            });
        }
        [TestMethod]
        [DataRow(1, "Thiết kế phần mềm 1")] // 
        [DataRow(2, "Thiết kế website")]
        [DataRow(3, "Thiết kế ứng dụng mobile")]
        [DataRow(4, "Xây dựng hệ thống quản lý")]
        [DataRow(5, "Dịch vụ Marketing")]

        public async Task TestUpdate(int id, string name)
        {
            await TestUpdateAsync(new ProductCategoryUpdateDtoRequest()
            {
                Data = new ProductCategoryDto()
                {
                    Id=id,
                    Name = name
                    
                }
            });
        }

        [TestMethod]
        [DataRow(13)]
        [DataRow(14)]
        [DataRow(15)]
        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new ProductCategoryDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
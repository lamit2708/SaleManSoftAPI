using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Data;
using VSoft.Company.DQU.DealQuotation.Business.Dto.Request;
using VSoft.Company.DQU.DealQuotation.Business.UnitTest.Bases;

namespace VSoft.Company.DQU.DealQuotation.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal: TestDealQuotationMgmt
    {
        [TestMethod]
        [DataRow(63491)]
        [DataRow(63492)]
        [DataRow(63493)]
        public async Task FindAsync(long id)
        {
            await TestFindAsync(new MDtoRequestFindByLong()
            {
                Id = id,
            });
        }

        [TestMethod]
        [DataRow(63494, 63495, 63496)]
        public async Task FindRangeAsync(long id1, long id2, long id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByLongs()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }

        [TestMethod]
        [DataRow("Đặng Thế Nhân", "3504984957", "aaa@gmail.com")]
        [DataRow("Lê Vũ Lâm", "0234532565", "abc@yahoo.com")]
        [DataRow("Nguyễn Tấn Phát", "54235235236", "xyz@gmail.com")]
        public async Task TestCreate(string fullName, string phone, string email)
        {
            var e = new DealQuotationDto();
            //e.Name = fullName;
            //e.Phone = phone;
            //e.Email = email;
            await TestCreateAsync(new DealQuotationInsertDtoRequest()
            {
                Data = e
            });
        }

        [TestMethod]
        public async Task TestUpdate()
        {
            await TestUpdateAsync(new DealQuotationUpdateDtoRequest()
            {
                Data = new DealQuotationDto()
                {
                    //DQUname = "it.nhan7285",
                    //Password = "Welcome@7",
                    //FullName = "Đặng Thế Nhân 1",
                }
            });
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public async Task DeleteAsync(long id)
        {
            await TestDeleteAsync(new DealQuotationDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
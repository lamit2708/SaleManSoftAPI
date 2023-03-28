using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.UnitTest.Bases;

namespace VSoft.Company.CTM.Customer.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal: TestCustomerMgmt
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
            var e = new CustomerDto();
            e.Name = fullName;
            e.Phone = phone;
            e.Email = email;
            await TestCreateAsync(new CustomerInsertDtoRequest()
            {
                Data = e
            });
        }

        [TestMethod]
        [DataRow(1,"Đặng Thế Nhân", "3504984957", "aaa@gmail.com")]
        [DataRow(2,"Lê Vũ Lâm", "0234532565", "abc@yahoo.com")]
        [DataRow(3,"Nguyễn Tấn Phát", "54235235236", "xyz@gmail.com")]
        public async Task TestUpdate(int id, string fullName, string phone, string email)
        {
            await TestUpdateAsync(new CustomerUpdateDtoRequest()
            {
                Data = new CustomerDto()
                {
                   Id = id,
                   Name = fullName,
                   Phone = phone,
                   Email = email
                }
            });
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public async Task DeleteAsync(long id)
        {
            await TestDeleteAsync(new CustomerDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
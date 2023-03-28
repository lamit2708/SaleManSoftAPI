using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.ROL.Role.Business.Dto.Data;
using VSoft.Company.ROL.Role.Business.Dto.Request;
using VSoft.Company.ROL.Role.Business.UnitTest.Bases;

namespace VSoft.Company.ROL.Role.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal: TestRoleMgmt
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
        [DataRow("Đặng Thế Nhân", "3504984957", "aaa@gmail.com")]
        [DataRow("Lê Vũ Lâm", "0234532565", "abc@yahoo.com")]
        [DataRow("Nguyễn Tấn Phát", "54235235236", "xyz@gmail.com")]
        public async Task TestCreate(string fullName, string phone, string email)
        {
            var e = new RoleDto();
            e.Name = fullName;
            //e.Phone = phone;
            //e.Email = email;
            await TestCreateAsync(new RoleInsertDtoRequest()
            {
                Data = e
            });
        }

        [TestMethod]
        public async Task TestUpdate()
        {
            await TestUpdateAsync(new RoleUpdateDtoRequest()
            {
                Data = new RoleDto()
                {
                    //ROLname = "it.nhan7285",
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
            await TestDeleteAsync(new RoleDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
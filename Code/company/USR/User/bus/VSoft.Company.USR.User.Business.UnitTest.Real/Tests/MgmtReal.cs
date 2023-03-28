using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.USR.User.Business.Dto.Data;
using VSoft.Company.USR.User.Business.Dto.Request;
using VSoft.Company.USR.User.Business.UnitTest.Bases;

namespace VSoft.Company.USR.User.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class MgmtReal: TestUserMgmt
    {
        [TestMethod]
        [DataRow(2)]
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
        [DataRow(2, 3, 63496)]
        public async Task FindRangeAsync(int id1, int id2, int id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByInts()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }

        [TestMethod]
        [DataRow("Đặng Thế Nhân", "3504984957", "nhan", "123", "aaa@gmail.com")]
        [DataRow("Lê Vũ Lâm", "0234532565", "lam", "123", "abc@yahoo.com")]
        [DataRow("Nguyễn Tấn Phát", "54235235236", "phat", "123", "xyz@gmail.com")]
        public async Task TestCreate(string fullName, string phone, string username, string password, string email)
        {
            var e = new UserDto();
            e.Name = fullName;
            e.Phone = phone;
            e.Username = email;
            e.Password = email;
            e.Email = email;
            e.TeamId = null;
            await TestCreateAsync(new UserInsertDtoRequest()
            {
                Data = e
            });
        }

        [TestMethod]
        [DataRow(4, "Đặng Thế Nhân1", "3504984957", "nhan111", "123456", "aaa@gmail.com")]
        [DataRow(5, "Lê Vũ Lâm1", "0234532565", "lam111", "123456", "abc@yahoo.com")]
        [DataRow(6, "Nguyễn Tấn Phát1", "54235235236", "phat111", "123456", "xyz@gmail.com")]
        public async Task TestUpdate(int id, string fullName, string phone, string username, string password, string email)
        {
            await TestUpdateAsync(new UserUpdateDtoRequest()
            {
                Data = new UserDto()
                {
                    Id = id,
                    Name = fullName,
                    Phone = phone,
                    Username = username,
                    Password = password,
                    Email = email,
                }
            });
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public async Task DeleteAsync(int id)
        {
            await TestDeleteAsync(new UserDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
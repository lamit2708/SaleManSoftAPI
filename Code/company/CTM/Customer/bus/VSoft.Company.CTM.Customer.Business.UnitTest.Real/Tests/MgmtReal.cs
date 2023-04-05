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
        [DataRow(1, 2, 3)]
        public async Task FindRangeAsync(long id1, long id2, long id3)
        {
            await TestFindRangeAsync(new MDtoRequestFindRangeByLongs()
            {
                Ids = new[] { id1, id2, id3 },
            });
        }

        [TestMethod]
        [DataRow("Nguyễn Ngọc Ngân", "0923232611", "ngan@gmail.com", "22 Đặng Văn Bi, TP Thủ Đức", true, 1)]
        //[DataRow("Lê Vũ Lâm", "0923232312", "lam@gmail.com", "32 Kha Vạn Cân, TP Thủ Đức", true, 1)]
        //[DataRow("Vũ Thị Thọ", "0923232313", "tho@gmail.com", "32 Tô Ngọc Vân, TP Thủ Đức", false, 2)]


        public async Task TestCreate(string name, string phone, string email, string address, bool gender, int priority)
        {

            var e = new CustomerDto();
            e.Name = name;
            e.Phone = phone;
            e.Email = email;
            e.Address = address;
            e.Gender = gender;
            e.PriorityId = priority;
            await TestCreateAsync(new CustomerInsertDtoRequest()
            {
                Data = e
            });
        }
        [TestMethod]
        [DataRow(1, "Nguyễn Văn Nam", "0923232411", "nam@gmail.com", "22 Đặng Văn Bi, TP Thủ Đức", true, 1)]
        [DataRow(2, "Lê Thanh Hoàng", "0923232412", "hoang@gmail.com", "32 Kha Vạn Cân, TP Thủ Đức", true, 1)]
        [DataRow(3, "Vũ Thị Thọ", "0923232413", "tho@gmail.com", "32 Tô Ngọc Vân, TP Thủ Đức", false, 2)]
        [DataRow(4, "Trương Anh Tuấn", "0923232414", "tuan@gmail.com", "32 Tô Ngọc Vân, TP Thủ Đức", true, 2)]
        public async Task TestUpdate(int id, string name, string phone, string email, string address, bool gender, int priority)
        {

            var e = new CustomerDto();
            e.Id = id;
            e.Name = name;
            e.Phone = phone;
            e.Email = email;
            e.Address = address;
            e.Gender = gender;
            e.PriorityId = priority;
            await TestUpdateAsync(new CustomerUpdateDtoRequest()
            {
                Data = e
            });
        }

        [TestMethod]
        [DataRow(20)]
        //[DataRow(12)]
        public async Task DeleteAsync(long id)
        {
            await TestDeleteAsync(new CustomerDeleteDtoRequest()
            {
                Id = id,
            });
        }
    }
}
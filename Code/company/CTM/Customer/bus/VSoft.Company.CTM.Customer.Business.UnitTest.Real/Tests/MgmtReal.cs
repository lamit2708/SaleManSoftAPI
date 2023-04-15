using System.Globalization;
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
		[DataRow("Lê Ngọc Lan", "0434634266", "lanngoc@gmail.com", "66 Phạm Văn Đồng, TP Thủ Đức", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
		//public async Task CreateWithKeywordAsync(string fullName, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)

		public async Task TestCreate(string name, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
		{

            var e = new CustomerDto();
			e.Name = name;
			e.Phone = phone;
			e.Email = email;
			e.Address = address;
			e.Gender = gender;
			e.BirthDate = DateTime.ParseExact(birthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			e.PriorityId = priorityId;
			e.CustomerSourceId = customerSourceId;
			e.IsMarrage = isMarrage;
			e.Hobby = hobby;
			e.Job = job;
			e.IsBought = isBought;
			await TestCreateAsync(new CustomerInsertDtoRequest()
            {
                Data = e
            });
        }
        [TestMethod]
		[DataRow(25, "Nguyễn Thị Tuyết", "0434634277", "tuyetthi@gmail.com", "77 Lý Thường Kiệt,Q10, TP HCM", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
		[DataRow(26, "Lê Ngọc Lan", "0434634266", "lanngoc@gmail.com", "66 Phạm Văn Đồng, TP Thủ Đức", true, "1985-08-10", 1, 1, true, "Công nghệ", "IT", false)]
		//public async Task UpdateAsync(long id, string fullName, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
	    public async Task TestUpdate(long id, string name, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
		{

            var e = new CustomerDto();
            e.Id = id;
			e.Name = name;
			e.Phone = phone;
			e.Email = email;
			e.Address = address;
			e.Gender = gender;
			e.BirthDate = DateTime.ParseExact(birthDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			e.PriorityId = priorityId;
			e.CustomerSourceId = customerSourceId;
			e.IsMarrage = isMarrage;
			e.Hobby = hobby;
			e.Job = job;
			e.IsBought = isBought;
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
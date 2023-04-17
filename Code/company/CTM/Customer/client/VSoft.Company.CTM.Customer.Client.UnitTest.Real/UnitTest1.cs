using System.Globalization;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;
using VSoft.Company.CTM.Customer.Api.UnitTest.Client.Bases;
using VSoft.Company.CTM.Customer.Business.Dto.Data;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
namespace VSoft.Company.CTM.Customer.Api.UnitTest.Client.Real
{
    [TestClass]
    public class UnitTest1 : TestMgmtClient
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
		[TestMethod]
		[DataRow("Nguyễn Ngọc Ngân", "0975634266", "nganngoc@gmail.com", "61 Phạm Văn Đồng, TP Thủ Đức", true, "1985-08-10", 1, 1, true, "shopping", "Kế toán", false)]
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
       [DataRow(1, "Nguyễn Văn Nam", "04346321111", "namnguyen@gmail.com", "77 Lý Thường Kiệt,Q10, TP HCM", true, "1990-04-17", 1, 1, true, "Thể thao", "Trưởng bộ phận Marketing", false)]
		[DataRow(2, "Lê Thanh Hoàng", "04346322222", "hoangle@gmail.com", "66 Phạm Văn Đồng, TP Thủ Đức", true, "1983-07-20", 1, 1, true, "Du lịch", "Giám đốc bán hàng", false)]
		public async Task TestUpdate(int id, string name, string phone, string email, string address, bool gender, string birthDate, int priorityId, int customerSourceId, bool isMarrage, string hobby, string job, bool isBought)
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
        [DataRow(21)]
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
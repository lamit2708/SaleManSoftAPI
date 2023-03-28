using VSoft.Company.UCU.UserCustomer.Business.UnitTest.Bases;
using VSoft.Company.UCU.UserCustomer.Business.UnitTest.Test.Values.GroupA;

namespace VSoft.Company.UCU.UserCustomer.Business.UnitTest.Test.Tests
{
    [TestClass]
    public class JSonTest : TestUserCustomerMgmt
    {
        [TestMethod]
        [DataRow("Đặng Thế Nhân")]      
        public async Task WriteCreateJsonAsync(string fullName)
        {
            var dto = new A01().GetCreateDto();
            //dto.Name = fullName;            
            await WriteJSonAsync(dto);
        }

        [TestMethod]
        [DataRow("Diễn giải 1", "Diễn giải 2", "Diễn giải 3")]
        public async Task WriteCreateRangeJsonAsync(string name1, string name2, string name3)
        {
            var d1 = new A01().GetCreateDto(name1);
            var d2 = new A01().GetCreateDto(name2);
            var d3 = new A01().GetCreateDto(name3);
            await WriteJSonAsync(new[] { d1, d2, d3 });
        }

        [TestMethod]
        [DataRow(1, "Diễn giải 111", "Ghi chú 11")]
        [DataRow(2, "Diễn giải 212", "Ghi chú 22")]
        [DataRow(3, "Diễn giải 313", "Ghi chú 33")]
        public async Task WriteUpdateJsonAsync(int id, string name, string description)
        {
            var dto = new A01().GetUpdateDto(id, name);
            await WriteJSonAsync(dto);
        }

        [TestMethod]
        [DataRow("63510 / Diễn giải 11", "63511 / Diễn giải 22", "63512 / Diễn giải 33")]
        public async Task WriteUpdateRangeJsonAsync(string data1, string data2, string data3)
        {
            var d1 = new A01().GetUpdateDtoFromData(data1);
            var d2 = new A01().GetUpdateDtoFromData(data2);
            var d3 = new A01().GetUpdateDtoFromData(data3);
            await WriteJSonAsync(new[] { d1, d2, d3 });
        }

        [TestMethod]
        [DataRow(63512 ,63511 ,63510 ,63508 ,63507 ,63506 ,63505 ,63504 ,63503)]
        public async Task WriteDeleteRangeJsonAsync(params int[] ids)
        {
            await WriteJSonAsync(ids?.Select(i => i.ToString()));
        }

    }
}
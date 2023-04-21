using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Api.DtoClient.Token.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.UnitTest.Bases;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Business.Dto.Request;
using VSoft.Company.CIN.CustomerInfo.Client.Models;
using VSoft.Company.CIN.CustomerInfo.Client.Provider.Services;
using VSoft.Company.CIN.CustomerInfo.Client.Services;
using Model = VSoft.Company.CIN.CustomerInfo.Business.Dto.Data.CustomerInfoDto;
namespace VSoft.Company.CIN.CustomerInfo.Api.UnitTest.Client.Bases
{
    public class TestMgmtClient : ApiClientTest<Model>
    {
        protected ICustomerInfoClient Client => GetService<ICustomerInfoClient>() ?? throw new Exception("Client is null!");       
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
           nameof(Model.Id),
           // nameof(Model.FullName),
           
        };

        //protected string Token { get; } = "";
        protected string Token { get; } = "";
        protected override void RegisterServices()
        {
            ServiceCollection?.AddSingleton<MCustomerInfoClient>();
            ServiceCollection?.AddSingleton(new TokenService().Init(Token));
            ServiceCollection?.AddSingleton<ICustomerInfoClient, CustomerInfoClient>();
        }
       
        protected async Task TestFindAsync(MDtoRequestFindByString request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var client = GetService<ICustomerInfoClient>();            
                var res = await Client.FindAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestFindRangeAsync(MDtoRequestFindRangeByStrings request)
        {
            await RunTest("TestFindRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");               
                var res = await Client.FindRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateAsync(CustomerInfoInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);               
                var res = await Client.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(CustomerInfoInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);              
                var res = await Client.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(CustomerInfoUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);                
                var res = await Client.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(CustomerInfoUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);               
                var res = await Client.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(CustomerInfoDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");                
                var res = await Client.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(CustomerInfoDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");               
                var res = await Client.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(CustomerInfoSaveRangeDtoRequest request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request.CreateData;
                var updateDtos = request.UpdateData;
                var deleteIds = request.DeleteIds;
                var rs = await Client.SaveRangeAsync(request);
                LogDtos(rs?.CreatedData, log);
                LogDtos(rs?.UpdatedData, log);
                LogDtos(rs?.DeletedData, log);
            });

        }
    }
}

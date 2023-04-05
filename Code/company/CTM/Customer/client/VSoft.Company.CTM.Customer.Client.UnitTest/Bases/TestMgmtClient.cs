using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Api.DtoClient.Token.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.UnitTest.Bases;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Client.Models;
using VSoft.Company.CTM.Customer.Client.Provider.Services;
using VSoft.Company.CTM.Customer.Client.Services;
using Model = VSoft.Company.CTM.Customer.Business.Dto.Data.CustomerDto;
namespace VSoft.Company.CTM.Customer.Api.UnitTest.Client.Bases
{
    public class TestMgmtClient : ApiClientTest<Model>
    {
        protected ICustomerClient Client => GetService<ICustomerClient>() ?? throw new Exception("Client is null!");       
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
           nameof(Model.Id),
            nameof(Model.Name),
           
        };

        //protected string Token { get; } = "";
        protected string Token { get; } = "";
        protected override void RegisterServices()
        {
            ServiceCollection?.AddSingleton<MCustomerClient>();
            ServiceCollection?.AddSingleton(new TokenService().Init(Token));
            ServiceCollection?.AddSingleton<ICustomerClient, CustomerClient>();
        }
       
        protected async Task TestFindAsync(MDtoRequestFindByString request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var client = GetService<ICustomerClient>();            
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

        protected async Task TestCreateAsync(CustomerInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);               
                var res = await Client.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(CustomerInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);              
                var res = await Client.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(CustomerUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);                
                var res = await Client.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(CustomerUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);               
                var res = await Client.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(CustomerDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");                
                var res = await Client.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(CustomerDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");               
                var res = await Client.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(CustomerSaveRangeDtoRequest request)
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

using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Api.DtoClient.Token.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.UnitTest.Bases;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Business.Dto.Request;
using VSoft.Company.DST.DealStep.Client.Models;
using VSoft.Company.DST.DealStep.Client.Provider.Services;
using VSoft.Company.DST.DealStep.Client.Services;
using Model = VSoft.Company.DST.DealStep.Business.Dto.Data.DealStepDto;
namespace VSoft.Company.DST.DealStep.Api.UnitTest.Client.Bases
{
    public class TestMgmtClient : ApiClientTest<Model>
    {
        protected IDealStepClient Client => GetService<IDealStepClient>() ?? throw new Exception("Client is null!");       
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
           nameof(Model.Id),
            //nameof(Model.FullName),
           
        };

        //protected string Token { get; } = "";
        protected string Token { get; } = "";
        protected override void RegisterServices()
        {
            ServiceCollection?.AddSingleton<MDealStepClient>();
            ServiceCollection?.AddSingleton(new TokenService().Init(Token));
            ServiceCollection?.AddSingleton<IDealStepClient, DealStepClient>();
        }
       
        protected async Task TestFindAsync(MDtoRequestFindByString request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var client = GetService<IDealStepClient>();            
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

        protected async Task TestCreateAsync(DealStepInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);               
                var res = await Client.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(DealStepInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);              
                var res = await Client.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(DealStepUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);                
                var res = await Client.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(DealStepUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);               
                var res = await Client.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(DealStepDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");                
                var res = await Client.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(DealStepDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");               
                var res = await Client.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(DealStepSaveRangeDtoRequest request)
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

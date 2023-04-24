using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Api.DtoClient.Token.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.UnitTest.Bases;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Business.Dto.Request;
using VSoft.Company.PRF.ProductFeature.Client.Models;
using VSoft.Company.PRF.ProductFeature.Client.Provider.Services;
using VSoft.Company.PRF.ProductFeature.Client.Services;
using Model = VSoft.Company.PRF.ProductFeature.Business.Dto.Data.ProductFeatureDto;
namespace VSoft.Company.PRF.ProductFeature.Api.UnitTest.Client.Bases
{
    public class TestMgmtClient : ApiClientTest<Model>
    {
        protected IProductFeatureClient Client => GetService<IProductFeatureClient>() ?? throw new Exception("Client is null!");
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
           nameof(Model.Id),
            //nameof(Model.FullName),
           
        };

        //protected string Token { get; } = "";
        protected string Token { get; } = "";
        protected override void RegisterServices()
        {
            ServiceCollection?.AddSingleton<MProductFeatureClient>();
            ServiceCollection?.AddSingleton(new TokenService().Init(Token));
            ServiceCollection?.AddSingleton<IProductFeatureClient, ProductFeatureClient>();
        }

        protected async Task TestFindAsync(MDtoRequestFindByInt request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var client = GetService<IProductFeatureClient>();
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

        protected async Task TestCreateAsync(ProductFeatureInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var res = await Client.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(ProductFeatureInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var res = await Client.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(ProductFeatureUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var res = await Client.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(ProductFeatureUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var res = await Client.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(ProductFeatureDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var res = await Client.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(ProductFeatureDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var res = await Client.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(ProductFeatureSaveRangeDtoRequest request)
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
        protected async Task TestGetAll(MDtoRequestFindByInt request)
        {
            await RunTest("TestGetAll", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var client = GetService<IProductFeatureClient>();
                var res = await Client.GetAll();
                LogResponse(res, log);
            });

        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Api.DtoClient.Token.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.UnitTest.Bases;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Business.Dto.Request;
using VSoft.Company.VDT.VDealTag.Client.Models;
using VSoft.Company.VDT.VDealTag.Client.Provider.Services;
using VSoft.Company.VDT.VDealTag.Client.Services;
using Model = VSoft.Company.VDT.VDealTag.Business.Dto.Data.VDealTagDto;
namespace VSoft.Company.VDT.VDealTag.Api.UnitTest.Client.Bases
{
    public class TestMgmtClient : ApiClientTest<Model>
    {
        protected IVDealTagClient Client => GetService<IVDealTagClient>() ?? throw new Exception("Client is null!");       
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
           nameof(Model.Id),
            nameof(Model.CustomerName),
           
        };

        //protected string Token { get; } = "";
        protected string Token { get; } = "";
        protected override void RegisterServices()
        {
            ServiceCollection?.AddSingleton<MVDealTagClient>();
            ServiceCollection?.AddSingleton(new TokenService().Init(Token));
            ServiceCollection?.AddSingleton<IVDealTagClient, VDealTagClient>();
        }
       
        protected async Task TestFindAsync(MDtoRequestFindByString request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var client = GetService<IVDealTagClient>();            
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
    }
}

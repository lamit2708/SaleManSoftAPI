using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.UnitTest.Bases;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VSoft.Company.VDT.VDealTag.Business.Provider.Services;
using VSoft.Company.VDT.VDealTag.Business.Services;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Repository.Efc.Provider.Services;
using VSoft.Company.VDT.VDealTag.Repository.Services;
using Model = VSoft.Company.VDT.VDealTag.Business.Dto.Data.VDealTagDto;
namespace VSoft.Company.VDT.VDealTag.Business.UnitTest.Bases
{
    public class TestVDealTagMgmt : BusinessTest<Model>
    {
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
            nameof(Model.Id),
            nameof(Model.CustomerName),
           
        };

        protected override void RegisterServices()
        {
            ServiceCollection?.AddDbContext<VDealTagDbContext>((builder) =>
            {
                builder.UseMySQL(new MDbConnectionCfg());
            });

            ServiceCollection?.AddScoped<IVDealTagRepository, EfcVDealTagRepository>();
            ServiceCollection?.AddScoped<IVDealTagMgmtBus, VDealTagMgmtBus>();
        }


        protected async Task TestGetFullNameByIdAsync(MDtoRequestFindByLong dto)
        {
            await RunTest("TestGetByIdAsync", async (log) =>
            {
                var bus = GetService<IVDealTagMgmtBus>();
                if (bus == null) return;
                var res = await bus.GetFullNameAsync(dto);
                LogResponse(res, log, "FullName");
            });
        }


        protected async Task TestFindAsync(MDtoRequestFindByLong request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var bus = GetService<IVDealTagMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestFindRangeAsync(MDtoRequestFindRangeByLongs request)
        {
            await RunTest("TestFindRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var bus = GetService<IVDealTagMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindRangeAsync(request);
                LogResponse(res, log);
            });
        }
    }
}
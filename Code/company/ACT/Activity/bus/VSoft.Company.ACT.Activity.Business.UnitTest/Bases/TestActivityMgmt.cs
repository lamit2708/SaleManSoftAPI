using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.UnitTest.Bases;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VSoft.Company.ACT.Activity.Business.Dto.Request;
using VSoft.Company.ACT.Activity.Business.Provider.Services;
using VSoft.Company.ACT.Activity.Business.Services;
using VSoft.Company.ACT.Activity.Data.Db.Contexts;
using VSoft.Company.ACT.Activity.Repository.Efc.Provider.Services;
using VSoft.Company.ACT.Activity.Repository.Services;
using Model = VSoft.Company.ACT.Activity.Business.Dto.Data.ActivityDto;
namespace VSoft.Company.ACT.Activity.Business.UnitTest.Bases
{
    public class TestActivityMgmt : BusinessTest<Model>
    {
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
            nameof(Model.Id),
            nameof(Model.Name),
           
        };

        protected override void RegisterServices()
        {
            ServiceCollection?.AddDbContext<ActivityDbContext>((builder) =>
            {
                builder.UseMySQL(new MDbConnectionCfg());
            });

            ServiceCollection?.AddScoped<IActivityRepository, EfcActivityRepository>();
            ServiceCollection?.AddScoped<IActivityMgmtBus, ActivityMgmtBus>();
        }


        protected async Task TestGetFullNameByIdAsync(MDtoRequestFindByInt dto)
        {
            await RunTest("TestGetByIdAsync", async (log) =>
            {
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.GetFullNameAsync(dto);
                LogResponse(res, log, "FullName");
            });
        }


        protected async Task TestFindAsync(MDtoRequestFindByInt request)
        {
            await RunTest("TestFindAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestFindRangeAsync(MDtoRequestFindRangeByInts request)
        {
            await RunTest("TestFindRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateAsync(ActivityInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(ActivityInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(ActivityUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(ActivityUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(ActivityDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(ActivityDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(ActivitySaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                // var deleteEntities = deleteIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
                var rs = await bus.SaveRangeAsync(request);
                LogDtos(rs?.CreatedData, log);
                LogDtos(rs?.UpdatedData, log);
                LogDtos(rs?.DeletedData, log);
            });

        }

        protected async Task TestSaveRangeTransactionAsync(ActivitySaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<IActivityMgmtBus>();
                if (bus == null) return;
                // var deleteEntities = deleteIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
                var rs = await bus.SaveRangeTransactionAsync(request);
                LogDtos(rs?.CreatedData, log);
                LogDtos(rs?.UpdatedData, log);
                LogDtos(rs?.DeletedData, log);
            });

        }
    }
}
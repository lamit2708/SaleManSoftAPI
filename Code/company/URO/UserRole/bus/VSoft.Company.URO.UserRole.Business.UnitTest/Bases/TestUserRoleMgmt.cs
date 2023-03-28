using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.UnitTest.Bases;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VSoft.Company.URO.UserRole.Business.Dto.Request;
using VSoft.Company.URO.UserRole.Business.Provider.Services;
using VSoft.Company.URO.UserRole.Business.Services;
using VSoft.Company.URO.UserRole.Data.Db.Contexts;
using VSoft.Company.URO.UserRole.Repository.Efc.Provider.Services;
using VSoft.Company.URO.UserRole.Repository.Services;
using Model = VSoft.Company.URO.UserRole.Business.Dto.Data.UserRoleDto;
namespace VSoft.Company.URO.UserRole.Business.UnitTest.Bases
{
    public class TestUserRoleMgmt : BusinessTest<Model>
    {
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
            nameof(Model.Id),
            nameof(Model.UserId),
           
        };

        protected override void RegisterServices()
        {
            ServiceCollection?.AddDbContext<UserRoleDbContext>((builder) =>
            {
                builder.UseMySQL(new MDbConnectionCfg());
            });

            ServiceCollection?.AddScoped<IUserRoleRepository, EfcUserRoleRepository>();
            ServiceCollection?.AddScoped<IUserRoleMgmtBus, UserRoleMgmtBus>();
        }


        protected async Task TestGetFullNameByIdAsync(MDtoRequestFindByLong dto)
        {
            await RunTest("TestGetByIdAsync", async (log) =>
            {
                var bus = GetService<IUserRoleMgmtBus>();
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
                var bus = GetService<IUserRoleMgmtBus>();
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
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateAsync(UserRoleInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(UserRoleInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(UserRoleUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(UserRoleUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(UserRoleDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(UserRoleDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(UserRoleSaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<IUserRoleMgmtBus>();
                if (bus == null) return;
                // var deleteEntities = deleteIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
                var rs = await bus.SaveRangeAsync(request);
                LogDtos(rs?.CreatedData, log);
                LogDtos(rs?.UpdatedData, log);
                LogDtos(rs?.DeletedData, log);
            });

        }

        protected async Task TestSaveRangeTransactionAsync(UserRoleSaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<IUserRoleMgmtBus>();
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
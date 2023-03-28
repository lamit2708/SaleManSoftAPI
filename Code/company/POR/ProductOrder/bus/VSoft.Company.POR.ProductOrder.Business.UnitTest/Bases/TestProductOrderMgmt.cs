using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Business.Dto.Request;
using VegunSoft.Framework.Business.UnitTest.Bases;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VSoft.Company.POR.ProductOrder.Business.Dto.Request;
using VSoft.Company.POR.ProductOrder.Business.Provider.Services;
using VSoft.Company.POR.ProductOrder.Business.Services;
using VSoft.Company.POR.ProductOrder.Data.Db.Contexts;
using VSoft.Company.POR.ProductOrder.Repository.Efc.Provider.Services;
using VSoft.Company.POR.ProductOrder.Repository.Services;
using Model = VSoft.Company.POR.ProductOrder.Business.Dto.Data.ProductOrderDto;
namespace VSoft.Company.POR.ProductOrder.Business.UnitTest.Bases
{
    public class TestProductOrderMgmt : BusinessTest<Model>
    {
        protected override List<string>? LogFields { get; set; } = new List<string>()
        {
            nameof(Model.Id),
            nameof(Model.OrderId),
           
        };

        protected override void RegisterServices()
        {
            ServiceCollection?.AddDbContext<ProductOrderDbContext>((builder) =>
            {
                builder.UseMySQL(new MDbConnectionCfg());
            });

            ServiceCollection?.AddScoped<IProductOrderRepository, EfcProductOrderRepository>();
            ServiceCollection?.AddScoped<IProductOrderMgmtBus, ProductOrderMgmtBus>();
        }


        protected async Task TestGetFullNameByIdAsync(MDtoRequestFindByInt dto)
        {
            await RunTest("TestGetByIdAsync", async (log) =>
            {
                var bus = GetService<IProductOrderMgmtBus>();
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
                var bus = GetService<IProductOrderMgmtBus>();
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
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                var res = await bus.FindRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateAsync(ProductOrderInsertDtoRequest request)
        {
            await RunTest("TestCreateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestCreateRangeAsync(ProductOrderInsertRangeDtoRequest request)
        {
            await RunTest("TestCreateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                var res = await bus.CreateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestUpdateAsync(ProductOrderUpdateDtoRequest request)
        {
            await RunTest("TestUpdateAsync", async (log) =>
            {
                var dto = request.Data;
                LogDto(dto, log);
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateAsync(request);
                LogResponse(res, log);

            });
        }

        protected async Task TestUpdateRangeAsync(ProductOrderUpdateRangeDtoRequest request)
        {
            await RunTest("TestUpdateRangeAsync", async (log) =>
            {
                var dtos = request.Data;
                LogDtos(dtos, log);
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                var res = await bus.UpdateRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestDeleteAsync(ProductOrderDeleteDtoRequest request)
        {
            await RunTest("TestDeleteAsync", async (log) =>
            {
                log($"Input Id: {request.Id}");
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteAsync(request);
                LogResponse(res, log);
            });

        }

        protected async Task TestDeleteRangeAsync(ProductOrderDeleteRangeDtoRequest request)
        {
            await RunTest("TestDeleteRangeAsync", async (log) =>
            {
                log($"Input Ids: {request.Ids}");
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                var res = await bus.DeleteRangeAsync(request);
                LogResponse(res, log);
            });
        }

        protected async Task TestSaveRangeAsync(ProductOrderSaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<IProductOrderMgmtBus>();
                if (bus == null) return;
                // var deleteEntities = deleteIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
                var rs = await bus.SaveRangeAsync(request);
                LogDtos(rs?.CreatedData, log);
                LogDtos(rs?.UpdatedData, log);
                LogDtos(rs?.DeletedData, log);
            });

        }

        protected async Task TestSaveRangeTransactionAsync(ProductOrderSaveRangeDtoRequest? request)
        {
            await RunTest("TestSaveRangeAsync", async (log) =>
            {
                var createDtos = request?.CreateData;
                var updateDtos = request?.UpdateData;
                var deleteIds = request?.DeleteIds;
                //LogDtos(createDtos, log);
                //LogDtos(updateDtos, log);
                var bus = GetService<IProductOrderMgmtBus>();
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
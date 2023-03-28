using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Repository.UnitTest.Bases;
using VSoft.Company.PRC.ProductCategory.Data.Db.Contexts;
using VSoft.Company.PRC.ProductCategory.Repository.Efc.Provider.Services;
using VSoft.Company.PRC.ProductCategory.Repository.Services;
using Model = VSoft.Company.PRC.ProductCategory.Data.Entity.Models.MProductCategoryEntity;

namespace VSoft.Company.PRC.ProductCategory.Repository.UnitTest.Bases;


public class TestMgmtEntities : RepositoryTest<ProductCategoryDbContext, IProductCategoryRepository, Model>
{
    protected override List<string>? LogFields { get; set; } = new List<string>()
    {
        nameof(Model.Id),

        nameof(Model.Name),

    };

    protected override void RegisterServices()
    {
        ServiceCollection?.AddDbContext<ProductCategoryDbContext>((builder) =>
        {
            builder.UseMySQL(DbConnectionCfg).EnableSensitiveDataLogging();
        });
        ServiceCollection?.AddScoped<IProductCategoryRepository, EfcProductCategoryRepository>();
    }

    protected async Task TestGetFullNameByIdAsync(int id)
    {
        await RunTest("TestGetByIdAsync", async (r, l) =>
        {
            var e = await (r?.GetFullNameAsync(id) ?? Task.FromResult<string?>(null));
            l(e ?? string.Empty);
        });
    }

    protected async Task TestGetByIdAsync(int id)
    {
        await RunTest("TestGetByIdAsync", async (r, l) =>
        {
            var e = await (r?.GetByIdAsync(id) ?? Task.FromResult<Model?>(null));
            LogEntity(e, l);
        });
    }

    protected async Task TestCreateAsync(Model entity)
    {
        await RunTest("TestAddProductCategory", async (r, l) =>
        {
            var e = await (r?.CreateAsync(entity) ?? Task.FromResult<Model?>(null));
            LogEntity(e, l);
        });

    }

    protected async Task TestCreateRangeAsync(params Model[] entities)
    {
        await RunTest("TestAddProductCategory", async (r, l) =>
        {
            var rs = await (r?.CreateRangeAsync(entities) ?? Task.FromResult<IEnumerable<Model>?>(null));
            LogEntities(rs, l);
        });

    }

    protected async Task TestUpdateAsync(Model newEntity)
    {
        await RunTest("TestUpdateProductCategory", async (r, l) =>
        {
            var dbEntity = await (r?.GetByIdAsync(newEntity.Id) ?? Task.FromResult<Model?>(null));
            if (dbEntity != null)
            {
                var e = await (r?.UpdateAsync(dbEntity, newEntity) ?? Task.FromResult<Model?>(null));
                LogEntity(e, l);
                return;
            }
            l($"Id: {newEntity?.Id} update false!");
        });

    }

    protected async Task TestUpdateRangeAsync(params Model[] entities)
    {
        await RunTest("TestAddProductCategory", async (r, l) =>
        {
            var rs = await (r?.UpdateRangeAsync(entities) ?? Task.FromResult<IEnumerable<Model>?>(null));
            LogEntities(rs, l);
        });

    }

    protected async Task TestSaveRangeAsync(Model[] createEntities, Model[] updateEntities, int[]? deleteEntitiesIds)
    {
        await RunTest("TestAddProductCategory", async (r, l) =>
        {
            var deleteEntities = deleteEntitiesIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
            var rs = await (r?.SaveRangeAsync(new MSaveRangeParams<Model>()
            {
                CreateEntities = createEntities,
                UpdateEntities = updateEntities,
                DeleteEntities = deleteEntities,

            }) ?? Task.FromResult<MSaveRangeResults<Model>?>(null));
            LogEntities(rs?.CreateEntities, l);
            LogEntities(rs?.UpdateEntities, l);
            LogEntities(rs?.DeleteEntities, l);
        });

    }

    protected async Task TestSaveRangeTransactionAsync(Model[] createEntities, Model[] updateEntities, int[]? deleteEntitiesIds)
    {
        await RunTest("TestAddProductCategory", async (r, l) =>
        {
            var deleteEntities = deleteEntitiesIds != null ? (await r.GetByIdsAsync(deleteEntitiesIds)) : null;
            var rs = await (r?.SaveRangeTransactionAsync(new MSaveRangeParams<Model>()
            {
                CreateEntities = createEntities,
                UpdateEntities = updateEntities,
                DeleteEntities = deleteEntities,

            }) ?? Task.FromResult<MSaveRangeResults<Model>?>(null));
            LogEntities(rs?.CreateEntities, l);
            LogEntities(rs?.UpdateEntities, l);
            LogEntities(rs?.DeleteEntities, l);
        });

    }

    protected async Task TestDeleteAsync(int id)
    {
        await RunTest("TestDelProductCategory", async (r, l) =>
        {
            var productCategory = await (r?.GetByIdAsync(id) ?? Task.FromResult<Model?>(null));
            if (productCategory != null)
            {

                var e = await (r?.DeleteAsync(productCategory) ?? Task.FromResult<Model?>(null));
                LogEntity(productCategory, l);
                return;
            }
            l($"Id: {productCategory?.Id} delete false!");
        });

    }

    protected async Task TestDeleteRangeAsync(params int[] ids)
    {
        await RunTest("TestDelProductCategory", async (r, l) =>
        {
            var rsEntities = await (r?.GetByIdsAsync(ids) ?? Task.FromResult<IEnumerable<Model>?>(null));
            if (rsEntities != null)
            {

                var rs = await (r?.DeleteRangeAsync(rsEntities) ?? Task.FromResult<IEnumerable<Model>?>(null));
                LogEntities(rs, l);
                return;
            }
            l($"Ids: {ids} delete false!");
        });

    }
}
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;
using VegunSoft.Framework.Repository.Model.Params;
using VegunSoft.Framework.Repository.Model.Results;
using VegunSoft.Framework.Repository.UnitTest.Bases;
using VSoft.Company.VDT.VDealTag.Data.Db.Contexts;
using VSoft.Company.VDT.VDealTag.Repository.Efc.Provider.Services;
using VSoft.Company.VDT.VDealTag.Repository.Services;
using Model = VSoft.Company.VDT.VDealTag.Data.Entity.Models.MVDealTagEntity;

namespace VSoft.Company.VDT.VDealTag.Repository.UnitTest.Bases;


public class TestMgmtEntities : RepositoryTest<VDealTagDbContext, IVDealTagRepository, Model>
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
            builder.UseMySQL(DbConnectionCfg).EnableSensitiveDataLogging();
        });
        ServiceCollection?.AddScoped<IVDealTagRepository, EfcVDealTagRepository>();
    }

    protected async Task TestGetFullNameByIdAsync(long id)
    {
        await RunTest("TestGetByIdAsync", async (r, l) =>
        {
            var e = await (r?.GetFullNameAsync(id) ?? Task.FromResult<string?>(null));
            l(e ?? string.Empty);
        });
    }

    protected async Task TestGetByIdAsync(long id)
    {
        await RunTest("TestGetByIdAsync", async (r, l) =>
        {
            var e = await (r?.GetByIdAsync(id) ?? Task.FromResult<Model?>(null));
            LogEntity(e, l);
        });
    }
}
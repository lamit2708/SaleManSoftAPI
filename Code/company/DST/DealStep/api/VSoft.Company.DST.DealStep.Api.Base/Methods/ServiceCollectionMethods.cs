using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.DST.DealStep.Business.Provider.Services;
using VSoft.Company.DST.DealStep.Business.Services;
using VSoft.Company.DST.DealStep.Data.Db.Contexts;
using VSoft.Company.DST.DealStep.Repository.Services;
using VSoft.Company.DST.DealStep.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.DST.DealStep.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealStepServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<DealStepDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IDealStepRepository, EfcDealStepRepository>();
            services.AddScoped<IDealStepMgmtBus, DealStepMgmtBus>();
           
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.DSH.DealStepHistory.Business.Provider.Services;
using VSoft.Company.DSH.DealStepHistory.Business.Services;
using VSoft.Company.DSH.DealStepHistory.Data.Db.Contexts;
using VSoft.Company.DSH.DealStepHistory.Repository.Services;
using VSoft.Company.DSH.DealStepHistory.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.DSH.DealStepHistory.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealStepHistoryServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<DealStepHistoryDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IDealStepHistoryRepository, EfcDealStepHistoryRepository>();
            services.AddScoped<IDealStepHistoryMgmtBus, DealStepHistoryMgmtBus>();
           
        }
    }
}

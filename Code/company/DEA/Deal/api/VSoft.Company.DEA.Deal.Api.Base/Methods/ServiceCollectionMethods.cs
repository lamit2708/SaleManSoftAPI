using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.DEA.Deal.Business.Provider.Services;
using VSoft.Company.DEA.Deal.Business.Services;
using VSoft.Company.DEA.Deal.Data.Db.Contexts;
using VSoft.Company.DEA.Deal.Repository.Services;
using VSoft.Company.DEA.Deal.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.DEA.Deal.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<DealDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IDealRepository, EfcDealRepository>();
            services.AddScoped<IDealMgmtBus, DealMgmtBus>();
           
        }
    }
}

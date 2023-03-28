using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.DAC.DealActivity.Business.Provider.Services;
using VSoft.Company.DAC.DealActivity.Business.Services;
using VSoft.Company.DAC.DealActivity.Data.Db.Contexts;
using VSoft.Company.DAC.DealActivity.Repository.Services;
using VSoft.Company.DAC.DealActivity.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.DAC.DealActivity.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterDealActivityServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<DealActivityDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IDealActivityRepository, EfcDealActivityRepository>();
            services.AddScoped<IDealActivityMgmtBus, DealActivityMgmtBus>();
           
        }
    }
}

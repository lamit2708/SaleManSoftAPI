using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.ACT.Activity.Business.Provider.Services;
using VSoft.Company.ACT.Activity.Business.Services;
using VSoft.Company.ACT.Activity.Data.Db.Contexts;
using VSoft.Company.ACT.Activity.Repository.Services;
using VSoft.Company.ACT.Activity.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.ACT.Activity.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterActivityServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<ActivityDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IActivityRepository, EfcActivityRepository>();
            services.AddScoped<IActivityMgmtBus, ActivityMgmtBus>();
           
        }
    }
}

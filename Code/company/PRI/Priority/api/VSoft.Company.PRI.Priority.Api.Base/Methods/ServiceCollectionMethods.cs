using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.PRI.Priority.Business.Provider.Services;
using VSoft.Company.PRI.Priority.Business.Services;
using VSoft.Company.PRI.Priority.Data.Db.Contexts;
using VSoft.Company.PRI.Priority.Repository.Services;
using VSoft.Company.PRI.Priority.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.PRI.Priority.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterPriorityServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<PriorityDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IPriorityRepository, EfcPriorityRepository>();
            services.AddScoped<IPriorityMgmtBus, PriorityMgmtBus>();
           
        }
    }
}

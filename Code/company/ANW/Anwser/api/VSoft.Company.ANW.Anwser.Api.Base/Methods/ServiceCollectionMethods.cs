using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.ANW.Anwser.Business.Provider.Services;
using VSoft.Company.ANW.Anwser.Business.Services;
using VSoft.Company.ANW.Anwser.Data.Db.Contexts;
using VSoft.Company.ANW.Anwser.Repository.Services;
using VSoft.Company.ANW.Anwser.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.ANW.Anwser.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterAnwserServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<AnwserDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IAnwserRepository, EfcAnwserRepository>();
            services.AddScoped<IAnwserMgmtBus, AnwserMgmtBus>();
           
        }
    }
}

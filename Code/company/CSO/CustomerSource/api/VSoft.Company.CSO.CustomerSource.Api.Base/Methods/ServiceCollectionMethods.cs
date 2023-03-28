using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.CSO.CustomerSource.Business.Provider.Services;
using VSoft.Company.CSO.CustomerSource.Business.Services;
using VSoft.Company.CSO.CustomerSource.Data.Db.Contexts;
using VSoft.Company.CSO.CustomerSource.Repository.Services;
using VSoft.Company.CSO.CustomerSource.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.CSO.CustomerSource.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterCustomerSourceServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<CustomerSourceDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<ICustomerSourceRepository, EfcCustomerSourceRepository>();
            services.AddScoped<ICustomerSourceMgmtBus, CustomerSourceMgmtBus>();
           
        }
    }
}

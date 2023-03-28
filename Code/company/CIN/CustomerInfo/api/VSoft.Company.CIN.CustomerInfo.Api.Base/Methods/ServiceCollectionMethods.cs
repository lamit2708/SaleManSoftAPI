using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.CIN.CustomerInfo.Business.Provider.Services;
using VSoft.Company.CIN.CustomerInfo.Business.Services;
using VSoft.Company.CIN.CustomerInfo.Data.Db.Contexts;
using VSoft.Company.CIN.CustomerInfo.Repository.Services;
using VSoft.Company.CIN.CustomerInfo.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.CIN.CustomerInfo.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterCustomerInfoServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<CustomerInfoDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<ICustomerInfoRepository, EfcCustomerInfoRepository>();
            services.AddScoped<ICustomerInfoMgmtBus, CustomerInfoMgmtBus>();
           
        }
    }
}

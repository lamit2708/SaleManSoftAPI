using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.CTM.Customer.Business.Provider.Services;
using VSoft.Company.CTM.Customer.Business.Services;
using VSoft.Company.CTM.Customer.Data.Db.Contexts;
using VSoft.Company.CTM.Customer.Repository.Services;
using VSoft.Company.CTM.Customer.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.CTM.Customer.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterCustomerServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<CustomerDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<ICustomerRepository, EfcCustomerRepository>();
            services.AddScoped<ICustomerMgmtBus, CustomerMgmtBus>();
           
        }
    }
}

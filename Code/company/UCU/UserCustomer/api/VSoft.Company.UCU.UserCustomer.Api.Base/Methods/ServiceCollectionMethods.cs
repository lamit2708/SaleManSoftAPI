using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VegunSoft.Framework.Efc.Cfg.Configs;
using VSoft.Company.UCU.UserCustomer.Business.Provider.Services;
using VSoft.Company.UCU.UserCustomer.Business.Services;
using VSoft.Company.UCU.UserCustomer.Data.Db.Contexts;
using VSoft.Company.UCU.UserCustomer.Repository.Services;
using VSoft.Company.UCU.UserCustomer.Repository.Efc.Provider.Services;
using VegunSoft.Framework.Efc.Provider.MySQL.Methods;

namespace VSoft.Company.UCU.UserCustomer.Api.Base.Methods
{
    public static class ServiceCollectionMethods
    {
        public static void RegisterUserCustomerServices(this IServiceCollection services, ConfigurationManager configuration, string? connectionKey = null)
        {
            services.AddDbContext<UserCustomerDbContext>(options =>
            {
                var cfg = new MDbConnectionCfg();
                if (!string.IsNullOrEmpty(connectionKey))
                {
                    cfg.ConnectionKey = connectionKey;
                }
                options.UseMySQL(cfg, configuration);
            });
            services.AddScoped<IUserCustomerRepository, EfcUserCustomerRepository>();
            services.AddScoped<IUserCustomerMgmtBus, UserCustomerMgmtBus>();
           
        }
    }
}
